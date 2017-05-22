using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_element.UI.Models
{
    /// <summary>
    /// Ajax 结果
    /// </summary>
    public class AjaxResult
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// 消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public object Body { get; set; }
    }
}