using PromotionEngineSln.Enums;
using System.Collections.Generic;

namespace PromotionEngineSln
{
    /// <summary>
    /// This class contains promotion details about product
    /// </summary>
    public class Promotion
    {
        /// <summary>
        /// Get or sets id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get or sets product info
        /// </summary>
        public Dictionary<SKUId, int> ProductInfo { get; set; }

        /// <summary>
        /// Get or sets promotion price
        /// </summary>
        public decimal Price { get; set; }

        public Promotion(int id, Dictionary<SKUId, int> productInfo, decimal price)
        {
            this.Id = id;
            this.ProductInfo = productInfo;
            this.Price = price;
        }
    }
}
