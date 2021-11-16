using Moq;
using NUnit.Framework;
using PromotionEngineSln;
using PromotionEngineSln.Enums;
using PromotionEngineSln.Implementations;
using PromotionEngineSln.Interfaces;
using System.Collections.Generic;

namespace PromotionEngine.Test
{
    public class ProductTest
    {
        private readonly Order scenarioAOrder = null;

        private readonly Order scenarioBOrder = null;

        private readonly Order scenarioCOrder = null;

        private readonly List<Promotion> activePromotions = null;

        public ProductTest()
        {
            scenarioAOrder = new Order(1, new List<Product>() { new Product(SKUId.A), new Product(SKUId.B), new Product(SKUId.C) });
            scenarioBOrder = new Order(2, new List<Product>() { new Product(SKUId.A), new Product(SKUId.A), new Product(SKUId.A), new Product(SKUId.A), new Product(SKUId.A),
                                                              new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B),
                                                              new Product(SKUId.C) });
            scenarioCOrder = new Order(3, new List<Product>() { new Product(SKUId.A), new Product(SKUId.A), new Product(SKUId.A),
                                                              new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B), new Product(SKUId.B),
                                                              new Product(SKUId.C),
                                                              new Product(SKUId.D)  });

            activePromotions = GetListOfActivePromotions();
        }

        [Test]
        public void GetTotalPriceOfProduct_WhenCalled_ReturnProductOfPrice_ScenarioAOrder()
        {
            Mock<IPromotionService> mockPromotionService = new Mock<IPromotionService>();
            IProductService productService = new ProductService();

            mockPromotionService.Setup(_ => _.GetListOfActivePromotions()).Returns(activePromotions);

            decimal expectedResult = 100;

            decimal actualResult = Program.GetTotalPriceOfProduct(scenarioAOrder, mockPromotionService.Object, productService);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetTotalPriceOfProduct_WhenCalled_ReturnProductOfPrice_ScenarioBOrder()
        {
            Mock<IPromotionService> mockPromotionService = new Mock<IPromotionService>();
            IProductService productService = new ProductService();

            mockPromotionService.Setup(_ => _.GetListOfActivePromotions()).Returns(activePromotions);

            decimal expectedResult = 370;

            decimal actualResult = Program.GetTotalPriceOfProduct(scenarioBOrder, mockPromotionService.Object, productService);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetTotalPriceOfProduct_WhenCalled_ReturnProductOfPrice_ScenarioCOrder()
        {
            Mock<IPromotionService> mockPromotionService = new Mock<IPromotionService>();
            IProductService productService = new ProductService();

            mockPromotionService.Setup(_ => _.GetListOfActivePromotions()).Returns(activePromotions);

            decimal expectedResult = 280;

            decimal actualResult = Program.GetTotalPriceOfProduct(scenarioCOrder, mockPromotionService.Object, productService);

            Assert.AreEqual(expectedResult, actualResult);
        }

        private List<Promotion> GetListOfActivePromotions()
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
