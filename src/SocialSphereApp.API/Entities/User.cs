namespace SocialSphereApp.API.Entities;

public class User : BaseEntity
{
    public User(string fullName, string password, string mail, DateTime dateOfBirth, string phone)
        :base()
    {
        FullName = fullName;
        Password = password;
        Mail = mail;
        DateOfBirth = dateOfBirth;
        Phone = phone;
    }

    public string FullName { get; private set; }
    public string Password { get; private set; }
    public string Mail { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public string Phone { get; private set; }
}
