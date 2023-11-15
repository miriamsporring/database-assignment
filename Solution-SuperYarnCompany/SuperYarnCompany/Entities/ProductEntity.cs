using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperYarnCompany.Entities;

internal class ProductEntity
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Quantity {  get; set; }

    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;

}
