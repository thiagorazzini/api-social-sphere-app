using Microsoft.AspNetCore.Mvc;
using SocialSphereApp.API.Models;

namespace SocialSphereApp.API.Controllers
{
    [Route("api/v1/accounts")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        // POST api/v1/register
        [HttpPost("create-account")]
        public IActionResult RegisterNewAccount(CreateAccountInputModel model)
        {
            return CreatedAtAction(nameof(GetAccountById), new { id = 1 }, model);
        }

        // GET api/v1/accounts/1234
        /// <summary>
        /// Pegar contas por id para construir o Meu pefil
        [HttpGet("{id}")]
        public IActionResult GetAccountById(Guid accountId)
        {
            return Ok(accountId);
        }

        /// <summary>
        /// Update password
        /// </summary>
        [HttpPut("{id}/change-password")]
        public IActionResult ChangePassword(int id, ChangePasswordInputModel model)
        {
            if(id <= 0)
            {
                return BadRequest("Invalid ID.");
            }

            return NoContent();
        }

        /// <summary>
        /// Update Account information
        /// </summary>
        [HttpPut("{id}/update-account")]
        public IActionResult UpdateAccount(int id, UpdateAccountInputModel model)
        {
            return NoContent();
        }

        [HttpPost("login")]
        public IActionResult Login(LoginInputModel model)
        {
            return Ok();
        }
    }
}
