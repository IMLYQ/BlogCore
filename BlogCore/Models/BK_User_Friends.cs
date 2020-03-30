using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    /// <summary>
    /// 用户好友表
    /// </summary>
    public class BK_User_Friends
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int User_Id { get; set; }
        /// <summary>
        /// 好友ID
        /// </summary>
        public int User_Friends_Id { get; set; }
        /// <summary>
        /// 好友备注
        /// </summary>
        public string User_note { get; set; }
        /// <summary>
        /// 好友状态
        /// </summary>
        public int User_status { get; set; }
    }
}
