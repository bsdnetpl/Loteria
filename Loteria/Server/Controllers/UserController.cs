using Loteria.Server.Service;
using Loteria.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Loteria.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ICode _code;
        private readonly IUser _user;

        public UserController(ICode code, IUser user = null)
        {
            _code = code;
            _user = user;
        }

        [HttpPost]
        public async Task<ActionResult<Shared.User>>AddUser(UserDTO userDTO)
        {
            if (userDTO == null) 
            {
                return BadRequest("No data add");
            }
          var isnull =  _code.FindCode(userDTO.Code);
            
            if(isnull == null)
            {
                return BadRequest("No data add");
            }
            _code.DeleteCode(userDTO.Code);
            _user.AddUser(userDTO);
            return Ok(userDTO);

        }
    }
}
