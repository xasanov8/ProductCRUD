using Moq;
using Xunit;

namespace Product.Tests.Unit.Services
{
    public partial class ProductServiceTests
    {
        [Fact]
        public async Task ShouldAddNewProductAsync()
        {
            //Arrange
            var inputproduct = new Product.API.Models.Product()
            {
                Id = 1,
                Name = "Narsa",
                Description = "Zo'r narsa"
            };

            var expectedproduct = new Product.API.Models.Product()
            {
                Id = inputproduct.Id,
                Name = inputproduct.Name,
                Description = inputproduct.Description,
            };

            _mockProductRepository.Setup(x
                => x.AddAsync(It.IsAny<Product.API.Models.Product>()))
                //=> x.AddAsync(inputproduct))
                .ReturnsAsync(expectedproduct);

            //Act
            var actualProduct = await _productService.AddAsync(inputproduct);

            //Assert
            Assert.Equal(expectedproduct, actualProduct);
            Assert.Equal(expectedproduct.Description, actualProduct.Description);
        }

        [Fact]
        public async Task ShouldDeleteProductAsync()
        {
            //Arrange
            var inputproduct = new Product.API.Models.Product()
            {
                Id = 1,
                Name = "Narsa",
                Description = "Zo'r narsa"
            };

            var expectedproduct = new Product.API.Models.Product()
            {
                Id = inputproduct.Id,
                Name = inputproduct.Name,
                Description = inputproduct.Description,
            };

            _mockProductRepository.Setup(x => x.DeleteAsync(It.IsAny<Product.API.Models.Product>()))
                .ReturnsAsync(expectedproduct);

            //Act
            var actualProduct = await _productService.DeleteAsync(inputproduct.Id);

            //Assert
            Assert.Equal(expectedproduct.Name, actualProduct.Name);
            Assert.Equal(expectedproduct.Description, actualProduct.Description);
        }
    }
}
