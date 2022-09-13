using Microsoft.AspNetCore.Mvc;
using Common.ServiceResponse;

namespace Application.Interfaces.Server.Product
{
    public interface IProductService
    {
        Task<ResultDto<List<Domain.Entities.Products.Product>>> GetProductsAsync();
        Task<ResultDto<Domain.Entities.Products.Product>> GetProductAsync(int productId);
        Task<ResultDto<List<Domain.Entities.Products.Product>>> GetProductsByCategory(string categoryUrl);
        Task<ResultDto<Domain.Entities.Products.ProductSearchResult>> SearchProducts(string searchText, int page);
        Task<ResultDto<List<string>>> GetProductSearchSuggestions(string searchText);
        Task<ResultDto<List<Domain.Entities.Products.Product>>> GetFeaturedProducts();
    }
}
