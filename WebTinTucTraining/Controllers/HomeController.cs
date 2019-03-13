using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTinTucTraining.Models;

namespace WebTinTucTraining.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Xin chào các bạn";
            var model = new HelloModel();
            ViewData["Xinchao"] = "Xin chào :v";
            model.FirstName = "Thế";
            model.LastName = "Nguyễn";
            return View(model);
        }
    }
}
