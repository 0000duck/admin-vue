using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Test_element.UI.Areas.TestA.Models;
using Test_element.UI.Common;
using Test_element.UI.Entities;
using Test_element.UI.Filters;
using Test_element.UI.Models;

namespace Test_element.UI.Areas.TestA.Controllers
{
    [Description(No = 1, Name = "客户")]
    [RoleActionFilter]
    public class CustomerController : Controller
    {

        AdminVueModel db = new AdminVueModel();

        // GET: TestA/Customer

        [Description(No = 1, Name = "客户首页")]
        public ActionResult Index()
        {
            return View();
        }


        [Description(No = 1, Name = "客户列表")]
        public JsonResult List(CustomerListModel model)
        {
            int rowSize = 20;
            AjaxResult ajaxResult = null;


            var total = db.Customers.Count();
            var customers = db.Customers.OrderBy(p => p.Name).Skip(model.page * rowSize).Take(rowSize).Select(p => new
            {
                Id = p.Id,
                Address = p.Address,
                Name = p.Name,
                Age = p.Birthday == null ? -1 : (DateTime.Now.Year - p.Birthday.Value.Year),
                Date = p.Birthday
            }).ToList();

            ajaxResult = new AjaxResult()
            {
                Success = true,
                Msg = "加载数据成功",
                Body = new
                {
                    Total = total,
                    Customers = customers
                }
            };

            return new JsonResult() { ContentEncoding = Encoding.UTF8, Data = CommonJson.camelJson(ajaxResult), JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }


        [Description(No = 1, Name = "客户新增")]
        public JsonResult Add()
        {
            AjaxResult ajaxResult = null;

            return new JsonResult() { ContentEncoding = Encoding.UTF8, Data = CommonJson.camelJson(ajaxResult) };
        }


        [Description(No = 1, Name = "客户编辑")]
        public JsonResult Edit()
        {
            AjaxResult ajaxResult = null;

            return new JsonResult() { ContentEncoding = Encoding.UTF8, Data = CommonJson.camelJson(ajaxResult) };
        }

        [Description(No = 1, Name = "客户删除")]
        public JsonResult Remove()
        {
            AjaxResult ajaxResult = null;

            return new JsonResult() { ContentEncoding = Encoding.UTF8, Data = CommonJson.camelJson(ajaxResult) };
        }

    }
}