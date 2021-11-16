using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineSln.Interfaces
{
    public interface IPromotionService
    {
        List<Promotion> GetListOfActivePromotions();
    }
}
