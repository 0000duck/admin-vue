using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test_element.UI.Areas.TestA.Models;
using Test_element.UI.Common;

namespace Test_element.UI.Filters
{
    public class RoleActionFilter : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var userSession = filterContext.HttpContext.Session[ConstantParam.SESSION_USER];

            if (userSession == null)
            {
                filterContext.Result = new RedirectResult("~/testA/Account/LogOff");
            }
            else
            {
                var accountSessionModel = (AccountSessionModel)CommonSession.SessionSatae_Deserialize(typeof(AccountSessionModel), userSession.ToString());

                //获取请求地址
                string controller = filterContext.RouteData.Values["controller"].ToString();
                string action = filterContext.RouteData.Values["action"].ToString();
                string reqUrl = "/" + controller + "/" + action;

                //如果当前用户未拥有该权限
                if (!accountSessionModel.PermissionDic.ContainsKey(reqUrl.ToLower()))
                {
                    filterContext.Result = new RedirectResult("~/testA/Account/LogOff");
                }
            }

            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

            base.OnActionExecuted(filterContext);
        }


    }
}