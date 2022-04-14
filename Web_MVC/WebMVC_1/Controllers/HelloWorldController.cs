using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC_1.Controllers
{
    public class HelloWorldController : Controller
    {


        //GET: HelloWorld
        public string Index()
        {
            return "<b>my site create .....</b>";
        }

        //GET: localhost:97494/HelloWorld/welcome/

        /*
        public string welcome(string name , int age=20) {
            //return "action method return string";
            return HttpUtility.HtmlEncode("Hello " + name + " age : " + age);
        }
        */

        //http://localhost:52740/HelloWorld/welcome/100?name=kglim

        //http://localhost:52740/HelloWorld/welcome/king/100
        public string welcome(string name, int ID = 1)
        {
            //return "action method return string";
            return HttpUtility.HtmlEncode("Hello " + name + " ID : " + ID);
        }
    }
}