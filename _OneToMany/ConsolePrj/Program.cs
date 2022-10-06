using System;

using Infra.Common.DataAccess.Interfaces;  //Issu d'un Nuget perso. mis dans ./../../../../____Common/zzMyLocalPublishedPackages/
using Infra.Common.DataAccess;  //Issu d'un Nuget perso. mis dans ./../../../../____Common/zzMyLocalPublishedPackages/
using Transverse.Common.DebugTools;  //Issu d'un Nuget perso. mis dans ./../../../../____Common/zzMyLocalPublishedPackages/

namespace ConsolePrj
{
    static class Program
    {
        static void Main()
        {
            //IDBServerAccessConfiguration dbServerAccessConfiguration = new DBServerAccessConfiguration()
            //{
            //    DatabaseName = "MaBase",
            //    Options = "yyy=true"
            //};
            //Debug.ShowData(dbServerAccessConfiguration);


            Console.WriteLine("\n\nOk"); Console.ReadKey();
        }
    }
}
