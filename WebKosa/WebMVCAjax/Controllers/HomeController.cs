using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using WebMVCAjax.Models; //DTO ,DAO
namespace WebMVCAjax.Controllers
{
    public class HomeController : Controller
    {

        //DAO 작업을 ....
        //Action 발생 ... 호출되면 그안에서  필요하다면 DAO 작업 ...
       
        EmployeeDB empDB = new EmployeeDB();

        //요청 (Action) >> List() , Add(Employee emp) , Update(Employee emp) , Delete(int ID)
        //비동기 형태로 처리

        //전체 목록보기
        public JsonResult List() {
            return Json(empDB.ListAll(),JsonRequestBehavior.AllowGet);
        }
        
        //조건조회
        public JsonResult GetbyID(int ID)
        {
            var Employee = empDB.ListAll().Find(x => x.EmployeeID.Equals(ID));  //별도의 함수가 DAO 존재하지 않아요
            return Json(Employee, JsonRequestBehavior.AllowGet);
        }

        //데이터 추가
        public JsonResult Add(Employee emp) {
            //new Employee {ename=aaa}
            return Json(empDB.Add(emp), JsonRequestBehavior.AllowGet); 
        }

        //데이터 수정
        public JsonResult Update(Employee emp)
        {
            return Json(empDB.Update(emp), JsonRequestBehavior.AllowGet);
        }

        //데이터 삭제
        public JsonResult Delete(int ID) {
            return Json(empDB.Delete(ID), JsonRequestBehavior.AllowGet);
        }




        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}