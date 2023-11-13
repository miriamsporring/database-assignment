using SuperYarnCompany.Context;
using SuperYarnCompany.Entities;

namespace SuperYarnCompany.Repositories;


internal class TypeRepository : Repo<TypeEntity>
{
    private readonly DataContext _context;
    public TypeRepository(DataContext context) : base(context)
    {
        _context = context;
    }
}
