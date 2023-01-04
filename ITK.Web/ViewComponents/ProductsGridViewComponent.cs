using Microsoft.AspNetCore.Mvc;
using ITK.Core;
using ITK.UseCases.Utilities;
using ITK.UseCases.Products;
using ITK.Web.Pages;
using ITK.UseCases.Interfaces;
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
        private IViewProductsByFilterUseCase ViewProductsByFilterUseCase { get; }
        private readonly ILogger<IndexModel> _logger;
        public PaginatedList<Product> Products { get; set; }
        private IConfiguration Configuration { get; }
        public int? PageIndex { get; set; }

        public ProductsGridViewComponent(
            IConfiguration configuration, 
            ILogger<IndexModel> logger,
            IViewProductsByFilterUseCase viewProductsByFilterUseCase)
        {
            Configuration = configuration;
            _logger = logger;
            ViewProductsByFilterUseCase = viewProductsByFilterUseCase;
        }

        public async Task<IViewComponentResult> InvokeAsync(
            int? pageIndex
            )
        {
            PageIndex = pageIndex;
            await GetDataAsync();

            return View(Products);
        }

        public async Task GetDataAsync()
        {
            if (PageIndex == null || !PageIndex.HasValue)
            {
                PageIndex = 1;
            }

            var pageSize = Configuration.GetValue("PageSize", 15);
            Products = await PaginatedList<Product>.CreateAsync(
                ViewProductsByFilterUseCase.Execute().Products.AsNoTracking(),
                PageIndex ?? 1, pageSize
                );
        }
    }
}