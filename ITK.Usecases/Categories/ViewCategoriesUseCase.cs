using ITK.Core;
using ITK.UseCases.DataStoreInterfaces;
using ITK.UseCases.Interfaces;

namespace ITK.UseCases.Categories
{
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository categoryRepository;

        public ViewCategoriesUseCase(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IQueryable<Category> Execute()
        {
            //  Remember here GetAllCategories is IQuerable, that is,
            //  it's has not executed anything on the db. until we 
            //  execute "ToList()" or similar
            return categoryRepository.GetAllCategories().Categories;
        }
    }
}