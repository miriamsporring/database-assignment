using SuperYarnCompany.Context;
using SuperYarnCompany.Entities;

namespace SuperYarnCompany.Repositories;

internal class AddressRepository : Repo<AddressEntity>
{
    private readonly DataContext _context;
    public AddressRepository(DataContext context)  : base(context)
        {
            _context = context;
        }
}
