
using shopping_list.Models.Enums;

namespace shopping_list.Models.Database
{
    /// <summary>
    /// The products database model.
    /// </summary>
    public class Products
    {
        /// <summary>
        /// The product id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The product name.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The product description.
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// The supermarket where the product is located.
        /// </summary>
        public Supermarkets Supermarket { get; set; }
    }
}
