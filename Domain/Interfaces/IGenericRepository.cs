using Domain.Entities;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : EntityBase
    {
        public Task<bool> InsertItemAsync(TEntity writeModel, CancellationToken cancellationToken = default);
        Task<bool> InsertManyItemAsync(IEnumerable<TEntity> writeModels);
        Task<TEntity> GetItemAsync(Expression<Func<TEntity, bool>> filter);
        Task<IEnumerable<TEntity>> GetManyItemAsync(Expression<Func<TEntity, bool>> filter);
        public Task<bool> DeleteItemAsync(TEntity entity);
        public Task<bool> DeleteManyItemAsync(IEnumerable<TEntity> entities);
        Task<bool> UpdateItemAsync(TEntity writeModel, CancellationToken cancellationToken = default);
        public Task<bool> UpdateManyItemAsync(IEnumerable<TEntity> entities);
        IQueryable<TEntity> GetQueryable();


    }
}
