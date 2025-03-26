using Microsoft.AspNetCore.Mvc;
using shopping_list.Services.Database;

namespace shopping_list.APIs
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsDatabaseService _productsDatabaseService;

        public ProductsController(ProductsDatabaseService productsDatabaseService)
        {
            _productsDatabaseService = productsDatabaseService;
        }

        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProductsAsync()
        {
            var products = await _productsDatabaseService.GetProductsAsync();
            return Ok(products);
        }

        [HttpPost("GenerateSimpleProduct")]
        public async Task<IActionResult> GenerateSimpleProduct(string productName)
        {
            await _productsDatabaseService.GenerateSimpleProduct(productName);
            return Ok();
        }
    }
}
