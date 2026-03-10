namespace TheWindCorner.Data
{
    using System.Reflection;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using TheWindCorner.Data.Models.Entities;
    using TheWindCorner.Data.Models.User;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<WantedItem> WantedItems { get; set; } = null!;
        public virtual DbSet<Spot> Spots { get; set; } = null!;
        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<BlogPost> BlogPosts { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<ItemComment> ItemComments { get; set; } = null!;
        public virtual DbSet<WantedItemComment> WantedItemComments { get; set; } = null!;
        public virtual DbSet<SpotComment> SpotComments { get; set; } = null!;
        public virtual DbSet<EventComment> EventComments { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}