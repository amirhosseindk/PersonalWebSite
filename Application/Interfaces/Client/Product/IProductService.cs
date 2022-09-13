using Common.ServiceResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Client.Product
{
    public interface IProductService
    {
        event Action ProductsChanged;
        List<Domain.Entities.Products.Product> Products { get; set; }
        Task GetProducts();
        Task<ResultDto<Domain.Entities.Products.Product>> GetProduct(int productId);
        Task GetProducts(string? categoryUrl = null);
        string GetPriceText(Domain.Entities.Products.Product product);
        string Message { get; set; }
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        string LastSearchText { get; set; }
        Task SearchProducts(string searchText, int page);
        Task<List<string>> GetProductSearchSuggestions(string searchText);
    }
}
