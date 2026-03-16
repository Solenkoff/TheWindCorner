namespace TheWindCorner.Data.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System.Linq.Expressions;

    using TheWindCorner.Data.Models.Entities.Contracts;
    using TheWindCorner.Data.Repositories.Interfaces;

    public class BaseRepository<TType, TId> : IRepository<TType, TId>
           where TType : class
    {
        private readonly ApplicationDbContext dbContext;
        private readonly DbSet<TType> dbSet;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.dbSet = this.dbContext.Set<TType>();
        }

        public IQueryable<TType> All()
        {
            return this.dbSet;
        }

        public IQueryable<TType> AllAsNoTracking()
        {
            return this.dbSet.AsNoTracking();
        }

        public TType? GetById(TId id)
        {
            return this.dbSet.Find(id);
        }

        public async Task<TType?> GetByIdAsync(TId id)
        {
            return await this.dbSet.FindAsync(id);
        }

        public TType? FirstOrDefault(Expression<Func<TType, bool>> predicate)
        {
            return this.dbSet.FirstOrDefault(predicate);
        }

        public async Task<TType?> FirstOrDefaultAsync(Expression<Func<TType, bool>> predicate)
        {
            return await this.dbSet.FirstOrDefaultAsync(predicate);
        }

        public void Add(TType item)
        {
            this.dbSet.Add(item);
        }

        public async Task AddAsync(TType item)
        {
            await this.dbSet.AddAsync(item);
        }

        public void AddRange(IEnumerable<TType> items)
        {
            this.dbSet.AddRange(items);
        }

        public async Task AddRangeAsync(IEnumerable<TType> items)
        {
            await this.dbSet.AddRangeAsync(items);
        }

        public void Update(TType item)
        {
            this.dbSet.Update(item);
        }

        public void Delete(TType entity)
        {
            this.dbSet.Remove(entity);
        }

        public void SoftDelete(TType entity)
        {
            if (entity is not IDeletableEntity deletableEntity)
            {
                throw new InvalidOperationException($"{typeof(TType).Name} does not support soft delete.");
            }

            deletableEntity.IsDeleted = true;

            if (entity is IAuditDeletableEntity auditEntity)
            {
                auditEntity.DeletedOn = DateTime.UtcNow;
            }

            this.dbSet.Update(entity);
        }

        public int SaveChanges()
        {
            return this.dbContext.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return this.dbContext.SaveChangesAsync();
        }
    }
}
