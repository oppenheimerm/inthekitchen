using ITK.Core;
using ITK.UseCases.DataStoreInterfaces;
using ITK.UseCases.Response.CategoryResponse;
using ITK.UseCases.Response.PoductResponse;
using Microsoft.EntityFrameworkCore;

namespace ITK.DataStore.EFCore.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ITKDbContext context;

        public ProductsRepository(ITKDbContext context)
        {
            this.context = context;
        }

        public async Task<AddUpdateProductResponse> AddProductAsync(Product product)
        {
            AddUpdateProductResponse addUpdateProductResponse = new();

            try
            {
                await context.AddAsync(product);
                await context.SaveChangesAsync();
                addUpdateProductResponse.Success = true;
                addUpdateProductResponse.Product = product;
                return addUpdateProductResponse;
            }catch(Exception ex) { 
                addUpdateProductResponse.Success = false;
                addUpdateProductResponse.ErrorMessage = ex.Message;
                return addUpdateProductResponse;
            }
          
        }

        public ProductQueryResponse GetAllProducts()
        {
            ProductQueryResponse productQueryResponse= new();

            try {
                productQueryResponse.Products = context.Products.OrderBy(x => x.DateAdded).AsQueryable();
                productQueryResponse.Success = true;
                return productQueryResponse;
            }
            catch (Exception ex)
            {
                productQueryResponse.Success = false;
                productQueryResponse.ErrorMessage = ex.Message;
                return productQueryResponse;
            }
        }

        public async Task<AddUpdateProductResponse> UpdateProductAsync(Product product)
        {
            AddUpdateProductResponse addUpdateProductResponse = new();

            var item = await context.Products.FirstOrDefaultAsync(x => x.Id == product.Id);
            if (item != null)
            {
                try {
                    // Use automapper later
                    //  The Id we don't update
                    item.Title = product.Title;
                    item.Description = product.Description;
                    item.Price = product.Price;
                    item.StockQuantity= product.StockQuantity;
                    item.Image= product.Image;
                    item.CategoryId= product.CategoryId;
                    item.EditorsNote= product.EditorsNote;
                    await context.SaveChangesAsync();
                    addUpdateProductResponse.Success = true;
                    addUpdateProductResponse.Product = product;
                    return addUpdateProductResponse;
                }
                catch(Exception ex) { 
                    addUpdateProductResponse.Success = false;
                    addUpdateProductResponse.ErrorMessage = ex.Message;
                    return addUpdateProductResponse;
                }
            }
            else
            {
                addUpdateProductResponse.Success = false;
                addUpdateProductResponse.ErrorMessage = $"Product with Id: { product.Id.ToString()} not found";
                return addUpdateProductResponse;
            }
        }
    }
}
