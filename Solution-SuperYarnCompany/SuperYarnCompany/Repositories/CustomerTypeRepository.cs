using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperYarnCompany.Context;
using SuperYarnCompany.Entities;

namespace SuperYarnCompany.Repositories
{
    internal class CustomerTypeRepository : Repo<CustomerTypeEntity>
    {
        public CustomerTypeRepository(DataContext context) : base(context)
        {
        }
    }
}
