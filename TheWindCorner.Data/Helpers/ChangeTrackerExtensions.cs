namespace TheWindCorner.Data.Helpers
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;

    using TheWindCorner.Data.Models.Entities;

    public static class ChangeTrackerExtensions
    {
        public static void ApplyTimestamps(this ChangeTracker changeTracker)
        {
            DateTime now = DateTime.UtcNow;

            foreach (var entry in changeTracker.Entries())
            {
                if (entry.State != EntityState.Added)
                {
                    continue;
                }

                switch (entry.Entity)
                {
                    case Item item:
                        item.DateAdded = now;
                        break;
                    case WantedItem wantedItem:
                        wantedItem.DateAdded = now;
                        break;
                    case Spot spot:
                        spot.DateAdded = now;
                        break;
                    case Event eventEntity:
                        eventEntity.DateAdded = now;
                        break;
                    case BlogPost blogPost:
                        blogPost.DateAdded = now;
                        break;
                    case ItemComment itemComment:
                        itemComment.CommentedOn = now;
                        break;
                    case WantedItemComment wantedItemComment:
                        wantedItemComment.CommentedOn = now;
                        break;
                    case SpotComment spotComment:
                        spotComment.CommentedOn = now;
                        break;
                    case EventComment eventComment:
                        eventComment.CommentedOn = now;
                        break;
                    case Notification notification:
                        notification.CreatedAt = now;
                        break;
                }
            }
        }
    }
}
