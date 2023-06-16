using Doomlings.Entities.Entities.Icons;
using Microsoft.EntityFrameworkCore;

namespace Doomlings.DataAccess.Tables
{
    public partial class DoomlingsDbContext : DbContext
    {
        public virtual DbSet<Icon> Icons { get; set; }
    }
}
