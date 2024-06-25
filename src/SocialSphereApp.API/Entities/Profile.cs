using SocialSphereApp.API.ValueObjects;

namespace SocialSphereApp.API.Entities;

public class Profile
{
    public string DisplayName { get; private set; }
    public string About { get; private set; }
    public int ProfileId { get; private set; }
    public byte[] Picture { get; private set; }
    public Address Address { get; private set; }
    public string Job { get; private set; }
}
