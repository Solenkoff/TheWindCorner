namespace TheWindCorner.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TheWindCorner.Data.Models.Entities;

    public class WantedItemConfiguration : IEntityTypeConfiguration<WantedItem>
    {
        public void Configure(EntityTypeBuilder<WantedItem> builder)
        {
            builder.Property(wi => wi.Category)
                .HasConversion<string>();

            builder.HasOne(wi => wi.CreatedBy)
                .WithMany(u => u.WantedItems)
                .HasForeignKey(wi => wi.CreatedById)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(wi => wi.CreatedById);
        }
    }
}
