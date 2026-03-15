namespace TheWindCorner.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TheWindCorner.Data.Models.Entities;

    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(i => i.EntityType)
                .HasConversion<string>();

            builder.Property(i => i.Path)
                .IsRequired();

            builder.HasIndex(i => new { i.EntityType, i.EntityId, i.DisplayOrder });
        }
    }
}
