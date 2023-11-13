﻿namespace SuperYarnCompany.Entities;

internal class AddressEntity
{
    public int Id { get; set; }
    public string StreetName { get; set; } = null!;
    public string StreetNumber { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

}
