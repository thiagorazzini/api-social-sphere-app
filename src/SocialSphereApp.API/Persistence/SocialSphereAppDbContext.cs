using SocialSphereApp.API.Entities;

namespace SocialSphereApp.API.Persistence;

public class SocialSphereAppDbContext
{
    public SocialSphereAppDbContext()
    {
        Users = [];
        Profiles = [];
    }
    public List<User> Users { get; set; }
    public List<Profile> Profiles { get; set; }
}
