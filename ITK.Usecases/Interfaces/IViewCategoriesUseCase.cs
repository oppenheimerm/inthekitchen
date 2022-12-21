using ITK.Core;

namespace ITK.UseCases.Interfaces
{
    public interface IViewCategoriesUseCase
    {
        IQueryable<Category> Execute();
    }
}