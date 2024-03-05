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
            return Ok(new {message="BONJOUR AHAHAHAAHA"});
        }
    }
}
//U047PTERJ1U54VO1$
//asp-net-database