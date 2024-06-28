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
        [HttpGet("{id}")]
        public IActionResult GetAccountById(Guid id)
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

            var user = new User(
                 model.FullName,
                 model.Password,
                 model.Mail,
                 model.DateOfBirth,
                 model.Phone,
                 model.Gender,
                 model.Pronun,
                 model.CustomGender);

            _context.Users.Add(user);
            _context.Profiles.Add(user.Profile);

            _context.SaveChanges();

            return CreatedAtAction(nameof(GetAccountById), new { id = user.Id }, model);
        }

        /// <summary>
        /// Update password
        /// </summary>
        [HttpPut("{id}/update-password")]
        public IActionResult UpdatePassword(Guid id, ChangePasswordInputModel model)
        {
            var user =  _context.Users.SingleOrDefault(u => u.Id == id);

            if (user is null)
            {
                return NotFound();
            }

            user.UpdatePassword(
                model.CurrentPassword,
                model.NewPassword);

            _context.Users.Update(user);
            _context.SaveChanges();

            return NoContent();
        }

        /// <summary>
        /// Update Account information
        /// </summary>
        [HttpPut("{id}/update-account")]
        public IActionResult UpdateAccount(Guid id, UpdateAccountInputModel model)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);

            if (user is null)
            {
                return NotFound();
            }

            user.UpdateAccount(
                model.FullName,
                model.Mail,
                model.DateOfBirth,
                model.Phone,
                model.Gender,
                model.Pronun,
                model.CustomGender);


            _context.Users.Update(user);
            _context.SaveChanges();

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
