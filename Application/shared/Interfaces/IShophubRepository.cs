using Domain.Entities;
using System.Linq.Expressions;

namespace Application.shared.Interfaces
{
    public interface IShophubRepository<TEntity> where TEntity : class
    {
        public Task<bool> InsertItemAsync(TEntity writeModel, CancellationToken cancellationToken = default);
        Task<bool> InsertManyItemAsync(IEnumerable<TEntity> writeModels);
        Task<TEntity> GetItemAsync(Expression<Func<TEntity, bool>> filter);
        IQueryable<TEntity> GetQueryable();
        Task<IEnumerable<TEntity>> GetManyItemAsync(Expression<Func<TEntity, bool>> filter);
        public Task<bool> DeleteItemAsync();
        public Task<bool> DeleteManyItemAsync();
        public Task<bool> UpdateItemAsync();
        public Task<bool> UpdateManyItemAsync();
        Task<IEnumerable<TEntity>> GetFromQueryAsync(IQueryable<TEntity> query);
        IQueryable<TEntity> IncludeRelationalField(IQueryable<TEntity> entity, IEnumerable<string> fieldNames);

        IQueryable<TEntity> IncludeRelationalField(IEnumerable<string> fieldNames);
        IQueryable<TEntity> IncludeRelationalField<TProperty>(Expression<Func<TEntity, TProperty>> filter);




    }
}
