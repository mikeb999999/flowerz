using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class FlowerzContext : DbContext
    // YES! https://learn.microsoft.com/en-gb/ef/core/
    // NONONO https://learn.microsoft.com/en-us/ef/ef6/fundamentals/working-with-dbcontext
    {
        public DbSet<Bloom> Bloom { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NQCJC2O;Database=flowerz;Integrated Security=true;ConnectRetryCount=0");
            // BTW you need to initially set up a certificate for SQL Server, thus:
            // https://manage.accuwebhosting.com/knowledgebase/2924/Fix--Server-Unable-to-load-user-specified-certificate.-The-server-will-not-accept-a-connection.html
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Bloom>(entity =>
            {
                entity.HasKey(e => e.Name);
                entity.Property(e => e.Name).IsRequired();
            });
        }
    }

    // using code-first
    // YES! https://docs.oracle.com/cd/E17952_01/connector-net-en/connector-net-entityframework-core-example.html
    // NO! https://learn.microsoft.com/en-gb/ef/ef6/modeling/code-first/workflows/new-database?redirectedfrom=MSDN

    // Model
    public class Bloom
    {
        public string Name { get; set; }
    }
    // using Microsoft.EntityFrameworkCore.SqlServer 8.0.7 for .Net8.0
    // https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/8.0.7#readme-body-tab
}
