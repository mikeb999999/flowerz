using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Data.Common;
using System.Data.Entity;
using System.Reflection.Metadata;

namespace Model
{
    public class FlowerzContext : DbContext
    // https://learn.microsoft.com/en-us/ef/ef6/fundamentals/working-with-dbcontext
    {
        public DbSet<Bloom> Blooms { get; set; }
    }

    // using code-first
    // https://learn.microsoft.com/en-gb/ef/ef6/modeling/code-first/workflows/new-database?redirectedfrom=MSDN
    // * Connection hardcoded in Server Explorer --> Data Connections, to loccal DB DESKTOP-NQCJC2O. TODO make it configurable

    // Model
    public class Bloom
    {
        public string Name { get; set; }
    }
    // using Microsoft.EntityFrameworkCore.SqlServer 8.0.7 for .Net8.0
    // https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/8.0.7#readme-body-tab
}
