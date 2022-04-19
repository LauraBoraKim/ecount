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

        public ActionResult UserData() {

            var myuser = new User();
            myuser.UserNo = 100;
            myuser.UserName = "김유신";

            //ViewBag.User = myuser;  

            //view.chtml > @ViewBag.User.UserNo
            //view.chtml > @ViewBag.User.UserName


            //View(myuser)
            //view.chtml > @Model.UserNo
            //view.chtml > @Model.UserName

            return View(myuser);
        }

    }
}