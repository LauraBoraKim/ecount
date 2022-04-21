using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WEBAPICRUD.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
/*
URI                          Method      처리 
/api/products                  GET        모든 제품의 목록을 조회  
/api/products/id               GET        id를 기준으로 한제품을 조회
/api/products?category=        GET        카테고리를 기준으로 한 제품을 조회
/api/products                  POST       새로운 제품을 생산합니다 (new , insert)
/api/products/id               PUT        제품을 갱신합니다(수정) (update where id)
/api/products/id               DELETE     제품을 삭제합니다 
 */ 