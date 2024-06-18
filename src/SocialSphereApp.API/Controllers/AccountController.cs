using Microsoft.AspNetCore.Mvc;
using SocialSphereApp.API.Models;

namespace SocialSphereApp.API.Controllers
{
    [Route("api/v1/accounts")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // POST api/v1/register
        [HttpPost]
        public IActionResult RegisterNewAccount(CreateAccountInputModel model)
        {
            return CreatedAtAction(nameof(GetAccountById), new { id = 1 }, model);
        }

        // GET api/v1/accounts/1234
        [HttpGet("{id}")]
        public IActionResult GetAccountById(Guid accountId)
        {
            return Ok(accountId);
        }
    }
}
