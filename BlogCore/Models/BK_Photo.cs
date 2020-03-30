using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    /// <summary>
    /// 博客照片
    /// </summary>
    public class BK_Photo
    {
        /// <summary>
        /// 照片Id
        /// </summary>
        public int photoid { get; set; }
        /// <summary>
        /// 照片地点
        /// </summary>
        public string place { get; set; }
        /// <summary>
        /// 照片标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 照片内容
        /// </summary>
        public string content { get; set; }
        /// <summary>
        /// 照片拍摄时间
        /// </summary>
        public DateTime cuttime { get; set; }
        /// <summary>
        /// 照片操作人
        /// </summary>
        public string operators { get; set; }
    }
}
