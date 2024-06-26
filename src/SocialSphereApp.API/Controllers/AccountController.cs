using Microsoft.AspNetCore.Mvc;
using SocialSphereApp.API.Entities;
using SocialSphereApp.API.Models;
using SocialSphereApp.API.Persistence;

namespace SocialSphereApp.API.Controllers
{
    [Route("api/v1/accounts")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly SocialSphereAppDbContext _context;
        public AccountController(SocialSphereAppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// GET api/v1/accounts/1234 
        /// Get  account per Id
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetAccountById(int id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);

            if (user is null)
            {
                return NotFound();
            }

            return Ok(user);
        }


        // POST api/v1/register
        [HttpPost("create-account")]
        public IActionResult RegisterNewAccount(CreateAccountInputModel model)
        {
            var profile = new Profile(
                model.FullName,
                model.Gender,
                model.Pronun,
                model.CustomGender);

            var user = new User(
                model.FullName,
                model.Password,
                model.Mail,
                model.DateOfBirth,
                model.Phone,
                model.Gender,
                model.Pronun,
                model.CustomGender,
                profile);

            _context.Users.Add(user);

            return CreatedAtAction(nameof(GetAccountById), new { id = 1 }, model);
        }

        /// <summary>
        /// Update password
        /// </summary>
        [HttpPut("{id}/change-password")]
        public IActionResult ChangePassword(int id, ChangePasswordInputModel model)
        {
            if (id <= 0)
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

        /// <summary>
        /// Login into system
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public IActionResult Login(LoginInputModel model)
        {
            return Ok();
        }
    }
}
