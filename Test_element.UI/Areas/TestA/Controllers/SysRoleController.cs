using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_element.UI.Areas.TestA.Controllers
{
    /// <summary>
    /// 角色管理
    /// </summary>
    public class SysRoleController : Controller
    {
        // GET: TestA/SysRole
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List() { return null; }
        public JsonResult Add() { return null; }
        public JsonResult Edit() { return null; }
        public JsonResult Remove() { return null; }

        /// <summary>
        /// 分配权限
        /// </summary>
        /// <returns></returns>
        public JsonResult AssignPermissions() { return null; }

    }
}