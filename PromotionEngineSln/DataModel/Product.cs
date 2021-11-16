using PromotionEngineSln.Enums;

namespace PromotionEngineSln
{
    /// <summary>
    /// This class contains product details
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Get or sets id.
        /// </summary>
        public SKUId Id { get; set; }

        /// <summary>
        /// Get or sets price of the product.
        /// </summary>
        public decimal Price { get; set; }

        public Product(SKUId id)
        {
            this.Id = id;
            switch (id)
            {
                case SKUId.A:
                    this.Price = 50m;

                    break;
                case SKUId.B:
                    this.Price = 30m;

                    break;
                case SKUId.C:
                    this.Price = 20m;

                    break;
                case SKUId.D:
                    this.Price = 15m;
                    break;
            }
        }
    }
}
