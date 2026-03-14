namespace TheWindCorner.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TheWindCorner.Data.Models.Entities;

    public class EventCommentConfiguration : IEntityTypeConfiguration<EventComment>
    {
        public void Configure(EntityTypeBuilder<EventComment> builder)
        {
            builder.HasOne(ec => ec.Author)
                .WithMany()
                .HasForeignKey(ec => ec.AuthorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ec => ec.Event)
                .WithMany(e => e.Comments)
                .HasForeignKey(ec => ec.EventId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(ec => ec.AuthorId);
        }
    }
}
