using Microsoft.EntityFrameworkCore;

namespace Doomlings.DataAccess
{
    public partial class DoomlingsDbContext : DbContext
    {
        public DoomlingsDbContext(DbContextOptions<DoomlingsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DoomlingsDbContext).Assembly);
        }
    }
}
