

using ITK.Core;

namespace ITK.UseCases.Response.PoductResponse
{
    public class ProductQueryResponse : BaseUseCaseResponse
    {
        public IQueryable<Product>? Products { get; set; }
    }
}
