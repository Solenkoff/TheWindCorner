namespace TheWindCorner.Data.Repositories.Interfaces
{
    using System.Linq.Expressions;


    public interface IRepository<TType, TId>
         where TType : class
    {
        IQueryable<TType> All();

        IQueryable<TType> AllAsNoTracking();

        TType? GetById(TId id);

        Task<TType?> GetByIdAsync(TId id);

        TType? FirstOrDefault(Expression<Func<TType, bool>> predicate);

        Task<TType?> FirstOrDefaultAsync(Expression<Func<TType, bool>> predicate);

        void Add(TType item);

        Task AddAsync(TType item);

        void AddRange(IEnumerable<TType> items);

        Task AddRangeAsync(IEnumerable<TType> items);

        void Update(TType item);

        void Delete(TType entity);

        void SoftDelete(TType entity);

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
