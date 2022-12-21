using ITK.Core;
using ITK.UseCases.DataStoreInterfaces;
using ITK.UseCases.Response.CategoryResponse;
using Microsoft.EntityFrameworkCore;

namespace ITK.DataStore.EFCore.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ITKDbContext context;

        public CategoryRepository(ITKDbContext context)
        {
            this.context = context;
        }

        public async Task<AddUpdateCategoryResponse> AddCategoryAsync(Category category)
        {
            AddUpdateCategoryResponse addCategoryResponse = new();

            if (context.Categories.Any(x => x.Code.Equals(category.Code, StringComparison.OrdinalIgnoreCase)))
            {
                addCategoryResponse.Success = false;
                addCategoryResponse.ErrorMessage  = $"CategoryCode {category.Code} already in use";
                return addCategoryResponse;
            }

            var maxId = context.Categories.Max(x => x.Id);
            category.Id = maxId + 1;
            try
            {
                await context.AddAsync(category);
                await context.SaveChangesAsync();
                addCategoryResponse.Success = true;
                addCategoryResponse.Category = category;
                return addCategoryResponse;
            }
            catch (Exception ex)
            {
                addCategoryResponse.Success = false;
                addCategoryResponse.ErrorMessage = ex.Message;
                return addCategoryResponse;
            }
        }

        public CategoryQueryResponse GetAllCategories()
        {
            CategoryQueryResponse categoryQueryResponse = new();

            //  Use .AsQuerable() as opposed to ToList() - which will just creates
            //  the query.
            try
            {
                categoryQueryResponse.Categories = context.Categories.AsQueryable();
                categoryQueryResponse.Success = true;
                return categoryQueryResponse;

            }catch(Exception ex)
            {
                categoryQueryResponse.Success = false;
                categoryQueryResponse.ErrorMessage = ex.Message;
                return categoryQueryResponse;
            }
            
        }

        public async Task<AddUpdateCategoryResponse> UpdateCategoryAsync(Category category)
        {
            AddUpdateCategoryResponse addUpdateCategoryResponse = new();

            var item = await context.Categories.FirstOrDefaultAsync(x => x.Id == category.Id);
            if (item != null)
            {
                try
                {
                    // Use automapper later
                    //  The Id we don't update
                    item.Title = category.Title;
                    item.Code = category.Code;
                    await context.SaveChangesAsync();
                    addUpdateCategoryResponse.Success = true;
                    addUpdateCategoryResponse.Category = category;
                    return addUpdateCategoryResponse;
                }catch(Exception ex)
                {
                    addUpdateCategoryResponse.Success = false;
                    addUpdateCategoryResponse.ErrorMessage = ex.Message;
                    return addUpdateCategoryResponse;
                }
            }
            else
            {
                addUpdateCategoryResponse.Success = false;
                addUpdateCategoryResponse.ErrorMessage = $"Category with Id: {category.Id.ToString()} not found";
                return addUpdateCategoryResponse;
            }
        }
    }
}
