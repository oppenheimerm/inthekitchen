using ITK.Core;
using ITK.UseCases.Response.PoductResponse;

namespace ITK.UseCases.Interfaces
{
    public interface IViewProductsByFilterUseCase
    {
        ProductQueryResponse Execute();
    }
}