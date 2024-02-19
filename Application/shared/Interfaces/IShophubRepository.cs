using Domain.Entities;
using System.Linq.Expressions;

namespace Application.shared.Interfaces
{
    public interface IShophubRepository
    {
        public Task<bool> InsertItemAsync<TEntity>(TEntity writeModel,CancellationToken cancellationToken=default) where TEntity : class;
        Task<bool> InsertManyItemAsync<TEntity>(IEnumerable<TEntity> writeModels) where TEntity : class;
        Task<TEntity> GetItemAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class;
        Task<IEnumerable<TEntity>> GetManyItemAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class;
        public Task<bool> DeleteItemAsync<TEntity>() where TEntity : class;
        public Task<bool> DeleteManyItemAsync<TEntity>() where TEntity : class;
        public Task<bool> UpdateItemAsync<TEntity>() where TEntity : class;
        public Task<bool> UpdateManyItemAsync<TEntity>() where TEntity : class;

    }
}
