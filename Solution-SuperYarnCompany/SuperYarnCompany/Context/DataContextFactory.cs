using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design; 

namespace SuperYarnCompany.Context
{
    internal class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<DataContext>();
            optionBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\nackademin\Databasteknik\database-assigment\database-assignment\Solution-SuperYarnCompany\SuperYarnCompany\Context\database_superyarncompany.mdf;Integrated Security=True;Connect Timeout=30");
            return new DataContext(optionBuilder.Options);
        }
    }
}
