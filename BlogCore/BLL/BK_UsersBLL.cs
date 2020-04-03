using BlogCore.DAL;
using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.BLL
{
    /// <summary>
    /// BK_Users业务逻辑层
    /// </summary>
    public class BK_UsersBLL
    {
        BK_UsersDAL dal = new BK_UsersDAL();
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="model">用户实体</param>
        /// <returns></returns>
        public bool Insert(BK_Users model)
        {
            bool result = false;
            if (dal.Insert(model) > 0)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Obsolete]
        public bool Update(BK_Users model) 
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public List<BK_Users> GetUsers() 
        {
            return dal.GetUsers();
        }

        /// <summary>
        /// 通过用户ID查找用户
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <returns></returns>
        public BK_Users GetUserByID(decimal id) 
        {
            return dal.GetUserByID(id);
        }
    }
}
