using Humanizer;
using ITK.UseCases;
using ITK.UseCases.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyModel;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
namespace ITK.Web.ViewComponents
{
    //  This is the code part of the ProductsGridViewComponent.It makes use of
    //  the ViewCategoriesUseCase via dependency injection system to resolve
    //  the implementation of IViewCategoryUseCase which procided dependency
    //  injection of ICategoryRepositorywhich and is injected into the constructor
    //  of the view component class. The InvokeAsync method obtains a
    //  List<Category> from the service and passes it to the view.
    [ViewComponent]
    public class ProductsGridViewComponent : ViewComponent
    {
        private readonly IViewCategoriesUseCase viewCategoriesUseCase;
        public ProductsGridViewComponent(IViewCategoriesUseCase viewCategoriesUseCase)
        {
            this.viewCategoriesUseCase = viewCategoriesUseCase;
        }

        //public async Task<IViewComponentResult> InvokeAsync()
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await viewCategoriesUseCase.Execute()
                .OrderBy(x => x.Title).ToListAsync();
            return View(categories);
        }
    }
}
