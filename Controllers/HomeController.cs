using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewBag_ViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.CompanyName = "Financial Technologies Ltd";
            ViewBag.EmpList = new List<string> { "Ram","Sham","Raju" };

            ViewData["CityName"] = "Panvel";
            ViewData["CityList"] = new List<string> { "Rabale", "Airoli", "Thane" };
            
            return View();
        }
    }
}