using IdentityCatalog.Models;

namespace IdentityCatalog.Repositories
{
    public class ProductRepository
    {
        private readonly ApplicationDbContext context;
        public ProductRepository()
        {
            context = new ApplicationDbContext();
        }

        public List<Product> GetAllProducts()
        {
            var products = context.Products.ToList();
            return products;
        }
    }
}
