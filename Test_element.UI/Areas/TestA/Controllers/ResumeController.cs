using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_element.UI.Areas.TestA.Controllers
{
    public class ResumeController : Controller
    {
        // GET: TestA/Resume
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult TestForm()
        {
            return View();
        }

        public ActionResult SetRole()
        {
            return View();
        }

    }
}