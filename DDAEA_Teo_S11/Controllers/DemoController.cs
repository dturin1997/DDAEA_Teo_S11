using DDAEA_Teo_S11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDAEA_Teo_S11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet("GetDemoModel")]
        public IEnumerable<DemoModel> Get()
        {

            List<DemoModel> demos = new List<DemoModel>();

            demos.Add(new DemoModel { Id = 1, Name = "Test1" });
            demos.Add(new DemoModel { Id = 2, Name = "Test2" });
            demos.Add(new DemoModel { Id = 3, Name = "Test3" });
            demos.Add(new DemoModel { Id = 4, Name = "Test4" });


            return demos;
        }
    }
}
