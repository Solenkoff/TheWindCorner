namespace TheWindCorner.Data.Models.Entities.Contracts
{
    public interface IAuditDeletableEntity : IDeletableEntity
    {
        DateTime? DeletedOn { get; set; }
    }
}
