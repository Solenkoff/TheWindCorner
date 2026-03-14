namespace TheWindCorner.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TheWindCorner.Data.Models.Entities;

    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.Property(n => n.EntityType)
                .HasConversion<string>();

            builder.Property(n => n.ActionType)
                .HasConversion<string>();

            builder.HasOne(n => n.TriggeredBy)
                .WithMany()
                .HasForeignKey(n => n.TriggeredById)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasIndex(n => new { n.IsRead, n.IsHandled });

            builder.HasIndex(n => n.TriggeredById);
        }
    }
}
