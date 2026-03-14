namespace TheWindCorner.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TheWindCorner.Data.Models.Entities;

    public class SpotConfiguration : IEntityTypeConfiguration<Spot>
    {
        public void Configure(EntityTypeBuilder<Spot> builder)
        {
            builder.HasOne(s => s.CreatedBy)
                .WithMany(u => u.AddedSpots)
                .HasForeignKey(s => s.CreatedById)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(s => s.HomeSpotUsers)
                .WithOne(u => u.HomeSpot)
                .HasForeignKey(u => u.HomeSpotId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(s => s.CreatedById);
        }
    }
}
