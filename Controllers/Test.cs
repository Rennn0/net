using Microsoft.AspNetCore.Mvc;

namespace net.Controllers
{
    [Route("api/[Controller]")]
    public class TestController : ControllerBase
    {
        public TestController() { }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new {message="BONJOUR"});
        }
    }
}
