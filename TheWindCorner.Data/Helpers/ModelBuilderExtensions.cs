namespace TheWindCorner.Data.Helpers
{
    using Microsoft.EntityFrameworkCore;
    using TheWindCorner.Data.Models.Entities;

    public static class ModelBuilderExtensions
    {
        public static void ApplySoftDeleteQueryFilters(this ModelBuilder builder)
        {
            builder.Entity<Item>().HasQueryFilter(i => !i.IsDeleted);
            builder.Entity<WantedItem>().HasQueryFilter(wi => !wi.IsDeleted);
            builder.Entity<Spot>().HasQueryFilter(s => !s.IsDeleted);
            builder.Entity<Event>().HasQueryFilter(e => !e.IsDeleted);
            builder.Entity<BlogPost>().HasQueryFilter(bp => !bp.IsDeleted);

            builder.Entity<ItemComment>().HasQueryFilter(ic => !ic.IsDeleted);
            builder.Entity<WantedItemComment>().HasQueryFilter(wic => !wic.IsDeleted);
            builder.Entity<SpotComment>().HasQueryFilter(sc => !sc.IsDeleted);
            builder.Entity<EventComment>().HasQueryFilter(ec => !ec.IsDeleted);
        }
    }
}
