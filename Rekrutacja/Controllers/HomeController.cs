using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rekrutacja.Models.Home;
using Rekrutacja.Services;
namespace Rekrutacja.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UrlLogic urlLogic = new UrlLogic();
            IndexModel model = urlLogic.GetIndexModel();
            return View(model);
        }
    }
}