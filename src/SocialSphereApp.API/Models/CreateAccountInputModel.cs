using SocialSphereApp.API.Enums;

namespace SocialSphereApp.API.Models;

public class CreateAccountInputModel
{
    public string FullName { get; set; }
    public string Password { get; set; }
    public string Mail { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Phone { get; set; }
    public Gender Gender { get; set; }
    public string? Pronun { get; set; }
    public string? CustomGender { get; set; }
}
