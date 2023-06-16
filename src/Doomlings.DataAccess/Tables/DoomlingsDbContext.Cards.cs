using Doomlings.Entities.Entities.Cards.SpecificCards;
using Microsoft.EntityFrameworkCore;

namespace Doomlings.DataAccess.Tables
{
    public partial class DoomlingsDbContext : DbContext
    {
        public virtual DbSet<AgeCard> AgeCards { get; set; }

        public virtual DbSet<BirthCard> BirthCards { get; set; }

        public virtual DbSet<GenePoolCard> GenePoolCards { get; set; }

        public virtual DbSet<PlayerAidCard> PlayerAidCards { get; set; }

        public virtual DbSet<SignCard> SignCards { get; set; }

        public virtual DbSet<TraitCard> TraitCards { get; set; }
    }
}
