using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Test_element.UI.Areas.TestA.Models;
using Test_element.UI.Common;
using Test_element.UI.Entities;
using Test_element.UI.Models;

namespace Test_element.UI.Areas.TestA.Controllers
{
    public class AccountController : Controller
    {
        AdminVueModel db = new AdminVueModel();



        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(AccountLoginModel model)
        {
            AjaxResult ajaxResult = null;

            var user = db.Users.SingleOrDefault(p => p.Account == model.Account && p.Password == model.Password);

            if (user != null)
            {
                ajaxResult = new AjaxResult()
                {
                    Success = true,
                    Msg = "用户登录成功",
                    Body = new
                    {
                        Id = user.Id,
                        Account = user.Account,
                        NickName = user.NickName,
                        Avatar = user.Avatar,
                    }
                };
            }
            else
            {
                ajaxResult = new AjaxResult()
                {
                    Success = false,
                    Msg = "用户名或密码错误",
                    Body = null
                };
            }

            return new JsonResult() { ContentEncoding = Encoding.UTF8, Data = CommonJson.camelJson(ajaxResult) };
        }


        public ActionResult UpdatePassword()
        {
            return View();
        }
    }
}