
using IdentityCatalog.Models;

namespace IdentityCatalog.Repositories
{
    public class CategoryRepository
    {

        private readonly ApplicationDbContext context;
        public CategoryRepository() {
            this.context = new ApplicationDbContext();
        }

        public List<Category> AllCategories()
        {
            var categories = context.Categories.ToList();
            return categories;

        }
    }
}
