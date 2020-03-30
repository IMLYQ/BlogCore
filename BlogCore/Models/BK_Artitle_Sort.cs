using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    /// <summary>
    /// 文章分类表
    /// </summary>
    public class BK_Artitle_Sort
    {

        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 文章ID
        /// </summary>
        public int Article_id { get; set; }
        /// <summary>
        ///分类ID 
        /// </summary>
        public int Sort_id { get; set; }
    }
}
