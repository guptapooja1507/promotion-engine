using PromotionEngineSln.Enums;
using PromotionEngineSln.Interfaces;
using System.Collections.Generic;

namespace PromotionEngineSln.Implementations
{
    /// <summary>
    /// Implementation of order service.
    /// </summary>
    public class OrderService : IOrderService
    {
        public List<Order> GetOrderList()
        {
            List<Order> orders = new List<Order>();
            Order order1 = new Order(1, new List<Product>() { new Product(SKUId.A), new Product(SKUId.B), new Product(SKUId.C) });
            Order order2 = new Order(2, new List<Product>() { new Product(SKUId.A), new Product(SKUId.A), new Product(SKUId.A), new Product(SKUId.A), new Product(SKUId.A),
                                                              new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B),
                                                              new Product(SKUId.C) });
            Order order3 = new Order(3, new List<Product>() { new Product(SKUId.A), new Product(SKUId.A), new Product(SKUId.A),
                                                              new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B),
                                                              new Product(SKUId.C),
                                                              new Product(SKUId.D)  });
            orders.AddRange(new Order[] { order1, order2, order3 });

            return orders;
        }
    }
}
