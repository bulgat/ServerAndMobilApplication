using Microsoft.AspNetCore.Mvc;

namespace ServerAndMobil.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        [HttpGet(Name = "GetVersion")]
        public string GetVersion()
        {
            return "1.0.0";
        }
    }
}
