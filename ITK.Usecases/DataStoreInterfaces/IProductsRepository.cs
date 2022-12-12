using ITK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK.UseCases.DataStoreInterfaces
{
    public interface IProductsRepository
    {
        Task AddProductAsync(Product product);

        Task UpdateProductAsync(Product product);

        Task<IQueryable<Product>> GetAllProductsAsync();
    }
}
