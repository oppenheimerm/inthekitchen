using ITK.UseCases.Interfaces;
using ITK.UseCases.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        private readonly IViewProductsByFilterUseCase viewProductsByFilterUseCase;
        public ProductsGridViewComponent(IViewProductsByFilterUseCase viewProductsByFilterUseCase)
        {
            this.viewProductsByFilterUseCase= viewProductsByFilterUseCase;
        }

        //public async Task<IViewComponentResult> InvokeAsync()
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var products = await viewProductsByFilterUseCase.Execute(/*filter*/).Products
                .OrderBy(x => x.DateAdded).ToListAsync();
                return View(products);
        }
    }
}
