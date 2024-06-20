namespace SocialSphereApp.API.Models
{
    public class UpdateAccountInputModel
    {
        public string FullName { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
    }
}
