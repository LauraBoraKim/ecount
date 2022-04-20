using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MyApp.Models;
namespace MyApp.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld


        //localhost:9541/HelloWorld
        /*
        public string Index()
        {
            // return View();  //view  생성하고 싶다면 > Views > HelloWorld > index.chtml > view 생성
            return "<h3>my HelloWorld site</h3>";
        }
        */

        public ActionResult Index() { 
            
            return View();  //Views >> HelloWorld >> Index.chtml 뷰로 정의  
        }



        //http://localhost:51315/HelloWorld/welcome
        //url: "{controller}/{action}/{id}",   RouteConfig.cs

        //http://localhost:51315/HelloWorld/welcome?name=kglim&numtime=10
        /* 
        public string welcome(string name , int numtime = 1) {

            return HttpUtility.HtmlEncode("Hello  :" + name + " , numtime : " + numtime);
        } 
        */

        //http://localhost:51315/HelloWorld/welcome/12?name=kkkk
        public string welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello  :" + name + " , ID : " + ID);
        }


        //http://localhost:51315/HelloWorld/welcome/world/100    >> Hello :world , ID : 100
        //http://localhost:51315/HelloWorld/welcome/100/world    >> Hello :100 , ID : 1


        // type: "POST"
        [HttpPost]
        public JsonResult ajaxMethod(string name) {

            PersonModel person = new PersonModel
            {
                Name = name,
                DateTime = DateTime.Now.ToString()
            }; 
            return Json(person);
        }


        public JsonResult empMethod()
        {
            Employee emp = new Employee()
            {
                ID = "Emp23",
                Name = "Steven Clark",
                Mobile = "825415426"
            };
            return Json(emp, JsonRequestBehavior.AllowGet);
        }

        //http://localhost:51315/HelloWorld/kosaworld?name=kglim&num=10
        public ActionResult kosaworld(string name, int num = 1) {
            ViewBag.Message = "Hello world " + name;
            ViewBag.num = num;

            return View();  
    
        }

        //http://localhost:51315/HelloWorld/UserData
        public ActionResult UserData() {

            //1. 요청함수 (Action) 만든 데이터  View 전달

            //1. 요청 받기 

            //2. 데이터 처리 
            //2.1 클라이언트에서 넘어온 데이터  
            // parameter    public ActionResult UserData(string a, string b)
            // url http://localhost:51315/HelloWorld/UserData/100/200/300   

            //2.2.DAO를 통해서 생성된 데이터 
            //Model 에 객체 요청 >>  EmpData.cs >> CRUD  구현 
            //EmpData emp = new EmpData();
            //List<emp> emplist= emp.list();

            //3. 데이터 전달 (view) >> *.chtml (razor 문법)
            //3.1 ViewBag.emp = emplist
            //3.2  return View(emplist);

            //ViewBag.User = myuser;  

            //view.chtml > @ViewBag.User.UserNo
            //view.chtml > @ViewBag.User.UserName


            //View(myuser)
            //view.chtml > @Model.UserNo
            //view.chtml > @Model.UserName


            var myuser = new User();
            myuser.UserNo = 100;
            myuser.UserName = "김유신";


            return View(myuser);
        }

    }
}