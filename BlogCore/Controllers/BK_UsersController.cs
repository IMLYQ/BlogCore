using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogCore.BLL;
using BlogCore.Common;
using BlogCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BK_UsersController : ControllerBase
    {

        BK_UsersBLL bll = new BK_UsersBLL();
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("Insert")]
        [HttpPost]
        public bool Insert(BK_Users model)
        {
            return bll.Insert(model);
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("Update")]
        [HttpPost]
        public bool Update(BK_Users model)
        {
            return bll.Update(model);
        }



        /// <summary>
        /// 获取所有用户
        /// </summary> 
        /// <returns></returns>
        [Route("GetUsers")]
        [HttpGet]
        public string GetUsers()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(bll.GetUsers());
        }

        /// <summary>
        /// 通过用户ID获取用户数据
        /// </summary>
        /// <param name="id">用户ID</param>
        /// <returns></returns>
        [Route("GetUserByID")]
        [HttpGet]
        public string GetUserByID(string id)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(bll.GetUserByID(DataParser.ParseDecimal(id)));
        }
    }
}