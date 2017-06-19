using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test_element.UI.Areas.TestA.Controllers
{
    /// <summary>
    /// 用户管理
    /// </summary>
    public class SysUserController : Controller
    {
        // GET: TestA/SysUser
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult List() { return null; }
        public JsonResult Add() { return null; }
        public JsonResult Edit() { return null; }
        public JsonResult Remove() { return null; }

        /// <summary>
        /// 分配角色
        /// </summary>
        /// <returns></returns>
        public JsonResult AssignRoles() { return null; }


    }
}