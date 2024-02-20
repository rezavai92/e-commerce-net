using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repository
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : EntityBase
    {
        protected ShophubContext _dbContext;

        public GenericRepository(ShophubContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> DeleteItemAsync(TEntity entity)
        {
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteManyItemAsync(IEnumerable<TEntity> entities)
        {
            _dbContext.RemoveRange(entities);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<TEntity?> GetItemAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbContext.Set<TEntity>().Where(filter).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetManyItemAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await _dbContext.Set<TEntity>().Where(filter).ToListAsync();
        }

        public IQueryable<TEntity> GetQueryable()
        {
            return _dbContext.Set<TEntity>();
        }

        public async Task<bool> InsertItemAsync(TEntity writeModel, CancellationToken cancellationToken = default)
        {
            await _dbContext.AddAsync(writeModel, cancellationToken);
            var count= await _dbContext.SaveChangesAsync();

            return count>0;
        }

        public async Task<bool> InsertManyItemAsync(IEnumerable<TEntity> writeModels)
        {
            await _dbContext.AddRangeAsync(writeModels);

            var count = await _dbContext.SaveChangesAsync();

            return count>0;
        }

        public async Task<bool> UpdateItemAsync(TEntity writeModel, CancellationToken cancellationToken = default)
        {
            await _dbContext.AddAsync(writeModel, cancellationToken);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateManyItemAsync(IEnumerable<TEntity> entities)
        {
            await _dbContext.AddRangeAsync(entities);

            await _dbContext.SaveChangesAsync();

            return true;

        }
    }
}
