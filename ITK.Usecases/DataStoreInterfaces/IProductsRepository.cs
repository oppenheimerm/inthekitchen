using ITK.Core;
using ITK.UseCases.Response.PoductResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK.UseCases.DataStoreInterfaces
{
    public interface IProductsRepository
    {
        Task<AddUpdateProductResponse> AddProductAsync(Product product);

        Task<AddUpdateProductResponse> UpdateProductAsync(Product product);

        ProductQueryResponse GetAllProducts();
    }
}
