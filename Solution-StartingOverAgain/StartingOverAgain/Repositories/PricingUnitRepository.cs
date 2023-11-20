using StartingOverAgain.Contexts;
using StartingOverAgain.Entities;

namespace StartingOverAgain.Repositories;

internal class PricingUnitRepository : Repo<PricingUnitEntity>
{
    public PricingUnitRepository(DataContext context) : base(context)
    {
    }
}
