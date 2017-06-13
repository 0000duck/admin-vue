using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_element.UI.Areas.TestA.Models
{
    /// <summary>
    /// 保存在Session中的当前用户数据模型
    /// </summary>
    public class AccountSessionModel
    {
        /// <summary>
        /// 构造方法，保存在Session中的当前用户数据模型
        /// </summary>
        public AccountSessionModel()
        {
            this.MenuList = new List<MenuModel>();
            this.PermissionDic = new Dictionary<string, string>();
        }
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 用户姓名或昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 所拥有的菜单列表
        /// </summary>
        public List<MenuModel> MenuList { get; set; }

        /// <summary>
        /// 拥有权限列表
        /// </summary>
        public Dictionary<string, string> PermissionDic { get; set; }
        
    }
}