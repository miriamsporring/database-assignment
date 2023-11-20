using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace StartingOverAgain.Contexts;

internal class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
        optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\nackademin\Databasteknik\database-assigment\database-assignment\Solution-StartingOverAgain\StartingOverAgain\Contexts\database_soa.mdf;Integrated Security=True;Connect Timeout=30");
        return new DataContext(optionsBuilder.Options);
    }
}
