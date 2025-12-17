using Microsoft.AspNetCore.Mvc;

namespace ServerAndMobil.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet("GetVersion")]
        public string GetVersion()
        {
            return "890ljklj";
        }
        [HttpGet("GetStatus")]
        public string GetStatus()
        {
            return "34534564634ljklj";
        }
    }
}
