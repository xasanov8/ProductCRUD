using Microsoft.AspNetCore.Mvc;
using Product.API.Services;

namespace Product.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
            => _productService = productService;

        [HttpPost]
        public async Task<ActionResult<Models.Product>> PostAsync(Models.Product product)
            => await _productService.AddAsync(product);

        [HttpGet]
        public async Task<ActionResult<Models.Product>> GetAsync(int id)
            => await _productService.GetAsync(id);

        [HttpGet]
        public async Task<ActionResult<List<Models.Product>>> GetAllAsync()
            => await _productService.GetAllAsync();

        [HttpPut]
        public async Task<ActionResult<Models.Product>> PutAsync(int id, Models.Product product)
            => await _productService.UpdateAsync(product, id);

        [HttpDelete]
        public async Task<ActionResult<Models.Product>> DeleteAsync(int id)
            => await _productService.DeleteAsync(id);
    }
}
