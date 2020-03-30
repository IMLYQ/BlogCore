using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    /// <summary>
    /// 文章设置标签表
    /// </summary>
    public class BK_Artitle_Label
    {
        /// <summary>
        /// ID 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 文章ID
        /// </summary>
        public int Article_id { get; set; }
        /// <summary>
        /// 标签ID
        /// </summary>
        public int Label_id { get; set; }
    }
}
