using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test_element.UI.Areas.TestA.Models;

namespace Test_element.UI.Common
{
    public class CommonMenu
    {

        /// <summary>
        /// 获取当前用户菜单
        /// </summary>
        /// <returns></returns>
        public static List<MenuModel> GetMenuList()
        {
            var userSession = HttpContext.Current.Session[ConstantParam.SESSION_USER];

            if (userSession == null)
            {
                return null;
            }
            else
            {
                var accountSessionModel = (AccountSessionModel)CommonSession.SessionSatae_Deserialize(typeof(AccountSessionModel), userSession.ToString());
                return accountSessionModel.MenuList;
            }
        }

        /// <summary>
        /// 获取当前用户Session
        /// </summary>
        /// <returns></returns>
        public static AccountSessionModel GetUserSession()
        {
            var userSession = HttpContext.Current.Session[ConstantParam.SESSION_USER];

            if (userSession == null)
            {
                return null;
            }
            else
            {
                var accountSessionModel = (AccountSessionModel)CommonSession.SessionSatae_Deserialize(typeof(AccountSessionModel), userSession.ToString());
                return accountSessionModel;
            }
        }



    }
}