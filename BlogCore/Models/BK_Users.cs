using SqlSugar;
using System;

namespace BlogCore.Models
{
    /// <summary>
    /// 用户信息表
    /// </summary>
    public class BK_Users
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int? User_id { get; set; }
        /// <summary>
        /// 用户IP
        /// </summary>
        public string User_ip { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string User_name { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string User_password { get; set; }
        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string User_email { get; set; }
        /// <summary>
        /// 用户头像
        /// </summary>
        public string User_profile_photo { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime User_registration_time { get; set; }
        /// <summary>
        /// 用户生日
        /// </summary>
        public DateTime User_birthday { get; set; }
        /// <summary>
        /// 用户年龄
        /// </summary>
        public int User_age { get; set; }
        /// <summary>
        /// 用户手机号
        /// </summary>
        public string User_telephone_number { get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        public string User_nickname { get; set; }
    }
}
