namespace TheWindCorner.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TheWindCorner.Data.Models.Entities;

    public class ItemCommentConfiguration : IEntityTypeConfiguration<ItemComment>
    {
        public void Configure(EntityTypeBuilder<ItemComment> builder)
        {
            builder.HasOne(ic => ic.Author)
                .WithMany()
                .HasForeignKey(ic => ic.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ic => ic.Item)
                .WithMany(i => i.Comments)
                .HasForeignKey(ic => ic.ItemId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(ic => ic.AuthorId);
        }
    }
}
