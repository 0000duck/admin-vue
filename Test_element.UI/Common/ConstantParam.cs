using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_element.UI.Common
{
    public sealed class ConstantParam
    {
        /// <summary>
        /// 初始密码
        /// </summary>
        public const string USER_PWD_DEFAULT = "123456";

        /// <summary>
        /// Session存在当前用户数据的Key
        /// </summary>
        public const string SESSION_USER = "CurrentUserData";
    }
}