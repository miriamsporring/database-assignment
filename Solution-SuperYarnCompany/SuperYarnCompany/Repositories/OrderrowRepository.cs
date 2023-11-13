using SuperYarnCompany.Context;
using SuperYarnCompany.Entities;

namespace SuperYarnCompany.Repositories;

internal class OrderrowRepository : Repo<OrderrowEntity>
{
    private readonly DataContext _context;
    public OrderrowRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
