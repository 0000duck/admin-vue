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
    public class CustomerController : Controller
    {

        AdminVueModel db = new AdminVueModel();

        // GET: TestA/Customer
        public ActionResult Index()
        {
            return View();
        }
        
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

        public JsonResult Add()
        {
            AjaxResult ajaxResult = null;

            return new JsonResult() { ContentEncoding = Encoding.UTF8, Data = CommonJson.camelJson(ajaxResult) };
        }

        public JsonResult Edit()
        {
            AjaxResult ajaxResult = null;

            return new JsonResult() { ContentEncoding = Encoding.UTF8, Data = CommonJson.camelJson(ajaxResult) };
        }

        public JsonResult Remove()
        {
            AjaxResult ajaxResult = null;

            return new JsonResult() { ContentEncoding = Encoding.UTF8, Data = CommonJson.camelJson(ajaxResult) };
        }

    }
}