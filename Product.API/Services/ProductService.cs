using Product.API.Repositories.Products;

namespace Product.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
            => _repository = repository;

        public async ValueTask<Models.Product> AddAsync(Models.Product product)
        {
            return await _repository.AddAsync(product);
        }

        public async ValueTask<Models.Product> DeleteAsync(int id)
        {
            var storedProduct = await _repository.GetAsync(id);

            if (storedProduct == null)
                throw new Exception("");

            return await _repository.DeleteAsync(storedProduct);
        }

        public async ValueTask<List<Models.Product>> GetAllAsync()
            => await _repository.GetAsync();

        public async ValueTask<Models.Product> GetAsync(int id)
        {
            var storedProduct = await _repository.GetAsync(id);

            if (storedProduct == null)
                throw new Exception("");

            return storedProduct;
        }

        public async ValueTask<Models.Product> UpdateAsync(Models.Product product, int id)
        {
            var storedProduct = await _repository.GetAsync(id);

            if (storedProduct == null)
                throw new Exception("");

            return await _repository.UpdateAsync(storedProduct);
        }
    }
}
