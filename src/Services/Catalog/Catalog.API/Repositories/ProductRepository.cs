namespace Catalog.API.Repositories
{
    using Catalog.API.Entities;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class ProductRepository : IProductRepository
    {
        public Task CreateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteProduct(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Product> GetProduct(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductByCategory(string categoryName)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProducts()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
