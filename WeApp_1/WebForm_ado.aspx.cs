using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Data 작업
using System.Data;
using System.Data.SqlClient;

namespace WeApp_1
{
    public partial class WebForm_ado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //연결 문자열 생성
            string strConn = @"Data Source=DESKTOP-DD3FU43\SQLEXPRESS;Initial Catalog=kosadb;Integrated Security=SSPI;";
            //string strConn = @"Data Source=DESKTOP-DD3FU43\SQLEXPRESS;uid=sa;pwd=1004;database=kosadb";
            //연결 객체 생성
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();//연결 정보를 통해 DB통신 시도

            //Response.Write(conn.State + "<br>");

            //conn.Close(); //연결 해제

            //Response.Write(conn.State);

            string sql = "select * from emp where empno=" + Request["empno"]; //get , post 데이터 받아서

            //명령객체 만들기
            SqlCommand cmd = new SqlCommand(sql, conn); 

            //명령실행하기
            SqlDataReader reader = cmd.ExecuteReader();

            //결과 출력하기

            Response.Write("<table border=1>");
            while (reader.Read()) {  //data row 수 만큼
                Response.Write("<tr>");
                for (int i = 0; i < reader.FieldCount; i++) { //row의 컬럼개수 만큼
                    Response.Write("<td>" +  reader[i]   +"</td>");
                }
                Response.Write("</tr>");
            }
            Response.Write("</table>");

            //자원해제 (네트워크 , IO) 명시적으로
            reader.Close();
            conn.Close();

            //http://localhost:50109/WebForm_ado.aspx?empno=7902  테스트
        }
    }
}