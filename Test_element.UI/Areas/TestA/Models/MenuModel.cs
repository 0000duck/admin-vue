using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_element.UI.Areas.TestA.Models
{
    /// <summary>
    /// 菜单类
    /// </summary>
    public class MenuModel
    {
        /// <summary>
        /// 菜单ID
        /// </summary>
        public Guid MenuId { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }

        /// <summary>
        /// 菜单URL
        /// </summary>
        public string MenuUrl { get; set; }

        /// <summary>
        /// 父节点
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// 对应的样式信息
        /// </summary>
        public string MenuCss { get; set; }

        /// <summary>
        /// 菜单顺序
        /// </summary>
        public int? Order { get; set; }
    }
}