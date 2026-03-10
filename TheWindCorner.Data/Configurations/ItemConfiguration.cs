namespace TheWindCorner.Data.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TheWindCorner.Data.Models.Entities;

    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.Property(i => i.Price)
                .HasPrecision(18, 2);

            builder.Property(i => i.Category)
                .HasConversion<string>();

            builder.Property(i => i.ItemType)
                .HasConversion<string>();
        }
    }
}


