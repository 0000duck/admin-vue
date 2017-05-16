using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_iview.UI.Areas.TestA.Controllers
{
    public class HomeController : Controller
    {
        // GET: TestA/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}