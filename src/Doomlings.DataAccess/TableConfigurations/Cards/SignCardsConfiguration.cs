using Doomlings.Entities.Entities.Cards.SpecificCards;
using Doomlings.Entities.Entities.JoinEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doomlings.DataAccess.TableConfigurations.Cards
{
    internal class SignCardsConfiguration : IEntityTypeConfiguration<SignCard>
    {
        public void Configure(EntityTypeBuilder<SignCard> builder)
        {
            ArgumentNullException.ThrowIfNull(builder);

            builder.ToTable(TableNames.SignCards, Schemas.Cards);

            builder.HasKey(x => x.Id);

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
                .WithMany(x => x.SignCards)
                .UsingEntity<SignCardIcon>();
        }
    }
}
