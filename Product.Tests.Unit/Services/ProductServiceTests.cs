using Moq;
using Product.API.Repositories.Products;
using Product.API.Services;

namespace Product.Tests.Unit.Services
{
    public partial class ProductServiceTests
    {
        private readonly IProductService _productService;
        private readonly Mock<IProductRepository> _mockProductRepository;

        public ProductServiceTests()
        {
            _mockProductRepository = new Mock<IProductRepository>();
            _productService = new ProductService(_mockProductRepository.Object);
        }
    }
}
