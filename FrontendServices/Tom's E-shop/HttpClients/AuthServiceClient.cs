using Tom_s_E_shop.Models;

namespace Tom_s_E_shop.HttpClients
{
    public class AuthServiceClient
    {
        private readonly HttpClient _httpClient;
        public AuthServiceClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public UserModel Login(LoginModel loginModel)
        {
            var result = _httpClient.PostAsJsonAsync("Auth/Login", loginModel).Result;
            if (result.IsSuccessStatusCode)
            {
                var user = result.Content.ReadFromJsonAsync<UserModel>().Result;
                return user;

            }
            return null;
        }
    }
}
