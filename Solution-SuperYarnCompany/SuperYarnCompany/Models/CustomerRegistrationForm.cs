﻿namespace SuperYarnCompany.Models;

internal class CustomerRegistrationForm
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string CustomerType { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string StreetName { get; set; } = null!;
    public string StreetNumber { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

}
