using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBag_ViewData.Controllers
{
    public class TempDataController : Controller
    {
        // GET: TempData
        public ActionResult Index1()
        {
            TempData["MyKey"] = " Data From Index 1";
            return View();
        }

        public ActionResult Index2()
        {
            ViewBag.Data = TempData.Peek("MyKey");
            TempData.Keep("MyKey"); // TempData.Keep()
            return View();
        }

        public ActionResult Index3()
        {
            ViewBag.Data = TempData.Peek("MyKey");
            return View();
        }
    }
}