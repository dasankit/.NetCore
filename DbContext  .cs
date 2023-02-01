using Microsoft.EntityFrameworkCore;

namespace AnkitTest
{
    public class CrudSampleContext : DbContext
    {
        public CrudSampleContext(DbContextOptions<CrudSampleContext> options) : base(options)
        {
        }

        public DbSet<CTEResult> CTEResults { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CTEResultsConfiguration());
        }
    }
}
