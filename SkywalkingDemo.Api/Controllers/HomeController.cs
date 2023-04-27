using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace SkywalkingDemo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        public HomeController()
        {
        }

        /// <summary>
        /// Check
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Check()
        {
            return Ok($"Success  --  {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
        }
    }
}
