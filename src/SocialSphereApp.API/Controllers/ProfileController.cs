using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialSphereApp.API.Models;
using SocialSphereApp.API.Persistence;
using SocialSphereApp.API.ValueObjects;

namespace SocialSphereApp.API.Controllers;

[Route("api/v1/profiles")]
[ApiController]
public class ProfileController : ControllerBase
{
    private readonly SocialSphereAppDbContext _context;

    public ProfileController(SocialSphereAppDbContext context)
    {
        _context = context;
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProfile(Guid id,UpdateProfileInputModel model)
    {
        var profile = _context.Profiles.SingleOrDefault(u => u.Id == id);
        
        if (profile is null)
        {
            return NotFound();
        }

        var address = new Address(
            model.Address.Street,
            model.Address.Number,
            model.Address.ZipCode,
            model.Address.District,
            model.Address.City,
            model.Address.State,
            model.Address.Country
            );

        profile.UpdateProfile(
            model.DisplayName,
            model.About,
            model.Picture,
            address,
            model.Job);

        _context.Update(profile);
        _context.SaveChanges();
        
        return NoContent();
    }

    [HttpGet("{id}")]
    public IActionResult GetProfileById(Guid id)
    {
        var profile = _context.Profiles.SingleOrDefault(u => u.Id == id);

        if(profile is null)
        {
            return NotFound();
        }

        return Ok(profile);
    }
}
