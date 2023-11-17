using Microsoft.EntityFrameworkCore; 

namespace SuperYarnCompany.Entities;

internal class ProductEntity
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public required string Category { get; set; } = null!;

    private ProductEntity CategoryId { get; set; } = null!;

}