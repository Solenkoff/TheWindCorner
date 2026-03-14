namespace TheWindCorner.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TheWindCorner.Data.Models.Entities;

    public class SpotCommentConfiguration : IEntityTypeConfiguration<SpotComment>
    {
        public void Configure(EntityTypeBuilder<SpotComment> builder)
        {
            builder.HasOne(sc => sc.Author)
                .WithMany()
                .HasForeignKey(sc => sc.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(sc => sc.Spot)
                .WithMany(s => s.Comments)
                .HasForeignKey(sc => sc.SpotId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(sc => sc.AuthorId);
        }
    }
}
