using Newtonsoft.Json;
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
            if (!ModelState.IsValid)
            {

            }

            AjaxResult ajaxResult = null;

            var user = db.Users.SingleOrDefault(p => p.Account == model.Account && p.Password == model.Password);

            if (user != null)
            {
                SaveSession(user);
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
        
        
        [HttpGet]
        public ActionResult LogOff()
        {
            Session.Clear();
            return RedirectToAction("Login", "Account");
        }


        public ActionResult UpdatePassword()
        {
            return View();
        }


        /// <summary>
        /// 保存会话
        /// </summary>
        /// <param name="user"></param>
        private void SaveSession(User user)
        {
            var userSession = new AccountSessionModel()
            {
                UserId = user.Id,
                Account = user.Account,
                NickName = user.NickName
            };
            
            var userMenus = db.vUserMenus.Where(p => p.UserId == user.Id).Select(pm => new MenuModel()
            {
                MenuId = pm.Id,
                MenuName = pm.Name,
                MenuUrl = pm.Href.ToLower(),
                ParentId = pm.ParentId,
                MenuCss = pm.IconInfo,
                Order = pm.OrderId

            }).ToList();

            var userPermissions = db.vUserPermissions.Where(p => p.UserId == user.Id).Select(p => new PermissionModel()
            {
                Name = p.Name,
                Url = p.Href.ToLower()

            }).ToList();

            try
            {
                userSession.MenuList = userMenus;
                userSession.PermissionDic = userPermissions.ToDictionary(k => k.Url, v => v.Name);
                
                Session[ConstantParam.SESSION_USER] = CommonSession.SessionSatae_Serialize(userSession);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}