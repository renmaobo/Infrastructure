using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Infrastructure.ShortLineService.WebApi.Controllers
{
    /// <summary>
    /// 短链控制器
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ShortLinkController : ControllerBase
    {
        /// <summary>
        /// 生成短链
        /// </summary>
        /// <param name="id">配置编号</param>
        /// <returns></returns>
        [HttpPost("generate")]
        public ResponseResult Generate([FromBody] object config)
        {
            return new ResponseResult();
        }
    }
}

