using PromotionEngineSln.Interfaces;
using System.Linq;

namespace PromotionEngineSln.Implementations
{
    public class ProductService : IProductService
    {
        public decimal GetTotalPrice(Order ord, Promotion prom)
        {
            var product = ord.Products.FirstOrDefault(p => prom.ProductInfo.Any(_ => _.Key == p.Id));

            //get count of promoted products in order
            var productCountInOrder = ord.Products
                .GroupBy(x => x.Id)
                .Where(grp => prom.ProductInfo.Any(y => grp.Key == y.Key && grp.Count() >= y.Value))
                .Select(grp => grp.Count())
                .Sum();

            if (productCountInOrder <= 0)
                return product.Price;

            //get count of promoted products from promotion
            int promotedProductCount = prom.ProductInfo.Sum(kvp => kvp.Value);

            return (productCountInOrder / promotedProductCount) * prom.Price + (productCountInOrder % promotedProductCount * product.Price);
        }
    }
}
