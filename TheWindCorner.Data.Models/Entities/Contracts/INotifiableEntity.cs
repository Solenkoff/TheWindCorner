namespace TheWindCorner.Data.Models.Entities.Contracts
{
    using System;
    using TheWindCorner.Data.Models.Enums;

    public interface INotifiableEntity
    {
        Guid Id { get; }
        Guid OwnerId { get; }
        NotifiableEntityType EntityType { get; }
    }
}
