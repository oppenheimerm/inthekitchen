using ITK.Core;

namespace ITK.UseCases.Response.CategoryResponse
{
    public class CategoryQueryResponse : BaseUseCaseResponse
    {
        public IQueryable<Category>? Categories { get; set; }
    }
}
