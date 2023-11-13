using SuperYarnCompany.Context;

namespace SuperYarnCompany.Repositories;

internal class AddressEntity : Repo<AddressEntity>
{
    private readonly DataContext _context;
    public AddressEntity(DataContext context)  : base(context)
        {
            _context = context;
        }


}
