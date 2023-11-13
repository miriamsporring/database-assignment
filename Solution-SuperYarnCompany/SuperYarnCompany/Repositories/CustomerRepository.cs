using SuperYarnCompany.Context;
using SuperYarnCompany.Entities;

namespace SuperYarnCompany.Repositories;

internal class CustomerRepository : Repo<CustomerEntity>
{
    private readonly DataContext _context;
    public CustomerRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}



