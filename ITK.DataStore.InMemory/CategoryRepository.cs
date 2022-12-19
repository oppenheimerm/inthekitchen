using ITK.Core;
using ITK.UseCases.DataStoreInterfaces;
using System.Linq;

namespace ITK.DataStore.InMemory
{
    public class CategoryRepository : ICategoryRepository
    {
        private List<Category> _categories;

        public CategoryRepository()
        {
            //  create the test data in arrays rather than List<T> collections
            //  to optimize performance, for ef init.
            _categories = new List<Category>()
            {
                new Category { Id = 1000, Title = "Cook", Code = "COOK" },
                new Category { Id = 1001, Title = "Clean", Code = "CLEN" },
                new Category { Id = 1002, Title = "Bake", Code = "BAKE" },
                new Category { Id = 1003, Title = "Food Prep", Code = "FPRP" },
                new Category { Id = 1004, Title = "Drink", Code = "DRNK" },
                new Category { Id = 1005, Title = "Cookware", Code = "CKWR" },
                new Category { Id = 1006, Title = "Cook Books", Code = "CKBK" },
                new Category { Id = 1007, Title = "Cooking Utensils", Code = "COUT"},
                new Category { Id = 1008, Title = "Organization & Storage", Code = "ONSE"}
            };
        }

        public Task AddCategoryAsync(Category category)
        {
            //  Prevent duplicate
            if (_categories.Any(x => x.Code.Equals(category.Code, StringComparison.OrdinalIgnoreCase)))
                return Task.CompletedTask;

            var maxId = _categories.Max(x => x.Id);
            category.Id = maxId + 1;

            _categories.Add(category);

            return Task.CompletedTask;
        }


        public Task UpdateCategoryAsync(Category category)
        {
            var item = _categories.FirstOrDefault(x => x.Id == category.Id);
            if (item != null)
            {
                // Use automapper later
                //  The Id we don't update
                item.Title = category.Title;
                item.Code = category.Code;
            }

            return Task.CompletedTask;
        }

        public async Task<IQueryable<Category>> GetAllGategoriesAsync()
        {
            //  Use .AsQuerable() as opposed to ToList() - which will just creates the query.
            var categories = _categories.AsQueryable();

            return await Task.FromResult(categories);

        }

    }
}