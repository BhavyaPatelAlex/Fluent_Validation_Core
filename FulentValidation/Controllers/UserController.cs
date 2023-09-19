using Microsoft.AspNetCore.Mvc;

namespace FulentValidation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;
        public UserController(IUserManager userManager)
        {
            this._userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Get(string Name)
        {
            await _userManager.Manage(new User { Name = Name});
            return Ok(Name);
        }

        [HttpPost]
        public IActionResult Post([FromBody] User model)
        {
            return Ok();
        }

    }
}
