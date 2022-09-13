using Application.Interfaces.Client.Product;
using Common.ServiceResponse;
using Domain.Entities.Products;
using System.Net.Http.Json;

namespace Application.Services.Client.Product
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _http;

        public ProductService(HttpClient http)
        {
            _http = http;
        }

        //eshkl
        public List<Domain.Entities.Products.Product> Products { get; set; } = new List<Domain.Entities.Products.Product>();
        public string Message { get; set; } = "Loading products...";
        public int CurrentPage { get; set; } = 1;
        public int PageCount { get; set; } = 0;
        public string LastSearchText { get; set; } = string.Empty;

        public event Action ProductsChanged;

        public async Task<ResultDto<Domain.Entities.Products.Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ResultDto<Domain.Entities.Products.Product>>($"api/product/{productId}");
            return result;
        }

        public async Task GetProducts()
        {
            var result = await _http.GetFromJsonAsync<ResultDto<List<Domain.Entities.Products.Product>>>("api/product");
            if(result != null && result.Data != null)
            {
                Products = result.Data;
            }
        }

        public async Task GetProducts(string? categoryUrl = null)
        {
            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ResultDto<List<Domain.Entities.Products.Product>>>("api/product/featured") :
                await _http.GetFromJsonAsync<ResultDto<List<Domain.Entities.Products.Product>>>($"api/product/category/{categoryUrl}");
            if (result != null && result.Data != null)
                Products = result.Data;

            CurrentPage = 1;
            PageCount = 0;

            if (Products.Count == 0)
                Message = "No products found";

            ProductsChanged.Invoke();
        }

        public string GetPriceText(Domain.Entities.Products.Product product)
        {
            var variants = product.Variants;
            if (variants.Count == 0)
            {
                return string.Empty;
            }
            else if (variants.Count == 1)
            {
                return $"${variants[0].Price}";
            }
            decimal minPrice = variants.Min(v => v.Price);
            return $"Starting at ${minPrice}";
        }

        public async Task<List<string>> GetProductSearchSuggestions(string searchText)
        {
            var result = await _http
                .GetFromJsonAsync<ResultDto<List<string>>>($"api/product/searchsuggestions/{searchText}");
            return result.Data;
        }

        public async Task SearchProducts(string searchText, int page)
        {
            LastSearchText = searchText;
            var result = await _http
                 .GetFromJsonAsync<ResultDto<ProductSearchResult>>($"api/product/search/{searchText}/{page}");
            if (result != null && result.Data != null)
            {
                Products = result.Data.Products;
                CurrentPage = result.Data.CurrentPage;
                PageCount = result.Data.Pages;
            }
            if (Products.Count == 0) Message = "No products found.";
            ProductsChanged?.Invoke();
        }
    }
}
