using SocialSphereApp.API.Enums;
using SocialSphereApp.API.ValueObjects;

namespace SocialSphereApp.API.Entities;

public class Profile : BaseEntity
{
    public Profile(string displayName, string about, int profileId, byte[] picture, Address address, string job)
    {
        DisplayName = displayName;
        About = about;
        ProfileId = profileId;
        Picture = picture;
        Address = address;
        Job = job;
    }

    public Profile(string displayName, Gender gender, string  pronun, string customGender)
    {
        DisplayName= displayName;
        Gender  = gender;
        Pronun = pronun;
        CustomGender = customGender;
    }

    public string DisplayName { get; private set; }
    public string About { get; private set; }
    public int ProfileId { get; private set; }
    public byte[] Picture { get; private set; }
    public Address Address { get; private set; }
    public string Job { get; private set; }
    public Gender Gender { get; private set; }
    public string? Pronun { get; private set; }
    public string? CustomGender { get; private set; }
}
