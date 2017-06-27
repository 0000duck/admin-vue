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
    /// <summary>
    /// 用户管理
    /// </summary>
    public class SysUserController : Controller
    {

        AdminVueModel db = new AdminVueModel();

        // GET: TestA/SysUser
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List(UserListModel model)
        {//动态排序属性名要大小全字匹配，eg:"NickName"

            int page = model.page;
            int rowSize = model.rowSize;
            bool sortWay_order = model.sortWay_order;
            string sortWay_prop = model.sortWay_prop.Substring(0, 1).ToUpper() + model.sortWay_prop.Substring(1);

            AjaxResult ajaxResult = null;

            var total = db.Users.Count();
            var users = CommonLinq.Sort(db.Users.Where(p => true), sortWay_prop, sortWay_order)
                .Skip(page * rowSize).Take(rowSize)
                .Select(p => new
                {
                    Id = p.Id,
                    Account = p.Account,
                    NickName = p.NickName,
                    Password = p.Password,
                    Avatar = p.Avatar,
                    CreateTime = p.CreateTime
                }).ToList();

            ajaxResult = new AjaxResult()
            {
                Success = true,
                Msg = "加载数据成功",
                Body = new
                {
                    Total = total,
                    Users = users
                }
            };

            return new JsonResult() { ContentEncoding = Encoding.UTF8, Data = CommonJson.camelJson(ajaxResult), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

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