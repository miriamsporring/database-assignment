using SuperYarnCompany.Context;
using SuperYarnCompany.Entities;

namespace SuperYarnCompany.Repositories;

internal class ProductRepository : Repo<ProductEntity>
{
    private readonly DataContext _context;
    public ProductRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
