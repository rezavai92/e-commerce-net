namespace Application.shared.Interfaces
{
    public interface IShophubRepository
    {
        public Task InsertItemAsync<TEntity>(TEntity writeModel,CancellationToken cancellationToken=default) where TEntity : class;
        public Task InsertManyItemAsync<TEntity>(IEnumerable<TEntity> writeModels) where TEntity : class;
        public Task<TEntity> GetItemAsync<TEntity>() where TEntity : class;
        public Task<TEntity> GetManyItemAsync<TEntity>() where TEntity : class;
        public Task<TEntity> DeleteItemAsync<TEntity>() where TEntity : class;
        public Task<TEntity> DeleteManyItemAsync<TEntity>() where TEntity : class;
        public Task UpdateItemAsync<TEntity>() where TEntity : class;
        public Task UpdateManyItemAsync<TEntity>() where TEntity : class;

    }
}
