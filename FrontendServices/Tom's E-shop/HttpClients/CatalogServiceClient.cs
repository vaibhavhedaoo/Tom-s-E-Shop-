using Tom_s_E_shop.Models;

namespace Tom_s_E_shop.HttpClients
{
    public class CatalogServiceClient
    {
        private readonly HttpClient _httpClient;
        public CatalogServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductModel>?> GetProductsAsync()
        {
            var result = await _httpClient.GetAsync("Catalog/GetProducts");
            if (result.IsSuccessStatusCode)
            {
                var products = await result.Content.ReadFromJsonAsync<IEnumerable<ProductModel>>();
                return products;
            }
            return null;
        }
    }
}
