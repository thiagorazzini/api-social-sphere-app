using SocialSphereApp.API.Enums;
using SocialSphereApp.API.ValueObjects;
using System.Reflection;

namespace SocialSphereApp.API.Entities;

public class Profile : BaseEntity
{
    public Profile()
    { }
    public Profile(string displayName, string about, int profileId, byte[] picture, Address address, string job, int userId)
        : base()
    {
        DisplayName = displayName;
        About = about;
        ProfileId = profileId;
        Picture = picture;
        Address = address;
        Job = job;
    }

    public Profile(string displayName, Gender gender, string?  pronun, string? customGender, Guid userId)
        : base()
    {
        DisplayName= displayName;
        Gender  = gender;
        Pronun = pronun;
        CustomGender = customGender;
        UserId = userId;
    }

    public Profile(Gender gender, string? pronun, string? customGender)
    {
        Gender = gender;
        Pronun = pronun;
        CustomGender = customGender;
    }

    public string DisplayName { get; private set; }
    public string? About { get; private set; }
    public int ProfileId { get; private set; }
    public byte[]? Picture { get; private set; }
    public Address Address { get; private set; }
    public string? Job { get; private set; }
    public Gender Gender { get; private set; }
    public string? Pronun { get; private set; }
    public string? CustomGender { get; private set; }
    public Guid UserId { get; private set; }
    public User User { get; private set; }

    public void UpdateProfile(
      string? displayName = null,
      string? about = null,
      byte[]? picture = null,
      Address? address = null,
      string? job = null,
      Gender? gender = null,
      string? pronun = null,
      string? customGender = null)
    {
        if (displayName != null)
        {
            DisplayName = displayName;
        }

        if (about != null)
        {
            About = about;
        }

        if (picture != null)
        {
            Picture = picture;
        }

        if (address != null)
        {
            Address = address;
        }

        if (job != null)
        {
            Job = job;
        }

        if (gender.HasValue)
        {
            Gender = gender.Value;
        }

        if (pronun != null)
        {
            Pronun = pronun;
        }

        if (customGender != null)
        {
            CustomGender = customGender;
        }
    }
}
