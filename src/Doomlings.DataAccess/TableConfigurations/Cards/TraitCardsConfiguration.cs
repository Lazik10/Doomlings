using Doomlings.Entities.Entities.Cards.SpecificCards;
using Doomlings.Entities.Entities.JoinEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doomlings.DataAccess.TableConfigurations.Cards
{
    internal class TraitCardsConfiguration : IEntityTypeConfiguration<TraitCard>
    {
        public void Configure(EntityTypeBuilder<TraitCard> builder)
        {
            ArgumentNullException.ThrowIfNull(builder);

            builder.ToTable(TableNames.TraitCards, Schemas.Cards);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(x => x.Description)
                .IsRequired()
                .HasColumnType("navrchar(MAX)");

            builder.Property(x => x.Type)
                .IsRequired()
                .HasColumnType("int")
                .HasConversion<int>();

            builder.Property(x => x.Color)
                .IsRequired()
                .HasColumnType("int")
                .HasConversion<int>();

            builder.Property(x => x.Expansion)
                .IsRequired()
                .HasColumnType("int")
                .HasConversion<int>();

            builder.Property(x => x.Effect)
                .IsRequired()
                .HasColumnType("int")
                .HasConversion<int>();

            builder.HasMany(x => x.Icons)
                .WithMany(x => x.TraitCards)
                .UsingEntity<TraitCardIcon>();
        }
    }
}
