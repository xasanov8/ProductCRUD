namespace Product.API.Services
{
    public interface IProductService
    {
        public ValueTask<Models.Product> AddAsync(Models.Product product);
        public ValueTask<Models.Product> GetAsync(int id);
        public ValueTask<List<Models.Product>> GetAllAsync();
        public ValueTask<Models.Product> UpdateAsync(Models.Product product, int id);
        public ValueTask<Models.Product> DeleteAsync(int id);
    }
}
