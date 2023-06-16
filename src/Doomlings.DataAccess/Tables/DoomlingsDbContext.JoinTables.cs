using Doomlings.Entities.Entities.JoinEntities;
using Microsoft.EntityFrameworkCore;

namespace Doomlings.DataAccess.Tables
{
    public partial class DoomlingsDbContext : DbContext
    {
        public virtual DbSet<AgeCardIcon> AgeCardIcon { get; set; }

        public virtual DbSet<BirthCardIcon> BirthCardIcon { get; set; }

        public virtual DbSet<GenePoolCardIcon> GenePoolCardIcon { get; set; }

        public virtual DbSet<PlayerAidCardIcon> PlayerAidCardIcon { get; set; }

        public virtual DbSet<SignCardIcon> SignCardIcon { get; set; }

        public virtual DbSet<TraitCardIcon> TraitCardIcon { get; set; }
    }
}
