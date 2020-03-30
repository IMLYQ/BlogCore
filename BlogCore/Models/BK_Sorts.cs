using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    /// <summary>
    /// 分类表
    /// </summary>
    public class BK_Sorts
    {
        /// <summary>
        /// 分类ID
        /// </summary>
        public int Sort_Id { get; set; }
        /// <summary>
        /// 分类名称
        /// </summary>
        public string Sort_Name { get; set; }
        /// <summary>
        /// 分类别名
        /// </summary>
        public string Sort_Alias { get; set; }
        /// <summary>
        /// 分类描述
        /// </summary>
        public string Sort_Description { get; set; }
        /// <summary>
        /// 父分类ID
        /// </summary>
        public int Parent_Sort_id { get; set; }
    }
}
