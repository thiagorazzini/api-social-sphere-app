using SocialSphereApp.API.ValueObjects;

namespace SocialSphereApp.API.Models;

public class UpdateProfileInputModel
{
    public string? DisplayName { get; private set; }
    public string? About { get; private set; }
    public int? ProfileId { get; private set; }
    public byte[]? Picture { get; private set; }
    public string? Job { get; private set; }
    public AddressInputModel? Address { get; set; }
}

public class AddressInputModel
{
    public string? Street { get; set; }
    public string? Number { get; set; }
    public string? ZipCode { get; set; }
    public string? District { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
}