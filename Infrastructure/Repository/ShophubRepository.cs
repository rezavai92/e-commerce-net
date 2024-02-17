using Application.shared.Interfaces;
using Domain.Entities;
using Infrastructure.DatabaseContext;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Repository
{
    public class ShophubRepository : IShophubRepository
    {
        ShophubContext _dbContext;
       
        public ShophubRepository(ShophubContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<TEntity> DeleteItemAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> DeleteManyItemAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetItemAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetManyItemAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public async Task InsertItemAsync<TEntity>(TEntity writeModel,CancellationToken cancellationToken = default) where TEntity : class
        {
          
           await _dbContext.Set<TEntity>().AddAsync(writeModel,cancellationToken);  
           await _dbContext.SaveChangesAsync();   
        }

        public Task InsertManyItemAsync<TEntity>(IEnumerable<TEntity> writeModels) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task UpdateManyItemAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
