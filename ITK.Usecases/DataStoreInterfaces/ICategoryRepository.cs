using ITK.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK.UseCases.DataStoreInterfaces
{
    public interface ICategoryRepository
    {
        Task AddCategoryAsync(Category category);
        Task UpdateCategoryAsync(Category category);
        Task<IQueryable<Category>> GetAllGategoriesAsync();
    }
}
