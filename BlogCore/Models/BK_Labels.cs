using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    /// <summary>
    /// 标签表
    /// </summary>
    public class BK_Labels
    {
        /// <summary>
        /// 标签ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 标签名称
        /// </summary>
        public string label_name { get; set; }
        /// <summary>
        /// 标签别名
        /// </summary>
        public string label_alias { get; set; }
        /// <summary>
        /// 标签描述
        /// </summary>
        public string label_description { get; set; }
    }
}
