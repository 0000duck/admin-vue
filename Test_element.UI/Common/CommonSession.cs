using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_element.UI.Common
{
    /// <summary>
    /// 公共会话处理
    /// </summary>
    public class CommonSession
    {

        /// <summary>
        /// 会话状态序列化
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string SessionSatae_Serialize(object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        /// <summary>
        /// 会话状态反序列化
        /// </summary>
        /// <param name="type"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static object SessionSatae_Deserialize(Type type, string json)
        {
            return JsonConvert.DeserializeObject(json, type);
        }

    }
}