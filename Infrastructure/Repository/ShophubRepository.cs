using Application.shared.Interfaces;
using Domain.Entities;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Infrastructure.Repository
{
    public class ShophubRepository : IShophubRepository
    {
        ShophubContext _dbContext;
       
        public ShophubRepository(ShophubContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<bool> DeleteItemAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteManyItemAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetItemAsync<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class
        {
            return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(filter) ;
        }

        public async Task<IEnumerable<TEntity>> GetManyItemAsync<TEntity>(Expression<Func<TEntity,bool>> filter) where TEntity : class
        {
            var x = await _dbContext.Set<TEntity>().Where(filter).ToListAsync();

            return x;
        }

        public async Task<bool> InsertItemAsync<TEntity>(TEntity writeModel,CancellationToken cancellationToken = default) where TEntity : class
        {
            try
            {
                await _dbContext.Set<TEntity>().AddAsync(writeModel, cancellationToken);
                await _dbContext.SaveChangesAsync();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
          
        }

        public async Task<bool> InsertManyItemAsync<TEntity>(IEnumerable<TEntity> writeModels) where TEntity : class
        {
            try
            {
                foreach (var model in writeModels)
                {
                    var x = await _dbContext.Set<TEntity>().AddAsync(model);

                }
            }
            catch(Exception ex)
            {
                return false;
            }
          
            return true;
        }

        public async Task<bool> UpdateItemAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateManyItemAsync<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
