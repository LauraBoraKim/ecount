using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;
using System.Data.SqlClient;
namespace WebApp_Procedure
{
    public partial class WebForm_Proc : System.Web.UI.Page
    {
        /*
        Create procedure user_regprocedure

         @UName varchar(50),
         @UAddress varchar(50),
         @Gender varchar(6),
         @U_Password varchar(50)
          AS
          BEGIN
             INSERT INTO user_registration VALUES (@UName,@UAddress,@Gender,@U_Password)
          END



        */
        SqlConnection conn = null;
        SqlCommand cmd = null;
        //다른 함수에서도 사용된다면
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegiser_Click(object sender, EventArgs e)  //클릭이벤트에 동작하는 함수
        {
            string strConn = @"Data Source=DESKTOP-DD3FU43\SQLEXPRESS;uid=sa;pwd=1004;database=kosaDB";
            conn = new SqlConnection(strConn);
            conn.Open();    

            SqlCommand cmd = new SqlCommand("user_regprocedure", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@UName", txt_name.Text);  // C# request[""] ,  request.getParameter("")
            cmd.Parameters.AddWithValue("@UAddress",txt_address.Text);
            cmd.Parameters.AddWithValue("@Gender", DropDownList1.SelectedItem.Value);
            cmd.Parameters.AddWithValue("@U_Password", txt_pwd.Text);

            cmd.ExecuteNonQuery();
            conn.Close();

            lbl_msg.Text = "Record Inserted";



        }
    }
}