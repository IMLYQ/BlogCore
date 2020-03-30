using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    /// <summary>
    /// 博客文章评论表
    /// </summary>
    public class BK_Comments
    {
        /// <summary>
        /// 评论ID
        /// </summary>
        public int comment_id { get; set; }
        /// <summary>
        /// 发表用户ID
        /// </summary>
        public int user_id { get; set; }
        /// <summary>
        /// 评论博文ID
        /// </summary>
        public int article_id { get; set; }
        /// <summary>
        /// 点赞数
        /// </summary>
        public int comment_like_count { get; set; }
        /// <summary>
        /// 评论日期
        /// </summary>
        public DateTime comment_date { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string comment_content { get; set; }
        /// <summary>
        /// 父评论ID
        /// </summary>
        public int parent_comment_id { get; set; }
    }
}
