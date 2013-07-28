using ActionService;
using ActionService.ViewModel;
using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerceDemoz.Controllers
{
    public class HomeController : Controller
    {
        private IServiceAccess _service = new ServiceAccess();
        public ActionResult Index()
        {
            ProductResponse _Products = _service.DisplayProducts();

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
