using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Data.Common;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class FlowerzContext : DbContext
    // NONONO https://learn.microsoft.com/en-us/ef/ef6/fundamentals/working-with-dbcontext
    // YES! https://learn.microsoft.com/en-gb/ef/core/
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NQCJC2O;Database=flowerzz;TrustServerCertificate=false;Integrated Security=true;user id=perky;password=perky;User Instance=true", options => options.EnableRetryOnFailure());

            //optionsBuilder.UseSqlServer(
            //@"Server=DESKTOP-NQCJC2O;Database=flowerzz;Encrypt=False;user id=DESKTOP-NQCJC2O\perky;password=perky;User Instance=true;TrustServerCertificate=true;ConnectRetryCount=0", options => options.EnableRetryOnFailure());
            //"Server=DESKTOP-NQCJC2O;Database=flowerzz;user id=perky;password=perky;User Instance=true;TrustServerCertificate=true;ConnectRetryCount=0");
            //optionsBuilder.UseSqlServer(
            //    @"Server=desktop-nqcjc2o\perky;Database=flowerzz;Trusted_Connection=True;ConnectRetryCount=0");
        }

        public DbSet<Bloom> Blooms { get; set; }
    }

    // using code-first
    // https://learn.microsoft.com/en-gb/ef/ef6/modeling/code-first/workflows/new-database?redirectedfrom=MSDN
    // * Connection hardcoded in Server Explorer --> Data Connections, to loccal DB DESKTOP-NQCJC2O. TODO make it configurable

    // Model
    public class Bloom
    {
        [Key]
        public string Name { get; set; }
    }
    // using Microsoft.EntityFrameworkCore.SqlServer 8.0.7 for .Net8.0
    // https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/8.0.7#readme-body-tab
}
