using SocialSphereApp.API.Enums;
namespace SocialSphereApp.API.Models
{
    public class UpdateAccountInputModel
    {
        public string FullName { get; set; } = string.Empty!;
        public string Mail { get; set; } = string.Empty!;
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; } = string.Empty!;
        public Gender Gender { get; private set; }
        public string? Pronun { get; private set; } = null;
        public string? CustomGender { get; private set; } = null;
    }
}
