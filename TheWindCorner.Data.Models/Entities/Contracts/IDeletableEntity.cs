namespace TheWindCorner.Data.Models.Entities.Contracts
{
    public interface IDeletableEntity
    {
        bool IsDeleted { get; set; }
    }
}
