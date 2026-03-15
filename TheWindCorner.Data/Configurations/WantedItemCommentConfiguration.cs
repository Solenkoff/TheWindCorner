namespace TheWindCorner.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TheWindCorner.Data.Models.Entities.Comments;

    public class WantedItemCommentConfiguration : IEntityTypeConfiguration<WantedItemComment>
    {
        public void Configure(EntityTypeBuilder<WantedItemComment> builder)
        {
            builder.HasOne(wic => wic.Author)
                .WithMany()
                .HasForeignKey(wic => wic.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(wic => wic.WantedItem)
                .WithMany(wi => wi.Comments)
                .HasForeignKey(wic => wic.WantedItemId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(wic => wic.AuthorId);
        }
    }
}
