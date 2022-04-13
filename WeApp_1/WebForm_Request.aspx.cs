using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeApp_1
{
    public partial class WebForm_Request : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack) //처음 게시라면
            {
                Response.Write(
                    "[1] 폼이 처음 로드할 때에만 실행<br />");
            }
            if (Page.IsPostBack == false) //처음 게시라면
            {
                Response.Write(
                    "[2] 폼이 처음 로드할 때에만 실행<br />");
            }



            /*
             웹서버가 내장하고 기본 객체 
             1. request (요청)     :  클라이언트 서버에 요청을 하게 되면 서버에서 생성되는 객체  (정보:클라이언트 정보)
                                     1.1 : 클라이언트에서 입력한 값 (회원가입정보)
                                     1.2 : 클라이언트 웹 브라우져 버전 , 요청 정보 ....request 
             
            2. response (응답)     : 서버가 가진 정보를 클라이언트에게 보는는 객체 (response.write())

             3. session
             4. application
             5. server 
             
            
            
            원칙적으로 Page  2개

            1.회원가입 할거야 -> 서버
              서버가 register.jsp -> 회원가입 데이터 보낼게 registerok.jsp

            2.webform 하나가 화면 단과 처리단 .....


             */
            string struserid = "";
            string strpassword = String.Empty;
            string strname = "";
            string strage = String.Empty;

            //1. request객체의 QueryString 컬렉션  Get
            struserid = Request["userid"];

            //2. request객체의 params 컬렉션 Post
            strpassword = Request.Params["password"];

            strname = Request.Form["name"];

            strage = Request["age"];


            string strMsg = String.Format("입력한 아이디:{0} 이고<br />" + "암호는 {1} 이고 , 이름은 {2} 이고 , 나이는 {3} 입니다",
                                           struserid, strpassword,strname,strage);
            Response.Write(strMsg); 
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            //원칙적인 방법은 
            //클라이언트에서 전송된 Data >> Request 객체를 통해 전달 받는 것이 가장 일반적인 방식

            //원칙적인 방법 말고 [서버컨트롤의 속성]을 사용해서 정보를 얻을 수 있다
            string username = name.Text;
            int userage = Convert.ToInt16(age.Text);
            userdata.Text = username;
            userdata2.Text = userage.ToString();

           // Console.WriteLine("username: " + username);
           // Console.WriteLine("userage: " + userage);

        }

    }
}