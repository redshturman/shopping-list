using Microsoft.EntityFrameworkCore;
using shopping_list.Models.Database;
using shopping_list.Models.Enums;
using shopping_list.Modules;

namespace shopping_list.Services.Database
{
    public class ProductsDatabaseService
    {
        private readonly ShoppingListDbContext _shoppingListDbContext;

        public ProductsDatabaseService(ShoppingListDbContext shoppingListDbContext)
        {
            _shoppingListDbContext = shoppingListDbContext;
        }

        public async Task<List<Products>> GetProductsAsync()
        {
            return await _shoppingListDbContext.Products.AsNoTracking().ToListAsync();
        }

        public async Task GenerateSimpleProduct(string productName)
        {
            var simpleProduct = MapSimpleProduct(productName);
            await _shoppingListDbContext.Products.AddAsync(simpleProduct);
            await _shoppingListDbContext.SaveChangesAsync();
        }

        private Products MapSimpleProduct(string productName)
        {
            return new Products
            {
                Name = productName,
                Description = "Simple product",
                Supermarket = Supermarkets.Any
            };
        }
    }
}
