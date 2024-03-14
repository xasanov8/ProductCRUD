using Product.API.Data;
using Product.API.Repositories.Base;

namespace Product.API.Repositories.Products
{
    public class ProductRepository : GenericRepository<Models.Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
