
using System.Security.Claims;
using Tom_s_E_shop.Models;

namespace Tom_s_E_shop.Helper
{
    public abstract class BaseViewPage<TModel> : Microsoft.AspNetCore.Mvc.Razor.RazorPage<TModel>
    {

        public UserModel CurrentUser { 
            get { 
                if (User.Identity.IsAuthenticated) 
                {
                    var userData = Context.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.UserData);
                    if (userData != null) {
                        return System.Text.Json.JsonSerializer.Deserialize<UserModel>(userData.Value);
                    }                    
                }
                return null;
            } 
        }
       
    }
}
