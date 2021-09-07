using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string hoten, string MaSV)
        {
            ViewBag.thongtin = hoten + "-" + MaSV;
            return View();
        }
    }
}