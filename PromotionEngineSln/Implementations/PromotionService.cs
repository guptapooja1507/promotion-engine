using PromotionEngineSln.Enums;
using PromotionEngineSln.Interfaces;
using System.Collections.Generic;

namespace PromotionEngineSln.Implementations
{
    public class PromotionService : IPromotionService
    {
        public List<Promotion> GetListOfActivePromotions()
        {
            //create list of promotions
            //we need to add information about Product's count
            Dictionary<SKUId, int> d1 = new Dictionary<SKUId, int>();
            d1.Add(SKUId.A, 3);
            Dictionary<SKUId, int> d2 = new Dictionary<SKUId, int>();
            d2.Add(SKUId.B, 2);
            Dictionary<SKUId, int> d3 = new Dictionary<SKUId, int>();
            d3.Add(SKUId.C, 1);
            d3.Add(SKUId.D, 1);

            return new List<Promotion>()
            {
                new Promotion(1, d1, 130),
                new Promotion(2, d2, 45),
                new Promotion(3, d3, 30)
            };
        }
    }
}
