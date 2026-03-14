namespace TheWindCorner.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TheWindCorner.Data.Models.Entities;

    public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.HasOne(bp => bp.CreatedBy)
                .WithMany(u => u.BlogPosts)
                .HasForeignKey(bp => bp.CreatedById)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
