using Loteria.Server.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Loteria.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        private readonly ICode _code;

        public CodeController(ICode code)
        {
            _code = code;
        }

        [HttpPost]
        public async Task<IActionResult> GetCode(int longest, int HowMany)
        {
            _code.GetCode(longest, HowMany);
            return Ok();
        }
    }
}
