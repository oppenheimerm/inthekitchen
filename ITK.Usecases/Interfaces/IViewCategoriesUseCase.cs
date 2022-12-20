using ITK.Core;

namespace ITK.UseCases.Interfaces
{
    public interface IViewCategoriesUseCase
    {
        Task<IQueryable<Category>> ExecuteAsync();
    }
}