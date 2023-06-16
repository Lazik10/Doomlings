﻿using Doomlings.Entities.Entities.Cards.SpecificCards;
using Doomlings.Entities.Entities.JoinEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Doomlings.DataAccess.TableConfigurations.Cards
{
    internal class BirthCardsConfiguration : IEntityTypeConfiguration<BirthCard>
    {
        public void Configure(EntityTypeBuilder<BirthCard> builder)
        {
            ArgumentNullException.ThrowIfNull(builder);

            builder.ToTable(TableNames.BirthCards, Schemas.Cards);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnType("nvarchar(50)");

            builder.Property(x => x.Description)
                .HasColumnType("nvarchar(max)");

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
                .WithMany(x => x.BirthCards)
                .UsingEntity<BirthCardIcon>();
        }
    }
}
