using Store.Domain.Entities;
using Store.Domain.Queries;


namespace Store.Tests.Queries
{
    public class ProductQueriesTests
    {
        private IList<Product> _products;

        public ProductQueriesTests()
        {
            _products = new List<Product>();

            _products.Add(new Product("Product 1", 10, true, Guid.NewGuid()));
            _products.Add(new Product("Product 2", 20, true, Guid.NewGuid()));
            _products.Add(new Product("Product 3", 30, true, Guid.NewGuid()));
            _products.Add(new Product("Product 4", 40, false, Guid.NewGuid()));
            _products.Add(new Product("Product 5", 50, false, Guid.NewGuid()));
        }

        [TestMethod]
        [TestCategory("Queries")]
        public void Dado_a_consulta_de_produtos_ativos_deve_retornar_3()
        {
            var activeProducts = _products.AsQueryable().Where(ProductQueries.GetActiveProducts());

            Assert.AreEqual(activeProducts.Count(), 3);
        }

        [TestMethod]
        [TestCategory("Queries")]
        public void Dado_a_consulta_de_produtos_inativos_deve_retornar_2()
        {
             var activeProducts = _products.AsQueryable().Where(ProductQueries.GetInactiveProducts());

            Assert.AreEqual(activeProducts.Count(), 2);
        }
    }
}