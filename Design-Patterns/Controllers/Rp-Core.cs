using Microsoft.AspNetCore.Mvc;
using RPCoreLib;
using RPCoreLib.Security;

namespace Design_Patterns.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class Rp_Core : ControllerBase
    {
        [HttpGet]
        [Route("Decrypt")]
        public IActionResult Decrypt(string text) {
            return Ok(text.Decrypt());
        }


        [HttpGet]
        [Route("Encrypt")]
        public IActionResult Encrypt(string text)
        {
            return Ok(text.Encrypt());
        }
    }
}
