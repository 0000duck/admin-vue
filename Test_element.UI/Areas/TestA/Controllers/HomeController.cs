using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_element.UI.Filters;

namespace Test_element.UI.Areas.TestA.Controllers
{
    [RoleActionFilter]
    public class HomeController : Controller
    {
        // GET: TestA/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}