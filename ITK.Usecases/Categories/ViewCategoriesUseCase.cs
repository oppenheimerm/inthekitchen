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

        public async Task<IQueryable<Category>> ExecuteAsync()
        {
            return await categoryRepository.GetAllGategoriesAsync();
        }
    }
}