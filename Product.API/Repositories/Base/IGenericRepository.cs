namespace Product.API.Repositories.Base
{
    public interface IGenericRepository<TEntity>
    {
        public ValueTask<TEntity> AddAsync(TEntity entity);
        public ValueTask<TEntity> GetAsync(int id);
        public ValueTask<List<TEntity>> GetAsync();
        public ValueTask<TEntity> UpdateAsync(TEntity entity);
        public ValueTask<TEntity> DeleteAsync(TEntity entity);
    }
}
