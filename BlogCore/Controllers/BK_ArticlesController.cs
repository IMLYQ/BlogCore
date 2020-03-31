using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogCore.Controllers
{ 


    [Route("api/[controller]")]
    [ApiController]
    public class BK_ArticlesController : ControllerBase
    {

        /// <summary>
        /// 这是一种查询
        /// </summary>
        /// <returns></returns>
       [HttpGet]
        public BK_Articles query()
        {
            BK_Articles bK_Articles = new BK_Articles { User_id = 1, Article_comment_count = "0", Article_content = "zzzz" };
            return bK_Articles;
        }

        [Route("Getby")]
        [HttpGet]
        public BK_Articles GetbyThis()
        {
            BK_Articles bK_Articles = new BK_Articles { User_id = 2, Article_comment_count = "111", Article_content = "时间" };  
            return bK_Articles;
        }
         
    }
}