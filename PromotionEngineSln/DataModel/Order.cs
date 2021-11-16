using System.Collections.Generic;

namespace PromotionEngineSln
{
    /// <summary>
    /// This class contains orders of the product
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Get or sets id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get or sets products
        /// </summary>
        public List<Product> Products { get; set; }

        public Order(int id, List<Product> products)
        {
            this.Id = id;
            this.Products = products;
        }
    }
}
