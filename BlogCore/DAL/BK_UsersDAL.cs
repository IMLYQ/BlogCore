using BlogCore.Common;
using BlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.DAL
{
    /// <summary>
    /// 用户访问数据层
    /// </summary>
    public class BK_UsersDAL : SqlSugarDbContext
    {
        /// <summary>
        /// Defines the Sugar
        /// </summary>
        internal SqlSugarHelper Sugar = new SqlSugarHelper();

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="model">用户实体</param>
        /// <returns></returns> 
        public int Insert(BK_Users model)
        {
            var s = 0;
            model.User_id = null;
            //启用事务
            var result = Sugar.db.Ado.UseTran(() =>
            {
                //执行不插入User_id列（数据库ID自增长）
                UserDB.AsInsertable(model).IgnoreColumns(it => it == "User_id").ExecuteReturnIdentity();
            });
            if (result.IsSuccess)
            {
                s = 1;
            }
            else
            {
                Console.WriteLine(result.ErrorMessage);
            }
            return s;
        }

        /// <summary>
        /// 通过ID删除
        /// </summary>
        /// <param name="ID">用户ID</param>
        /// <returns></returns>
        public bool DeleteById(int ID)
        {
            return UserDB.DeleteById(ID);
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Obsolete]
        public bool Update(BK_Users model)
        {
            bool result = false;
            var s = Sugar.db.Ado.UseTran(() =>
            {
                //更新用户信息，用户自增列不修改
                UserDB.AsUpdateable(model).Where(it=>it.User_id==model.User_id).IgnoreColumns(it => it == "User_id").ExecuteCommand();

            });

            if (s.IsSuccess)
            {
                result = true;
            }
            else
            {
                Console.WriteLine(s.ErrorMessage);
            }

            return result;
        }

        public List<BK_Users> GetUsers()
        {
            return UserDB.GetList();
        }

    }
}
