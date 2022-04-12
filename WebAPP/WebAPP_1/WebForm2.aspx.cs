using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace WebAPP_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string source = @"Server=DESKTOP-DD3FU43\SQLEXPRESS;uid=sa;pwd=1004;database=KosaDB";
            string source = @"Data Source=DESKTOP-DD3FU43\SQLEXPRESS;Initial Catalog=KosaDB;Integrated Security=SSPI;";
            //1. db connect
            SqlConnection conn = new SqlConnection(source);
            conn.Open();

            //2. instruction 
            String sql = "SELECT * FROM EMP WHERE EMPNO=" + Request["empno"];
            SqlCommand cmd = new SqlCommand(sql, conn);

            //3. instruction exe
            SqlDataReader reader = cmd.ExecuteReader();

            //4. show pages

            Response.Write("<table border=1>");

            while (reader.Read())
            {
                Response.Write("<tr>");

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Response.Write("<td>" + reader[i] + "</td>");
                }
                Response.Write("</tr>");
            }

            Response.Write("</table>");

            // 5. db close
            reader.Close();
            conn.Close();
        }
    }
}