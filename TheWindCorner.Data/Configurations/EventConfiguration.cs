namespace TheWindCorner.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using TheWindCorner.Data.Models.Entities;

    public class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.Property(e => e.Status)
                .HasConversion<string>();

            builder.HasOne(e => e.CreatedBy)
                .WithMany(u => u.Events)
                .HasForeignKey(e => e.CreatedById)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Spot)
                .WithMany(s => s.Events)
                .HasForeignKey(e => e.SpotId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable(t => t.HasCheckConstraint(
                "CK_Events_End_After_Start",
                "[End] > [Start]"));

            builder.HasIndex(e => e.CreatedById);
        }
    }
}
