using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_element.UI.Areas.TestA.Models
{
    /// <summary>
    /// 用户查询参数
    /// </summary>
    public class UserListModel
    {
        /// <summary>
        /// 页数
        /// </summary>

        public int page { get; set; }

        /// <summary>
        /// 每页显示条目个数
        /// </summary>

        public int rowSize { get; set; }

        /// <summary>
        /// 账户
        /// </summary>
        public string account { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string nickName { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string avatar { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? startTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? endTime { get; set; }

        /// <summary>
        /// 排序列名
        /// </summary>
        public string sortWay_prop { get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        public bool sortWay_order { get; set; }
    }
}