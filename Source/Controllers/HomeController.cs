using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Source.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }
        public JsonResult GetData()
        {
            return Json(new List<Product> { new Product { ProductID = "1", ProductName = "Product1" }, new Product { ProductID = "2", ProductName = "Product2" }, new Product { ProductID = "3", ProductName = "Product3" }, new Product { ProductID = "4", ProductName = "Product4" } }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetDatas()
        {
            return Json(new List<Product> { new Product { ProductID = "1", ProductName = "Product1" }, new Product { ProductID = "2", ProductName = "Product2" }, new Product { ProductID = "3", ProductName = "Product3" }, new Product { ProductID = "4", ProductName = "Product4" } }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Components()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
    public class Product
    {
        public string ProductID { set; get; }
        public string ProductName { set; get; }
    }
}
