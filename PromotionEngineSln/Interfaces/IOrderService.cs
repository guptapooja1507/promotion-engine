using System.Collections.Generic;

namespace PromotionEngineSln.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetOrderList();
    }
}
