using StartingOverAgain.Contexts;
using StartingOverAgain.Entities;

namespace StartingOverAgain.Repositories;

internal class AddressRepository : Repo<AddressEntity>
{
    public AddressRepository(DataContext context) : base(context)
    {
    }
}
