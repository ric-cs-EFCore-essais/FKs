using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using Transverse.Common.DebugTools;  //Issu d'un Nuget perso. mis dans ./../../../../____Common/zzMyLocalPublishedPackages/

using Infra.Common.DataAccess.Interfaces;  //Issu d'un Nuget perso. mis dans ./../../../../____Common/zzMyLocalPublishedPackages/
using Infra.Common.DataAccess;  //Issu d'un Nuget perso. mis dans ./../../../../____Common/zzMyLocalPublishedPackages/

using Infra.DataAccess;

namespace ConsolePrj
{
    public class MyApplicationDbContextFactory : IDesignTimeDbContextFactory<MyApplicationDbContext>
    {
        public MyApplicationDbContext CreateDbContext(string[] args)
        {
            IDBServerAccessConfiguration dbServerAccessConfiguration = new DBServerAccessConfiguration()
            {
                DatabaseName = "Essais_EF_Relationships_OneToMany"
            };
            Debug.ShowData(dbServerAccessConfiguration);

            var connectionString = dbServerAccessConfiguration.GetConnectionString();

            var optionsBuilder = new DbContextOptionsBuilder<MyApplicationDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new MyApplicationDbContext(optionsBuilder.Options);
        }
    }
}
