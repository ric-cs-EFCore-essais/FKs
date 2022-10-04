using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using DataAccess;


namespace ConsolePrj
{
    public class MyApplicationDbContextFactory : IDesignTimeDbContextFactory<MyApplicationDbContext>
    {
        public MyApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyApplicationDbContext>();

            string server = string.Empty;
            string user = string.Empty;
            string password = string.Empty;
            string databaseName = string.Empty;

            server = @"PC-RP-VM-W10PRO\SQL_SERVER_2019"; user = "SA2"; databaseName = "Essais2_EF_Relationships";

            //server = "localhost,17433"; user = "SA3"; databaseName = "Essais2_EF_Relationships";  //Job

            password = "SS2019PSw";

            optionsBuilder.UseSqlServer(@$"Server={server}; Database={databaseName}; User Id={user}; Password={password};");

            return new MyApplicationDbContext(optionsBuilder.Options);
        }
    }
}
