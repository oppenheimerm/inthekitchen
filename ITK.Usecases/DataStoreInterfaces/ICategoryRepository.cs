using ITK.Core;
using ITK.UseCases.Response.CategoryResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITK.UseCases.DataStoreInterfaces
{
    public interface ICategoryRepository
    {
        Task<AddUpdateCategoryResponse> AddCategoryAsync(Category category);
        Task<AddUpdateCategoryResponse> UpdateCategoryAsync(Category category);
        CategoryQueryResponse GetAllCategories();
    }
}
