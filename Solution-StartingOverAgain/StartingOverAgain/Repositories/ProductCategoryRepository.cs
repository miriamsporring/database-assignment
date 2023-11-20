using StartingOverAgain.Contexts;
using StartingOverAgain.Entities;

namespace StartingOverAgain.Repositories;

internal class ProductCategoryRepository : Repo<ProductCategoryEntity>
{
    public ProductCategoryRepository(DataContext context) : base(context)
    {
    }
}
