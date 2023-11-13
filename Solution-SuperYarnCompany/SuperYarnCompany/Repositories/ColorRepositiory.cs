using SuperYarnCompany.Context;
using SuperYarnCompany.Entities;

namespace SuperYarnCompany.Repositories;

internal class ColorRepositiory
{
    internal class ColorRepository : Repo<ColorEntity>
    {
        private readonly DataContext _context;
        public ColorRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}

