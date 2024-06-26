using SocialSphereApp.API.Enums;

namespace SocialSphereApp.API.Entities;

public class User : BaseEntity
{
    public User(string fullName, string password, string mail, DateTime dateOfBirth, string phone, Gender gender, string pronun, string customGender, Profile profile)
        :base()
    {
        FullName = fullName;
        Password = password;
        Mail = mail;
        DateOfBirth = dateOfBirth;
        Phone = phone;
        Gender = gender;
        Pronun = pronun;
        CustomGender = customGender;
        Profile = profile;
    }

    public string FullName { get; private set; }
    public string Password { get; private set; }
    public string Mail { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public string Phone { get; private set; }
    public Gender Gender { get; private set; }
    public string? Pronun { get; private set; }
    public string? CustomGender { get; private set; }
    public Profile Profile { get; private set; }
}
