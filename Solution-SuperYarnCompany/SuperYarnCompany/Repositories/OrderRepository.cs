using SuperYarnCompany.Context;
using SuperYarnCompany.Entities;

namespace SuperYarnCompany.Repositories;

internal class OrderRepository : Repo<OrderEntity>
{
    private readonly DataContext _context;
    public OrderRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
