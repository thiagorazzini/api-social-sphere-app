﻿using SocialSphereApp.API.ValueObjects;

namespace SocialSphereApp.API.Models;

public class UpdateProfileInputModel
{
    public string? DisplayName { get;  set; }
    public string? About { get; set; }
    public byte[]? Picture { get; set; }
    public string? Job { get; set; }
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