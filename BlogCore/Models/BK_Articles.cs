using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    /// <summary>
    /// 博客文章
    /// </summary>
    public class BK_Articles
    {
        /// <summary>
        /// 博文ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int Article_id { get; set; }
        /// <summary>
        /// 发表用户ID
        /// </summary>
        public int User_id { get; set; }
        /// <summary>
        /// 博文标题
        /// </summary>
        public string Article_title { get; set; }
        /// <summary>
        /// 博文内容
        /// </summary>
        public string Article_content { get; set; }
        /// <summary>
        /// 浏览量
        /// </summary>
        public string Article_views { get; set; }
        /// <summary>
        /// 评论总数
        /// </summary>
        public string Article_comment_count { get; set; }
        /// <summary>
        /// 发表时间
        /// </summary>
        public DateTime Article_date { get; set; }
    }
}
