using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AddNumber.Models;

namespace AddNumber.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            AddModel model = new AddModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Add(AddModel model)
        {
            decimal Sum = model.FirstNumber + model.SecondNumber;
            model.Sum = Sum;
            return View("Index", model);
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