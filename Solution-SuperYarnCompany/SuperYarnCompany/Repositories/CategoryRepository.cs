using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperYarnCompany.Context;
using SuperYarnCompany.Entities;

namespace SuperYarnCompany.Repositories
{
    internal class CategoryRepository : Repo<CategoryEntity>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
