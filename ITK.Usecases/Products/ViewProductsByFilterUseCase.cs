using ITK.Core;
using ITK.UseCases.DataStoreInterfaces;
using ITK.UseCases.Interfaces;
using ITK.UseCases.Response.PoductResponse;

namespace ITK.UseCases.Products
{
    public class ViewProductsByFilterUseCase : IViewProductsByFilterUseCase
    {
        private readonly IProductsRepository productsRepository;

        public ViewProductsByFilterUseCase(IProductsRepository productsRepository)
        {
            this.productsRepository = productsRepository;
        }

        public ProductQueryResponse Execute()
        {
            return productsRepository.GetAllProducts();
        }
    }
}
