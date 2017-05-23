using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_element.UI.Areas.TestA.Models
{
    public class CustomerListModel
    {
        /// <summary>
        /// 页数
        /// </summary>

        public int page { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime? startTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? endTime { get; set; }

        /// <summary>
        /// 排序方式
        /// </summary>
        public bool sortWay { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int? age { get; set; }
    }
}