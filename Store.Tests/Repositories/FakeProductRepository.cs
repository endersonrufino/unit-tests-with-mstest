using Store.Domain.Entities;
using Store.Domain.Repositories;

namespace Store.Tests.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProduct(IEnumerable<Guid> ids)
        {
           IList<Product> products = new List<Product>();
           products.Add(new Product("Product 1", 10, true, Guid.NewGuid()));
           products.Add(new Product("Product 2", 11, true, Guid.NewGuid()));
           products.Add(new Product("Product 3", 12, true, Guid.NewGuid()));
           products.Add(new Product("Product 4", 13, false, Guid.NewGuid()));
           products.Add(new Product("Product 5", 14, false, Guid.NewGuid()));

           return products;
        }
    }
}