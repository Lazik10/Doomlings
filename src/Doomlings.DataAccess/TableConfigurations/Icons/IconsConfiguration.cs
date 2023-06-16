using Doomlings.Entities.Entities.Icons;
using Doomlings.Entities.Entities.JoinEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doomlings.DataAccess.TableConfigurations.Icons
{
    internal class IconsConfiguration : IEntityTypeConfiguration<Icon>
    {
        public void Configure(EntityTypeBuilder<Icon> builder)
        {
            ArgumentNullException.ThrowIfNull(builder);

            builder.ToTable(TableNames.Icons, Schemas.Icons);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Type)
                .IsRequired()
                .HasConversion<int>();

            builder.Property(x => x.Image)
                .HasColumnType("varbinary(MAX)");

            builder.HasMany(x => x.AgeCards)
                .WithMany(x => x.Icons)
                .UsingEntity<AgeCardIcon>();

            builder.HasMany(x => x.BirthCards)
                .WithMany(x => x.Icons)
                .UsingEntity<BirthCardIcon>();

            builder.HasMany(x => x.GenePoolCards)
                .WithMany(x => x.Icons)
                .UsingEntity(x => x.ToTable("GenePoolCardIcon"));

            builder.HasMany(x => x.PlayerAidCards)
                .WithMany(x => x.Icons)
                .UsingEntity(x => x.ToTable("PlayerAidCardIcon"));

            builder.HasMany(x => x.SignCards)
                .WithMany(x => x.Icons)
                .UsingEntity(x => x.ToTable("SignCardIcon"));

            builder.HasMany(x => x.TraitCards)
                .WithMany(x => x.Icons)
                .UsingEntity<TraitCardIcon>();
        }
    }
}
