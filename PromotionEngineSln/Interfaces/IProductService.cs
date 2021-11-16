namespace PromotionEngineSln.Interfaces
{
    public interface IProductService
    {
        decimal GetTotalPrice(Order ord, Promotion prom);
    }
}
