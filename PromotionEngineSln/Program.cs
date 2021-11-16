using PromotionEngineSln.Implementations;
using PromotionEngineSln.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngineSln
{
    public class Program
    {
        static void Main(string[] args)
        {
            IOrderService orderService = new OrderService();
            IPromotionService promotionService = new PromotionService();
            IProductService productService = new ProductService();

            //create orders
            List<Order> orders = orderService.GetOrderList();

            foreach (Order order in orders)
            {
                decimal origprice = order.Products.Sum(x => x.Price);
                decimal promoprice = GetTotalPriceOfProduct(order, promotionService, productService); 
                Console.WriteLine($"OrderID: {order.Id} => Original price: {origprice.ToString("0.00")} | Total Price After Promotion Applied: {promoprice.ToString("0.00")} ");
            }
        }

        public static decimal GetTotalPriceOfProduct(Order order, IPromotionService promotionService, IProductService productService)
        {
            List<decimal> promoprices = promotionService.GetListOfActivePromotions()
                    .Select(promo => productService.GetTotalPrice(order, promo))
                    .ToList();
            
            return promoprices.Sum();
        }
    }
}


