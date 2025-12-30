├── FrontendServices
    └── Tom's E-shop
    │   ├── Views
    │       ├── _ViewStart.cshtml
    │       ├── Account
    │       │   ├── UnAuthorize.cshtml
    │       │   └── Login.cshtml
    │       ├── Home
    │       │   ├── Privacy.cshtml
    │       │   └── Index.cshtml
    │       ├── _ViewImports.cshtml
    │       └── Shared
    │       │   ├── _ValidationScriptsPartial.cshtml
    │       │   ├── Error.cshtml
    │       │   ├── _Layout.cshtml.css
    │       │   └── _Layout.cshtml
    │   ├── Areas
    │       └── User
    │       │   ├── Views
    │       │       ├── _ViewStart.cshtml
    │       │       ├── Home
    │       │       │   └── Index.cshtml
    │       │       ├── _ViewImports.cshtml
    │       │       └── Shared
    │       │       │   ├── _ValidationScriptsPartial.cshtml
    │       │       │   ├── Error.cshtml
    │       │       │   ├── _Layout.cshtml.css
    │       │       │   └── _Layout.cshtml
    │       │   └── Controllers
    │       │       ├── BaseController.cs
    │       │       └── HomeController.cs
    │   ├── wwwroot
    │       ├── favicon.ico
    │       ├── js
    │       │   └── site.js
    │       ├── lib
    │       │   ├── jquery
    │       │   │   └── LICENSE.txt
    │       │   ├── jquery-validation
    │       │   │   ├── LICENSE.md
    │       │   │   └── dist
    │       │   │   │   └── additional-methods.min.js
    │       │   ├── bootstrap
    │       │   │   ├── LICENSE
    │       │   │   └── dist
    │       │   │   │   └── css
    │       │   │   │       ├── bootstrap-reboot.min.css
    │       │   │   │       ├── bootstrap-reboot.rtl.min.css
    │       │   │   │       ├── bootstrap-reboot.rtl.css
    │       │   │   │       └── bootstrap-reboot.css
    │       │   └── jquery-validation-unobtrusive
    │       │   │   ├── LICENSE.txt
    │       │   │   └── dist
    │       │   │       ├── jquery.validate.unobtrusive.min.js
    │       │   │       └── jquery.validate.unobtrusive.js
    │       └── css
    │       │   └── site.css
    │   ├── appsettings.Development.json
    │   ├── appsettings.json
    │   ├── Models
    │       ├── ErrorViewModel.cs
    │       ├── UserModel.cs
    │       ├── ProductModel.cs
    │       ├── LoginModel.cs
    │       └── SignUpModel.cs
    │   ├── Tom's E-shop.csproj
    │   ├── Properties
    │       └── launchSettings.json
    │   ├── HttpClients
    │       ├── AuthServiceClient.cs
    │       └── CatalogServiceClient.cs
    │   ├── Helper
    │       ├── BaseViewPage.cs
    │       └── CustomAuthorize.cs
    │   ├── Controllers
    │       ├── HomeController.cs
    │       └── AccountController.cs
    │   └── Program.cs
├── CatalogService.API
    ├── appsettings.Development.json
    ├── CatalogService.API.http
    ├── Program.cs
    ├── appsettings.json
    ├── CatalogService.API.csproj
    ├── Properties
    │   └── launchSettings.json
    └── Controllers
    │   ├── ProductController.cs
    │   └── CatalogController.cs
├── ApiGateways
    └── OcelotAPIGateway
    │   ├── appsettings.Development.json
    │   ├── appsettings.json
    │   ├── ocelot.http
    │   ├── OcelotAPIGateway.csproj
    │   ├── Program.cs
    │   ├── Properties
    │       └── launchSettings.json
    │   ├── ocelot.json
    │   └── ocelot.dev.json
├── BackendServices
    ├── AuthService
    │   ├── AuthService.API
    │   │   ├── appsettings.Development.json
    │   │   ├── AuthService.API.http
    │   │   ├── WeatherForecast.cs
    │   │   ├── appsettings.json
    │   │   ├── Program.cs
    │   │   ├── AuthService.API.csproj
    │   │   ├── Properties
    │   │   │   └── launchSettings.json
    │   │   └── Controllers
    │   │   │   ├── WeatherForecastController.cs
    │   │   │   └── AuthController.cs
    │   ├── AuthService.Domain
    │   │   ├── AuthService.Domain.csproj
    │   │   ├── Interfaces
    │   │   │   └── IUserRepository.cs
    │   │   ├── Entities
    │   │   │   ├── Role.cs
    │   │   │   └── User.cs
    │   │   └── efpt.config.json
    │   ├── AuthService.Application
    │   │   ├── DTOs
    │   │   │   ├── LoginDTO.cs
    │   │   │   ├── UserDTO.cs
    │   │   │   └── SignUpDTO.cs
    │   │   ├── Interfaces
    │   │   │   └── IUserAppService.cs
    │   │   ├── Mapings
    │   │   │   └── AuthRegister.cs
    │   │   ├── AuthService.Application.csproj
    │   │   └── Services
    │   │   │   └── UserAppServices.cs
    │   └── AuthService.Infrastructure
    │   │   ├── AuthService.Infrastructure.csproj
    │   │   ├── Presistance
    │   │       ├── Repositories
    │   │       │   └── UserRepository.cs
    │   │       └── AuthServiceContext.cs
    │   │   ├── ServiceRegistration.cs
    │   │   └── efpt.config.json
    └── CatalogService
    │   ├── CatalogService.API
    │       ├── appsettings.Development.json
    │       ├── CatalogService.API.http
    │       ├── appsettings.json
    │       ├── Program.cs
    │       ├── CatalogService.API.csproj
    │       ├── Properties
    │       │   └── launchSettings.json
    │       └── Controllers
    │       │   ├── ProductController.cs
    │       │   └── CatalogController.cs
    │   ├── CatalogService.Domain
    │       ├── CatalogService.Domain.csproj
    │       ├── Entities
    │       │   ├── Category.cs
    │       │   └── Product.cs
    │       ├── Interfaces
    │       │   └── IProductRepository.cs
    │       └── efpt.config.json
    │   ├── CatalogService.Application
    │       ├── Mapings
    │       │   └── CatalogRegister.cs
    │       ├── Interfaces
    │       │   └── IProductAppService.cs
    │       ├── DTOs
    │       │   └── ProductDTO.cs
    │       ├── CatalogService.Application.csproj
    │       └── Services
    │       │   └── ProductAppService.cs
    │   └── CatalogService.Infrastructure
    │       ├── CatalogService.Infrastructure.csproj
    │       ├── Persistance
    │           ├── CatalogServiceContext.cs
    │           └── Repositories
    │           │   └── ProductRepository.cs
    │       ├── ServiceRegistration.cs
    │       └── efpt.config.json
├── Tom's E--Shop.slnx
├── .gitattributes
└── .gitignore


/FrontendServices/Tom's E-shop/Views/_ViewStart.cshtml:
--------------------------------------------------------------------------------
1 | @{
2 |     Layout = "_Layout";
3 | }
4 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Areas/User/Views/_ViewStart.cshtml:
--------------------------------------------------------------------------------
1 | @{
2 |     Layout = "_Layout";
3 | }
4 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Areas/User/Views/Home/Index.cshtml:
--------------------------------------------------------------------------------
1 | 
2 | @{
3 |     ViewData["Title"] = "Index";
4 | }
5 | 
6 | <h1>User Dashboard</h1>
7 | 
8 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Views/Account/UnAuthorize.cshtml:
--------------------------------------------------------------------------------
1 | 
2 | @{
3 |     ViewData["Title"] = "UnAuthorize";
4 | }
5 | 
6 | <h1>UnAuthorize</h1>
7 | 
8 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/favicon.ico:
--------------------------------------------------------------------------------
https://raw.githubusercontent.com/vaibhavhedaoo/Tom-s-E-Shop-/HEAD/FrontendServices/Tom's E-shop/wwwroot/favicon.ico


--------------------------------------------------------------------------------
/CatalogService.API/appsettings.Development.json:
--------------------------------------------------------------------------------
1 | {
2 |   "Logging": {
3 |     "LogLevel": {
4 |       "Default": "Information",
5 |       "Microsoft.AspNetCore": "Warning"
6 |     }
7 |   }
8 | }
9 | 


--------------------------------------------------------------------------------
/ApiGateways/OcelotAPIGateway/appsettings.Development.json:
--------------------------------------------------------------------------------
1 | {
2 |   "Logging": {
3 |     "LogLevel": {
4 |       "Default": "Information",
5 |       "Microsoft.AspNetCore": "Warning"
6 |     }
7 |   }
8 | }
9 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/appsettings.Development.json:
--------------------------------------------------------------------------------
1 | {
2 |   "Logging": {
3 |     "LogLevel": {
4 |       "Default": "Information",
5 |       "Microsoft.AspNetCore": "Warning"
6 |     }
7 |   }
8 | }
9 | 


--------------------------------------------------------------------------------
/CatalogService.API/CatalogService.API.http:
--------------------------------------------------------------------------------
1 | @CatalogService.API_HostAddress = https://localhost:7049/api
2 | 
3 | GET {{CatalogService.API_HostAddress}}/Catalog/GetProducts
4 | Accept: application/json
5 | 
6 | ###
7 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Views/Home/Privacy.cshtml:
--------------------------------------------------------------------------------
1 | @{
2 |     ViewData["Title"] = "Privacy Policy";
3 | }
4 | <h1>@ViewData["Title"]</h1>
5 | 
6 | <p>Use this page to detail your site's privacy policy.</p>
7 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.API/appsettings.Development.json:
--------------------------------------------------------------------------------
1 | {
2 |   "Logging": {
3 |     "LogLevel": {
4 |       "Default": "Information",
5 |       "Microsoft.AspNetCore": "Warning"
6 |     }
7 |   }
8 | }
9 | 


--------------------------------------------------------------------------------
/ApiGateways/OcelotAPIGateway/appsettings.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "Logging": {
 3 |     "LogLevel": {
 4 |       "Default": "Information",
 5 |       "Microsoft.AspNetCore": "Warning"
 6 |     }
 7 |   },
 8 |   "AllowedHosts": "*"
 9 | }
10 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.API/appsettings.Development.json:
--------------------------------------------------------------------------------
1 | {
2 |   "Logging": {
3 |     "LogLevel": {
4 |       "Default": "Information",
5 |       "Microsoft.AspNetCore": "Warning"
6 |     }
7 |   }
8 | }
9 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Views/_ViewImports.cshtml:
--------------------------------------------------------------------------------
1 | @using Tom_s_E_shop
2 | @using Tom_s_E_shop.Helper
3 | @using Tom_s_E_shop.Models
4 | @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
5 | @inherits BaseViewPage<TModel>;
6 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.API/CatalogService.API.http:
--------------------------------------------------------------------------------
1 | @CatalogService.API_HostAddress = https://localhost:7231
2 | 
3 | GET {{CatalogService.API_HostAddress}}/catalog/getall
4 | Accept: application/json
5 | 
6 | ###
7 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Areas/User/Views/_ViewImports.cshtml:
--------------------------------------------------------------------------------
1 | @using Tom_s_E_shop
2 | @using Tom_s_E_shop.Helper
3 | @using Tom_s_E_shop.Models
4 | @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
5 | @inherits BaseViewPage<TModel>;
6 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Views/Shared/_ValidationScriptsPartial.cshtml:
--------------------------------------------------------------------------------
1 | <script src="~/lib/jquery-validation/dist/jquery.validate.min.js"></script>
2 | <script src="~/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js"></script>
3 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Areas/User/Views/Shared/_ValidationScriptsPartial.cshtml:
--------------------------------------------------------------------------------
1 | <script src="~/lib/jquery-validation/dist/jquery.validate.min.js"></script>
2 | <script src="~/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js"></script>
3 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/appsettings.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "Logging": {
 3 |     "LogLevel": {
 4 |       "Default": "Information",
 5 |       "Microsoft.AspNetCore": "Warning"
 6 |     }
 7 |   },
 8 |   "AllowedHosts": "*",
 9 |   "ApiGatewayAddress": "https://localhost:7105"
10 | }
11 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/js/site.js:
--------------------------------------------------------------------------------
1 | // Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
2 | // for details on configuring this project to bundle and minify static web assets.
3 | 
4 | // Write your JavaScript code.
5 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Models/ErrorViewModel.cs:
--------------------------------------------------------------------------------
 1 | namespace Tom_s_E_shop.Models
 2 | {
 3 |     public class ErrorViewModel
 4 |     {
 5 |         public string? RequestId { get; set; }
 6 | 
 7 |         public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
 8 |     }
 9 | }
10 | 


--------------------------------------------------------------------------------
/ApiGateways/OcelotAPIGateway/ocelot.http:
--------------------------------------------------------------------------------
 1 | @Ocelot.HostAddress = https://localhost:7105
 2 | 
 3 | POST {{Ocelot.HostAddress}}/Auth/Login
 4 | Accept: application/json
 5 | Content-Type: application/json
 6 | 
 7 | {
 8 |   "email": "user@gmail.com",
 9 |   "password": "User@12345678"
10 | }
11 | ###


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Domain/AuthService.Domain.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net10.0</TargetFramework>
 5 |     <ImplicitUsings>enable</ImplicitUsings>
 6 |     <Nullable>enable</Nullable>
 7 |   </PropertyGroup>
 8 | 
 9 | </Project>
10 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Domain/CatalogService.Domain.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net10.0</TargetFramework>
 5 |     <ImplicitUsings>enable</ImplicitUsings>
 6 |     <Nullable>enable</Nullable>
 7 |   </PropertyGroup>
 8 | 
 9 | </Project>
10 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.API/AuthService.API.http:
--------------------------------------------------------------------------------
 1 | @AuthService.API_HostAddress = https://localhost:7029/api
 2 | 
 3 | POST {{AuthService.API_HostAddress}}/Auth/Login
 4 | Accept: application/json
 5 | Content-Type: application/json
 6 | {
 7 |   "email": "user@gmail.com",
 8 |   "password": "User@12345678"
 9 | }
10 | ###
11 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Areas/User/Controllers/BaseController.cs:
--------------------------------------------------------------------------------
 1 | using Microsoft.AspNetCore.Mvc;
 2 | using Tom_s_E_shop.Helper;
 3 | 
 4 | namespace Tom_s_E_shop.Areas.User.Controllers
 5 | {
 6 |     [CustomAuthorize(Roles = "User")]
 7 |     [Area("User")]
 8 |     public class BaseController : Controller
 9 |     {
10 |        
11 |     }
12 | }
13 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Areas/User/Controllers/HomeController.cs:
--------------------------------------------------------------------------------
 1 | using Microsoft.AspNetCore.Mvc;
 2 | 
 3 | namespace Tom_s_E_shop.Areas.User.Controllers
 4 | {
 5 |     public class HomeController : BaseController
 6 |     {
 7 |         public IActionResult Index()
 8 |         {
 9 |             return View();
10 |         }
11 |     }
12 | }
13 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Application/DTOs/LoginDTO.cs:
--------------------------------------------------------------------------------
 1 | using System;
 2 | using System.Collections.Generic;
 3 | using System.Text;
 4 | 
 5 | namespace AuthService.Application.DTOs
 6 | {
 7 |     public class LoginDTO
 8 |     {
 9 |         public string Email { get; set; }
10 |         public string Password { get; set; }
11 |     }
12 | }
13 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.API/WeatherForecast.cs:
--------------------------------------------------------------------------------
 1 | namespace AuthService.API
 2 | {
 3 |     public class WeatherForecast
 4 |     {
 5 |         public DateOnly Date { get; set; }
 6 | 
 7 |         public int TemperatureC { get; set; }
 8 | 
 9 |         public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
10 | 
11 |         public string? Summary { get; set; }
12 |     }
13 | }
14 | 


--------------------------------------------------------------------------------
/ApiGateways/OcelotAPIGateway/OcelotAPIGateway.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk.Web">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net10.0</TargetFramework>
 5 |     <Nullable>enable</Nullable>
 6 |     <ImplicitUsings>enable</ImplicitUsings>
 7 |   </PropertyGroup>
 8 | 
 9 |   <ItemGroup>
10 |     <PackageReference Include="Ocelot" Version="24.1.0" />
11 |   </ItemGroup>
12 | 
13 | </Project>
14 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Domain/Interfaces/IUserRepository.cs:
--------------------------------------------------------------------------------
 1 | using AuthService.Domain.Entities;
 2 | using System;
 3 | using System.Collections.Generic;
 4 | using System.Text;
 5 | 
 6 | namespace AuthService.Domain.Interfaces
 7 | {
 8 |     public interface IUserRepository
 9 |     {
10 |         bool RegisterUser(User user, string role);
11 |         User GetUserByEmail(string email);
12 |     }
13 | }
14 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Models/UserModel.cs:
--------------------------------------------------------------------------------
 1 | namespace Tom_s_E_shop.Models
 2 | {
 3 |     public class UserModel
 4 |     {
 5 |         public int UserId { get; set; }
 6 |         public string Name { get; set; }
 7 |         public string Email { get; set; }
 8 |         public string PhoneNumber { get; set; }
 9 |         public string[] Roles { get; set; }
10 |         public string Token { get; set; }
11 |     }
12 | }
13 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Application/Interfaces/IUserAppService.cs:
--------------------------------------------------------------------------------
 1 | using AuthService.Application.DTOs;
 2 | using System;
 3 | using System.Collections.Generic;
 4 | using System.Text;
 5 | 
 6 | namespace AuthService.Application.Interfaces
 7 | {
 8 |     public interface IUserAppService
 9 |     {
10 |         UserDTO LoginUser(LoginDTO loginDTO);
11 |         bool SignUpUser(SignUpDTO signUpDTO, string roles);
12 |     }
13 | }
14 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Application/DTOs/UserDTO.cs:
--------------------------------------------------------------------------------
 1 | namespace AuthService.Application.DTOs
 2 | {
 3 |     public class UserDTO
 4 |     {
 5 |         public int UserId { get; set; }
 6 |         public string Name { get; set; }        
 7 |         public string Email { get; set; }
 8 |         public string PhoneNumber { get; set; }
 9 |         public string[] Roles { get; set; }
10 |         public string Token { get; set; }
11 |     }
12 | }
13 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.API/appsettings.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "Logging": {
 3 |     "LogLevel": {
 4 |       "Default": "Information",
 5 |       "Microsoft.AspNetCore": "Warning"
 6 |     }
 7 |   },
 8 |   "AllowedHosts": "*",
 9 |     "ConnectionStrings": {
10 |       "DBConnection": "Server=LAPTOP-VAIBHAV;Database=TEShopCatalogService;User Id=Admin;Password=Vaibhav5822;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True;"
11 |     }
12 |   }
13 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Domain/Entities/Role.cs:
--------------------------------------------------------------------------------
 1 | // <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
 2 | #nullable disable
 3 | using System;
 4 | using System.Collections.Generic;
 5 | 
 6 | namespace AuthService.Domain.Entities;
 7 | 
 8 | public partial class Role
 9 | {
10 |     public int Id { get; set; }
11 | 
12 |     public string Name { get; set; }
13 | 
14 |     public virtual ICollection<User> Users { get; set; } = new List<User>();
15 | }


--------------------------------------------------------------------------------
/CatalogService.API/Program.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Infrastructure;
 2 | 
 3 | var builder = WebApplication.CreateBuilder(args);
 4 | 
 5 | ServiceRegistration.RegisterServices(builder.Services, builder.Configuration);
 6 | // Add services to the container.
 7 | 
 8 | builder.Services.AddControllers();
 9 | 
10 | var app = builder.Build();
11 | 
12 | // Configure the HTTP request pipeline.
13 | 
14 | app.UseHttpsRedirection();
15 | 
16 | app.UseAuthorization();
17 | 
18 | app.MapControllers();
19 | 
20 | app.Run();
21 | 


--------------------------------------------------------------------------------
/CatalogService.API/appsettings.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "Logging": {
 3 |     "LogLevel": {
 4 |       "Default": "Information",
 5 |       "Microsoft.AspNetCore": "Warning"
 6 |     }
 7 |   },
 8 |   "ImageServer": "https://tomseshopproductimages.s3.us-east-1.amazonaws.com",
 9 |   "AllowedHosts": "*",
10 |   "ConnectionStrings": {
11 |     "DBConnection": "Server=LAPTOP-VAIBHAV;Database=TEShopCatalogService;User Id=Admin;Password=Vaibhav5822;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True;"
12 |   }
13 | }
14 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Application/DTOs/SignUpDTO.cs:
--------------------------------------------------------------------------------
 1 | using System;
 2 | using System.Collections.Generic;
 3 | using System.Text;
 4 | 
 5 | namespace AuthService.Application.DTOs
 6 | {
 7 |     public class SignUpDTO
 8 |     {
 9 |         public string Name { get; set; }
10 | 
11 |         public string Email { get; set; }
12 | 
13 |         public string Password { get; set; }
14 | 
15 |         public string PhoneNumber { get; set; }
16 | 
17 |         public string Role { get; set; }
18 |     }
19 | }
20 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Domain/Entities/Category.cs:
--------------------------------------------------------------------------------
 1 | // <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
 2 | #nullable disable
 3 | using System;
 4 | using System.Collections.Generic;
 5 | 
 6 | namespace CatalogService.Domain.Entities;
 7 | 
 8 | public partial class Category
 9 | {
10 |     public int CategoryId { get; set; }
11 | 
12 |     public string Name { get; set; }
13 | 
14 |     public virtual ICollection<Product> Products { get; set; } = new List<Product>();
15 | }


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Domain/Interfaces/IProductRepository.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Domain.Entities;
 2 | 
 3 | namespace CatalogService.Domain.Interfaces
 4 | {
 5 |     public interface IProductRepository
 6 |     {
 7 |         IEnumerable<Product> GetAll();
 8 |         Product GetById(int id);
 9 |         IEnumerable<Product> GetByIds(int[] ids);
10 |         void Add(Product product);
11 |         void Update(Product product);
12 |         void Delete(int id);
13 |         int SaveChanges();
14 |     }
15 | }
16 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Models/ProductModel.cs:
--------------------------------------------------------------------------------
 1 | namespace Tom_s_E_shop.Models
 2 | {
 3 |     public class ProductModel
 4 |     {
 5 |         public int ProductId { get; set; }
 6 |         public string Name { get; set; } = string.Empty;
 7 |         public string Description { get; set; } = string.Empty;
 8 |         public decimal UnitPrice { get; set; }
 9 |         public string ImageUrl { get; set; } = string.Empty;
10 |         public int CategoryId { get; set; }
11 |         public DateTime? CreatedDate { get; set; }
12 |     }
13 | }
14 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Tom's E-shop.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk.Web">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net10.0</TargetFramework>
 5 |     <Nullable>enable</Nullable>
 6 |     <ImplicitUsings>enable</ImplicitUsings>
 7 |     <RootNamespace>Tom_s_E_shop</RootNamespace>
 8 |     <AssemblyName>Tom_s_E_shop</AssemblyName>
 9 |   </PropertyGroup>
10 | 
11 |   <ItemGroup>
12 |     <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="10.0.1" />
13 |   </ItemGroup>
14 | 
15 | </Project>
16 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Application/Mapings/CatalogRegister.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Application.DTOs;
 2 | using CatalogService.Domain.Entities;
 3 | using Mapster;
 4 | using System;
 5 | using System.Collections.Generic;
 6 | using System.Text;
 7 | 
 8 | namespace CatalogService.Application.Mapings
 9 | {
10 |     public class CatalogRegister : IRegister
11 |     {
12 |         public void Register(TypeAdapterConfig config)
13 |         {
14 |             config.NewConfig<Product, ProductDTO>().TwoWays();
15 |         }
16 |     }
17 | }
18 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Models/LoginModel.cs:
--------------------------------------------------------------------------------
 1 | using System.ComponentModel.DataAnnotations;
 2 | namespace Tom_s_E_shop.Models
 3 | {
 4 |     public class LoginModel
 5 |     {
 6 |         [Required(ErrorMessage = "Email is required")]
 7 |         [EmailAddress(ErrorMessage ="Invalid email format")]
 8 |         public string Email { get; set; }
 9 |         [Required(ErrorMessage = "Password is required")]
10 |         [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
11 |         public string Password { get; set; }
12 |     }
13 | }
14 | 


--------------------------------------------------------------------------------
/CatalogService.API/CatalogService.API.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk.Web">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net10.0</TargetFramework>
 5 |     <Nullable>enable</Nullable>
 6 |     <ImplicitUsings>enable</ImplicitUsings>
 7 |   </PropertyGroup>
 8 | 
 9 |   <ItemGroup>
10 |     <ProjectReference Include="..\BackendServices\CatalogService\CatalogService.Application\CatalogService.Application.csproj" />
11 |     <ProjectReference Include="..\BackendServices\CatalogService\CatalogService.Infrastructure\CatalogService.Infrastructure.csproj" />
12 |   </ItemGroup>
13 | 
14 | </Project>
15 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Infrastructure/AuthService.Infrastructure.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net10.0</TargetFramework>
 5 |     <ImplicitUsings>enable</ImplicitUsings>
 6 |     <Nullable>enable</Nullable>
 7 |   </PropertyGroup>
 8 | 
 9 |   <ItemGroup>
10 |     <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="10.0.0" />
11 |   </ItemGroup>
12 | 
13 |   <ItemGroup>
14 |     <ProjectReference Include="..\AuthService.Application\AuthService.Application.csproj" />
15 |   </ItemGroup>
16 | 
17 | </Project>
18 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Application/Interfaces/IProductAppService.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Application.DTOs;
 2 | using System;
 3 | using System.Collections.Generic;
 4 | using System.Text;
 5 | 
 6 | namespace CatalogService.Application.Interfaces
 7 | {
 8 |     public interface IProductAppService
 9 |     {
10 |         IEnumerable<ProductDTO> GetAll();
11 |         ProductDTO GetById(int id);
12 |         IEnumerable<ProductDTO> GetByIds(int[] ids);
13 |         void Add(ProductDTO productDto);
14 |         void Update(ProductDTO productDto);
15 |         void Delete(int id);
16 |     }
17 | }
18 | 


--------------------------------------------------------------------------------
/ApiGateways/OcelotAPIGateway/Program.cs:
--------------------------------------------------------------------------------
 1 | using Ocelot.DependencyInjection;
 2 | using Ocelot.Middleware;
 3 | 
 4 | var builder = WebApplication.CreateBuilder(args);
 5 | 
 6 | if (builder.Environment.IsDevelopment())
 7 | {
 8 |     builder.Configuration.AddJsonFile("ocelot.dev.json", optional: false, reloadOnChange: true);
 9 | 
10 | }
11 | else
12 | {
13 |     builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
14 | }
15 | builder.Services.AddOcelot();
16 | var app = builder.Build();
17 | app.UseOcelot().Wait();
18 | 
19 | app.MapGet("/", () => "Hello World!");
20 | 
21 | app.Run();
22 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Application/DTOs/ProductDTO.cs:
--------------------------------------------------------------------------------
 1 | using System;
 2 | using System.Collections.Generic;
 3 | using System.Text;
 4 | 
 5 | namespace CatalogService.Application.DTOs
 6 | {
 7 |     public class ProductDTO
 8 |     {
 9 |         public int ProductId { get; set; }
10 |         public string Name { get; set; }
11 |         public string Description { get; set; }
12 |         public decimal UnitPrice { get; set; }
13 |         public string ImageUrl { get; set; }
14 |         public int CategoryId { get; set; }
15 |         public DateTime? CreatedDate { get; set; }
16 |     }
17 | }
18 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Infrastructure/CatalogService.Infrastructure.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net10.0</TargetFramework>
 5 |     <ImplicitUsings>enable</ImplicitUsings>
 6 |     <Nullable>enable</Nullable>
 7 |   </PropertyGroup>
 8 | 
 9 |   <ItemGroup>
10 |     <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="10.0.0" />
11 |   </ItemGroup>
12 | 
13 |   <ItemGroup>
14 |     <ProjectReference Include="..\CatalogService.Application\CatalogService.Application.csproj" />
15 |   </ItemGroup>
16 | 
17 | </Project>
18 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Application/CatalogService.Application.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net10.0</TargetFramework>
 5 |     <ImplicitUsings>enable</ImplicitUsings>
 6 |     <Nullable>enable</Nullable>
 7 |   </PropertyGroup>
 8 | 
 9 |   <ItemGroup>
10 |     <ProjectReference Include="..\CatalogService.Domain\CatalogService.Domain.csproj" />
11 |   </ItemGroup>
12 | 
13 |   <ItemGroup>
14 |     <PackageReference Include="Mapster" Version="7.4.0" />
15 |     <PackageReference Include="Microsoft.Extensions.Configuration.Abstractions" Version="10.0.1" />
16 |   </ItemGroup>
17 | 
18 | </Project>
19 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.API/Program.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Infrastructure;
 2 | using MapsterMapper;
 3 | 
 4 | var builder = WebApplication.CreateBuilder(args);
 5 | ServiceRegistration.RegisterServices(builder.Services, builder.Configuration);
 6 | // Add services to the container.
 7 | // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
 8 | builder.Services.AddOpenApi();
 9 | builder.Services.AddScoped<IMapper, Mapper>();
10 | 
11 | var app = builder.Build();
12 | 
13 | // Configure the HTTP request pipeline.
14 | if (app.Environment.IsDevelopment())
15 | {
16 |     app.MapOpenApi();
17 | }
18 | 
19 | app.UseHttpsRedirection();
20 | 
21 | app.Run();


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.API/appsettings.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "Logging": {
 3 |     "LogLevel": {
 4 |       "Default": "Information",
 5 |       "Microsoft.AspNetCore": "Warning"
 6 |     }
 7 |   },
 8 |   "AllowedHosts": "*",
 9 |   "ConnectionStrings": {
10 |     "DBConnection": "Server=LAPTOP-VAIBHAV;Database=TEShopAuthService;User Id=Admin;Password=Vaibhav5822;Encrypt=True;TrustServerCertificate=True;MultipleActiveResultSets=True;"
11 |   },
12 |   "Jwt": {
13 |     "Key": "Tom's E-Shop@9730250945--Tom's E-Shop@9730250945Vaibhavhedaoo12@gmail.com9730250945",
14 |     "issuer": "www.api.Tom's E-Shop.com",
15 |     "Audience": "www.Tom's E-Shop.com",
16 |     "ExpiryInMinutes": 60
17 |   }
18 | }
19 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.API/CatalogService.API.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk.Web">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net10.0</TargetFramework>
 5 |     <Nullable>enable</Nullable>
 6 |     <ImplicitUsings>enable</ImplicitUsings>
 7 |   </PropertyGroup>
 8 | 
 9 |   <ItemGroup>
10 |     <PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="10.0.1" />
11 |   </ItemGroup>
12 | 
13 |   <ItemGroup>
14 |     <ProjectReference Include="..\CatalogService.Application\CatalogService.Application.csproj" />
15 |     <ProjectReference Include="..\CatalogService.Infrastructure\CatalogService.Infrastructure.csproj" />
16 |   </ItemGroup>
17 | 
18 | </Project>
19 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Application/Mapings/AuthRegister.cs:
--------------------------------------------------------------------------------
 1 | using AuthService.Application.DTOs;
 2 | using AuthService.Domain.Entities;
 3 | using Mapster;
 4 | using System;
 5 | using System.Collections.Generic;
 6 | using System.Text;
 7 | 
 8 | namespace AuthService.Application.Mapings
 9 | {
10 |     public class AuthRegister : IRegister
11 |     {
12 |         public void Register(TypeAdapterConfig config)
13 |         {
14 |             config.NewConfig<User, UserDTO>()
15 |                 .Map(dest => dest.UserId, src => src.Id)
16 |                 .Map(dest=> dest.Roles,src=>src.Roles.Select(r=>r.Name).ToArray());
17 | 
18 |             config.NewConfig<SignUpDTO, User>();
19 |         }
20 |     }
21 | }
22 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.API/Program.cs:
--------------------------------------------------------------------------------
 1 | using AuthService.Infrastructure;
 2 | 
 3 | var builder = WebApplication.CreateBuilder(args);
 4 | 
 5 | // Add services to the container.
 6 | 
 7 | builder.Services.AddControllers();
 8 | // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
 9 | builder.Services.AddOpenApi();
10 | 
11 | ServiceRegistration.RegisterServices(builder.Services, builder.Configuration);
12 | 
13 | var app = builder.Build();
14 | 
15 | // Configure the HTTP request pipeline.
16 | if (app.Environment.IsDevelopment())
17 | {
18 |     app.MapOpenApi();
19 | }
20 | 
21 | app.UseHttpsRedirection();
22 | 
23 | app.UseAuthorization();
24 | 
25 | app.MapControllers();
26 | 
27 | app.Run();
28 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Domain/Entities/User.cs:
--------------------------------------------------------------------------------
 1 | // <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
 2 | #nullable disable
 3 | using System;
 4 | using System.Collections.Generic;
 5 | 
 6 | namespace AuthService.Domain.Entities;
 7 | 
 8 | public partial class User
 9 | {
10 |     public int Id { get; set; }
11 | 
12 |     public string Name { get; set; }
13 | 
14 |     public string Email { get; set; }
15 | 
16 |     public string Password { get; set; }
17 | 
18 |     public string PhoneNumber { get; set; }
19 | 
20 |     public bool EmailConfirmed { get; set; }
21 | 
22 |     public DateTime CreatedDate { get; set; }
23 | 
24 |     public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
25 | }


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Domain/Entities/Product.cs:
--------------------------------------------------------------------------------
 1 | // <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
 2 | #nullable disable
 3 | using System;
 4 | using System.Collections.Generic;
 5 | 
 6 | namespace CatalogService.Domain.Entities;
 7 | 
 8 | public partial class Product
 9 | {
10 |     public int ProductId { get; set; }
11 | 
12 |     public string Name { get; set; }
13 | 
14 |     public string Description { get; set; }
15 | 
16 |     public decimal UnitPrice { get; set; }
17 | 
18 |     public string ImageUrl { get; set; }
19 | 
20 |     public int CategoryId { get; set; }
21 | 
22 |     public DateTime? CreatedDate { get; set; }
23 | 
24 |     public virtual Category Category { get; set; }
25 | }


--------------------------------------------------------------------------------
/CatalogService.API/Properties/launchSettings.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "$schema": "https://json.schemastore.org/launchsettings.json",
 3 |   "profiles": {
 4 |     "http": {
 5 |       "commandName": "Project",
 6 |       "dotnetRunMessages": true,
 7 |       "launchBrowser": false,
 8 |       "applicationUrl": "http://localhost:5162",
 9 |       "environmentVariables": {
10 |         "ASPNETCORE_ENVIRONMENT": "Development"
11 |       }
12 |     },
13 |     "https": {
14 |       "commandName": "Project",
15 |       "dotnetRunMessages": true,
16 |       "launchBrowser": false,
17 |       "applicationUrl": "https://localhost:7049;http://localhost:5162",
18 |       "environmentVariables": {
19 |         "ASPNETCORE_ENVIRONMENT": "Development"
20 |       }
21 |     }
22 |   }
23 | }
24 | 


--------------------------------------------------------------------------------
/ApiGateways/OcelotAPIGateway/Properties/launchSettings.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "$schema": "https://json.schemastore.org/launchsettings.json",
 3 |   "profiles": {
 4 |     "http": {
 5 |       "commandName": "Project",
 6 |       "dotnetRunMessages": true,
 7 |       "launchBrowser": true,
 8 |       "applicationUrl": "http://localhost:5016",
 9 |       "environmentVariables": {
10 |         "ASPNETCORE_ENVIRONMENT": "Development"
11 |       }
12 |     },
13 |     "https": {
14 |       "commandName": "Project",
15 |       "dotnetRunMessages": true,
16 |       "launchBrowser": true,
17 |       "applicationUrl": "https://localhost:7105;http://localhost:5016",
18 |       "environmentVariables": {
19 |         "ASPNETCORE_ENVIRONMENT": "Development"
20 |       }
21 |     }
22 |   }
23 | }
24 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.API/AuthService.API.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk.Web">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net10.0</TargetFramework>
 5 |     <Nullable>enable</Nullable>
 6 |     <ImplicitUsings>enable</ImplicitUsings>
 7 |   </PropertyGroup>
 8 | 
 9 |   <ItemGroup>
10 |     <PackageReference Include="Microsoft.AspNetCore.OpenApi" Version="10.0.1" />
11 |     <PackageReference Include="Microsoft.Extensions.Configuration" Version="10.0.1" />
12 |   </ItemGroup>
13 | 
14 |   <ItemGroup>
15 |     <ProjectReference Include="..\AuthService.Application\AuthService.Application.csproj" />
16 |     <ProjectReference Include="..\AuthService.Infrastructure\AuthService.Infrastructure.csproj" />
17 |   </ItemGroup>
18 | 
19 | </Project>
20 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Properties/launchSettings.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "$schema": "https://json.schemastore.org/launchsettings.json",
 3 |   "profiles": {
 4 |     "http": {
 5 |       "commandName": "Project",
 6 |       "dotnetRunMessages": true,
 7 |       "launchBrowser": true,
 8 |       "applicationUrl": "http://localhost:5096",
 9 |       "environmentVariables": {
10 |         "ASPNETCORE_ENVIRONMENT": "Development"
11 |       }
12 |     },
13 |     "https": {
14 |       "commandName": "Project",
15 |       "dotnetRunMessages": true,
16 |       "launchBrowser": true,
17 |       "applicationUrl": "https://localhost:7243;http://localhost:5096",
18 |       "environmentVariables": {
19 |         "ASPNETCORE_ENVIRONMENT": "Development"
20 |       }
21 |     }
22 |   }
23 | }
24 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.API/Properties/launchSettings.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "$schema": "https://json.schemastore.org/launchsettings.json",
 3 |   "profiles": {
 4 |     "http": {
 5 |       "commandName": "Project",
 6 |       "dotnetRunMessages": true,
 7 |       "launchBrowser": false,
 8 |       "applicationUrl": "http://localhost:5201",
 9 |       "environmentVariables": {
10 |         "ASPNETCORE_ENVIRONMENT": "Development"
11 |       }
12 |     },
13 |     "https": {
14 |       "commandName": "Project",
15 |       "dotnetRunMessages": true,
16 |       "launchBrowser": false,
17 |       "applicationUrl": "https://localhost:7029;http://localhost:5201",
18 |       "environmentVariables": {
19 |         "ASPNETCORE_ENVIRONMENT": "Development"
20 |       }
21 |     }
22 |   }
23 | }
24 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.API/Properties/launchSettings.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "$schema": "https://json.schemastore.org/launchsettings.json",
 3 |   "profiles": {
 4 |     "http": {
 5 |       "commandName": "Project",
 6 |       "dotnetRunMessages": true,
 7 |       "launchBrowser": false,
 8 |       "applicationUrl": "http://localhost:5023",
 9 |       "environmentVariables": {
10 |         "ASPNETCORE_ENVIRONMENT": "Development"
11 |       }
12 |     },
13 |     "https": {
14 |       "commandName": "Project",
15 |       "dotnetRunMessages": true,
16 |       "launchBrowser": false,
17 |       "applicationUrl": "https://localhost:7231;http://localhost:5023",
18 |       "environmentVariables": {
19 |         "ASPNETCORE_ENVIRONMENT": "Development"
20 |       }
21 |     }
22 |   }
23 | }
24 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Application/AuthService.Application.csproj:
--------------------------------------------------------------------------------
 1 | <Project Sdk="Microsoft.NET.Sdk">
 2 | 
 3 |   <PropertyGroup>
 4 |     <TargetFramework>net10.0</TargetFramework>
 5 |     <ImplicitUsings>enable</ImplicitUsings>
 6 |     <Nullable>enable</Nullable>
 7 |   </PropertyGroup>
 8 | 
 9 |   <ItemGroup>
10 |     <PackageReference Include="BCrypt.Net-Next" Version="4.0.3" />
11 |     <PackageReference Include="Mapster" Version="7.4.0" />
12 |     <PackageReference Include="Microsoft.Extensions.Configuration" Version="10.0.1" />
13 |     <PackageReference Include="System.IdentityModel.Tokens.Jwt" Version="8.15.0" />
14 |   </ItemGroup>
15 | 
16 |   <ItemGroup>
17 |     <ProjectReference Include="..\AuthService.Domain\AuthService.Domain.csproj" />
18 |   </ItemGroup>
19 | 
20 | </Project>
21 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/HttpClients/AuthServiceClient.cs:
--------------------------------------------------------------------------------
 1 | using Tom_s_E_shop.Models;
 2 | 
 3 | namespace Tom_s_E_shop.HttpClients
 4 | {
 5 |     public class AuthServiceClient
 6 |     {
 7 |         private readonly HttpClient _httpClient;
 8 |         public AuthServiceClient(HttpClient httpClient)
 9 |         {
10 |             _httpClient = httpClient;
11 |         }
12 | 
13 |         public UserModel Login(LoginModel loginModel)
14 |         {
15 |             var result = _httpClient.PostAsJsonAsync("Auth/Login", loginModel).Result;
16 |             if (result.IsSuccessStatusCode)
17 |             {
18 |                 var user = result.Content.ReadFromJsonAsync<UserModel>().Result;
19 |                 return user;
20 | 
21 |             }
22 |             return null;
23 |         }
24 |     }
25 | }
26 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.API/Controllers/ProductController.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Application.Interfaces;
 2 | using Microsoft.AspNetCore.Http;
 3 | using Microsoft.AspNetCore.Mvc;
 4 | 
 5 | namespace CatalogService.API.Controllers
 6 | {
 7 |     [Route("api/[controller]")]
 8 |     [ApiController]
 9 |     public class ProductController : ControllerBase
10 |     {
11 |         private readonly IProductAppService _productAppService;
12 |         public ProductController(IProductAppService productAppService)
13 |         {
14 |             _productAppService = productAppService;
15 |         }
16 | 
17 |         [HttpGet]
18 |         public IActionResult GetAllProducts()
19 |         {
20 |             var products = _productAppService.GetAll();
21 |             return Ok(products);
22 |         }
23 |     }
24 | }
25 | 


--------------------------------------------------------------------------------
/ApiGateways/OcelotAPIGateway/ocelot.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "Routes": [
 3 |     {
 4 |       "DownstreamPathTemplate": "/api/auth/{everything}",
 5 |       "DownstreamScheme": "https",
 6 |       "DownstreamHostAndPorts": [
 7 |         {
 8 |           "Host": "localhost",
 9 |           "Port": 7029
10 |         }
11 |       ],
12 |       "UpstreamPathTemplate": "/auth/{everything}",
13 |       "UpstreamHttpMethod": [ "Get", "Post" ]
14 | 
15 |     },
16 |     {
17 |       "DownstreamPathTemplate": "/api/catalog/{everything}",
18 |       "DownstreamScheme": "https",
19 |       "DownstreamHostAndPorts": [
20 |         {
21 |           "Host": "localhost",
22 |           "Port": 7049
23 |         }
24 |       ],
25 |       "UpstreamPathTemplate": "/catalog/{everything}",
26 |       "UpstreamHttpMethod": [ "Get", "Post" ]
27 | 
28 |     }
29 |   ]
30 | }
31 | 


--------------------------------------------------------------------------------
/ApiGateways/OcelotAPIGateway/ocelot.dev.json:
--------------------------------------------------------------------------------
 1 | {
 2 |   "Routes": [
 3 |     {
 4 |       "DownstreamPathTemplate": "/api/auth/{everything}",
 5 |       "DownstreamScheme": "https",
 6 |       "DownstreamHostAndPorts": [
 7 |         {
 8 |           "Host": "localhost",
 9 |           "Port": 7029
10 |         }
11 |       ],
12 |       "UpstreamPathTemplate": "/auth/{everything}",
13 |       "UpstreamHttpMethod": [ "Get", "Post" ]
14 |     },
15 |     {
16 |       "DownstreamPathTemplate": "/api/catalog/{everything}",
17 |       "DownstreamScheme": "https",
18 |       "DownstreamHostAndPorts": [
19 |         {
20 |           "Host": "localhost",
21 |           "Port": 7049
22 |         }
23 |       ],
24 |       "UpstreamPathTemplate": "/catalog/{everything}",
25 |       "UpstreamHttpMethod": [ "Get", "Post" ]
26 | 
27 |     }
28 |   ]
29 | 
30 | }
31 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/HttpClients/CatalogServiceClient.cs:
--------------------------------------------------------------------------------
 1 | using Tom_s_E_shop.Models;
 2 | 
 3 | namespace Tom_s_E_shop.HttpClients
 4 | {
 5 |     public class CatalogServiceClient
 6 |     {
 7 |         private readonly HttpClient _httpClient;
 8 |         public CatalogServiceClient(HttpClient httpClient)
 9 |         {
10 |             _httpClient = httpClient;
11 |         }
12 | 
13 |         public async Task<IEnumerable<ProductModel>?> GetProductsAsync()
14 |         {
15 |             var result = await _httpClient.GetAsync("Catalog/GetProducts");
16 |             if (result.IsSuccessStatusCode)
17 |             {
18 |                 var products = await result.Content.ReadFromJsonAsync<IEnumerable<ProductModel>>();
19 |                 return products;
20 |             }
21 |             return null;
22 |         }
23 |     }
24 | }
25 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Helper/BaseViewPage.cs:
--------------------------------------------------------------------------------
 1 | 
 2 | using System.Security.Claims;
 3 | using Tom_s_E_shop.Models;
 4 | 
 5 | namespace Tom_s_E_shop.Helper
 6 | {
 7 |     public abstract class BaseViewPage<TModel> : Microsoft.AspNetCore.Mvc.Razor.RazorPage<TModel>
 8 |     {
 9 | 
10 |         public UserModel CurrentUser { 
11 |             get { 
12 |                 if (User.Identity.IsAuthenticated) 
13 |                 {
14 |                     var userData = Context.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.UserData);
15 |                     if (userData != null) {
16 |                         return System.Text.Json.JsonSerializer.Deserialize<UserModel>(userData.Value);
17 |                     }                    
18 |                 }
19 |                 return null;
20 |             } 
21 |         }
22 |        
23 |     }
24 | }
25 | 


--------------------------------------------------------------------------------
/CatalogService.API/Controllers/ProductController.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Application.Interfaces;
 2 | using Microsoft.AspNetCore.Http;
 3 | using Microsoft.AspNetCore.Mvc;
 4 | 
 5 | namespace CatalogService.API.Controllers
 6 | {
 7 |     [Route("api/[controller]/[action]")]
 8 |     [ApiController]
 9 |     public class ProductController : ControllerBase
10 |     {
11 |         private readonly IProductAppService _productAppService;
12 |         public ProductController(IProductAppService productAppService)
13 |         {
14 |             _productAppService = productAppService;
15 |         }
16 | 
17 |         [HttpGet]
18 |         public IActionResult GetProducts()
19 |         {
20 |             var products = _productAppService.GetAll();
21 |             if (products == null)
22 |             {
23 |                 return NotFound();
24 |             }
25 |             return Ok(products);
26 |         }
27 |     }
28 | }
29 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Helper/CustomAuthorize.cs:
--------------------------------------------------------------------------------
 1 | using Microsoft.AspNetCore.Authentication;
 2 | using Microsoft.AspNetCore.Mvc;
 3 | using Microsoft.AspNetCore.Mvc.Filters;
 4 | 
 5 | namespace Tom_s_E_shop.Helper
 6 | {
 7 |     public class CustomAuthorize : Attribute, IAuthorizationFilter
 8 |     {
 9 |         public string Roles { get; set; }
10 |         public void OnAuthorization(AuthorizationFilterContext context)
11 |         {
12 |             if (!context.HttpContext.User.Identity.IsAuthenticated)
13 |             {
14 |                 context.Result = new RedirectToActionResult("Login", "Account", new { area = "" });
15 |             }
16 |             else
17 |             {
18 |                 if (!context.HttpContext.User.IsInRole(Roles))
19 |                 {
20 |                     context.Result = new RedirectToActionResult("UnAuthorize", "Account", new { area = "" });
21 |                 }
22 |             }
23 |         }
24 |     }
25 | }
26 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Views/Shared/Error.cshtml:
--------------------------------------------------------------------------------
 1 | @model ErrorViewModel
 2 | @{
 3 |     ViewData["Title"] = "Error";
 4 | }
 5 | 
 6 | <h1 class="text-danger">Error.</h1>
 7 | <h2 class="text-danger">An error occurred while processing your request.</h2>
 8 | 
 9 | @if (Model.ShowRequestId)
10 | {
11 |     <p>
12 |         <strong>Request ID:</strong> <code>@Model.RequestId</code>
13 |     </p>
14 | }
15 | 
16 | <h3>Development Mode</h3>
17 | <p>
18 |     Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
19 | </p>
20 | <p>
21 |     <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
22 |     It can result in displaying sensitive information from exceptions to end users.
23 |     For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
24 |     and restarting the app.
25 | </p>
26 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Areas/User/Views/Shared/Error.cshtml:
--------------------------------------------------------------------------------
 1 | @model ErrorViewModel
 2 | @{
 3 |     ViewData["Title"] = "Error";
 4 | }
 5 | 
 6 | <h1 class="text-danger">Error.</h1>
 7 | <h2 class="text-danger">An error occurred while processing your request.</h2>
 8 | 
 9 | @if (Model.ShowRequestId)
10 | {
11 |     <p>
12 |         <strong>Request ID:</strong> <code>@Model.RequestId</code>
13 |     </p>
14 | }
15 | 
16 | <h3>Development Mode</h3>
17 | <p>
18 |     Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
19 | </p>
20 | <p>
21 |     <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
22 |     It can result in displaying sensitive information from exceptions to end users.
23 |     For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
24 |     and restarting the app.
25 | </p>
26 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.API/Controllers/WeatherForecastController.cs:
--------------------------------------------------------------------------------
 1 | using Microsoft.AspNetCore.Mvc;
 2 | 
 3 | namespace AuthService.API.Controllers
 4 | {
 5 |     [ApiController]
 6 |     [Route("[controller]")]
 7 |     public class WeatherForecastController : ControllerBase
 8 |     {
 9 |         private static readonly string[] Summaries =
10 |         [
11 |             "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
12 |         ];
13 | 
14 |         [HttpGet(Name = "GetWeatherForecast")]
15 |         public IEnumerable<WeatherForecast> Get()
16 |         {
17 |             return Enumerable.Range(1, 5).Select(index => new WeatherForecast
18 |             {
19 |                 Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
20 |                 TemperatureC = Random.Shared.Next(-20, 55),
21 |                 Summary = Summaries[Random.Shared.Next(Summaries.Length)]
22 |             })
23 |             .ToArray();
24 |         }
25 |     }
26 | }
27 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Views/Shared/_Layout.cshtml.css:
--------------------------------------------------------------------------------
 1 | /* Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
 2 | for details on configuring this project to bundle and minify static web assets. */
 3 | 
 4 | a.navbar-brand {
 5 |   white-space: normal;
 6 |   text-align: center;
 7 |   word-break: break-all;
 8 | }
 9 | 
10 | a {
11 |   color: #0077cc;
12 | }
13 | 
14 | .btn-primary {
15 |   color: #fff;
16 |   background-color: #1b6ec2;
17 |   border-color: #1861ac;
18 | }
19 | 
20 | .nav-pills .nav-link.active, .nav-pills .show > .nav-link {
21 |   color: #fff;
22 |   background-color: #1b6ec2;
23 |   border-color: #1861ac;
24 | }
25 | 
26 | .border-top {
27 |   border-top: 1px solid #e5e5e5;
28 | }
29 | .border-bottom {
30 |   border-bottom: 1px solid #e5e5e5;
31 | }
32 | 
33 | .box-shadow {
34 |   box-shadow: 0 .25rem .75rem rgba(0, 0, 0, .05);
35 | }
36 | 
37 | button.accept-policy {
38 |   font-size: 1rem;
39 |   line-height: inherit;
40 | }
41 | 
42 | .footer {
43 |   position: absolute;
44 |   bottom: 0;
45 |   width: 100%;
46 |   white-space: nowrap;
47 |   line-height: 60px;
48 | }
49 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Areas/User/Views/Shared/_Layout.cshtml.css:
--------------------------------------------------------------------------------
 1 | /* Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
 2 | for details on configuring this project to bundle and minify static web assets. */
 3 | 
 4 | a.navbar-brand {
 5 |   white-space: normal;
 6 |   text-align: center;
 7 |   word-break: break-all;
 8 | }
 9 | 
10 | a {
11 |   color: #0077cc;
12 | }
13 | 
14 | .btn-primary {
15 |   color: #fff;
16 |   background-color: #1b6ec2;
17 |   border-color: #1861ac;
18 | }
19 | 
20 | .nav-pills .nav-link.active, .nav-pills .show > .nav-link {
21 |   color: #fff;
22 |   background-color: #1b6ec2;
23 |   border-color: #1861ac;
24 | }
25 | 
26 | .border-top {
27 |   border-top: 1px solid #e5e5e5;
28 | }
29 | .border-bottom {
30 |   border-bottom: 1px solid #e5e5e5;
31 | }
32 | 
33 | .box-shadow {
34 |   box-shadow: 0 .25rem .75rem rgba(0, 0, 0, .05);
35 | }
36 | 
37 | button.accept-policy {
38 |   font-size: 1rem;
39 |   line-height: inherit;
40 | }
41 | 
42 | .footer {
43 |   position: absolute;
44 |   bottom: 0;
45 |   width: 100%;
46 |   white-space: nowrap;
47 |   line-height: 60px;
48 | }
49 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Controllers/HomeController.cs:
--------------------------------------------------------------------------------
 1 | using Microsoft.AspNetCore.Mvc;
 2 | using System.Diagnostics;
 3 | using System.Threading.Tasks;
 4 | using Tom_s_E_shop.HttpClients;
 5 | using Tom_s_E_shop.Models;
 6 | 
 7 | namespace Tom_s_E_shop.Controllers
 8 | {
 9 |     public class HomeController : Controller
10 |     {
11 |         private readonly CatalogServiceClient _catalogServiceClient;
12 |         public HomeController(CatalogServiceClient catalogServiceClient)
13 |         {
14 |             _catalogServiceClient = catalogServiceClient;
15 |         }
16 |         public async Task<IActionResult> Index()
17 |         {
18 |             var products = await _catalogServiceClient.GetProductsAsync();
19 |             return View(products);
20 |         }
21 | 
22 |         public IActionResult Privacy()
23 |         {
24 |             return View();
25 |         }
26 | 
27 |         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
28 |         public IActionResult Error()
29 |         {
30 |             return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
31 |         }
32 |     }
33 | }
34 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Infrastructure/Presistance/Repositories/UserRepository.cs:
--------------------------------------------------------------------------------
 1 | using AuthService.Domain.Entities;
 2 | using AuthService.Domain.Interfaces;
 3 | using Microsoft.EntityFrameworkCore;
 4 | 
 5 | namespace AuthService.Infrastructure.Presistance.Repositories
 6 | {
 7 |     public class UserRepository : IUserRepository
 8 |     {
 9 |         private readonly AuthServiceContext _context;
10 |         public UserRepository(AuthServiceContext context)
11 |         {
12 |             _context = context;
13 |         }
14 |         public User GetUserByEmail(string email)
15 |         {
16 |            return _context.Users.Include(u=>u.Roles).Where(u =>u.Email == email).FirstOrDefault();
17 |         }
18 | 
19 |         public bool RegisterUser(User user, string role)
20 |         {
21 |             Role UserRole = _context.Roles.Where(r=>r.Name == role).FirstOrDefault();
22 |             if(UserRole != null)
23 |             {
24 |                 user.Roles.Add(UserRole);
25 |                 _context.Users.Add(user);
26 |                 _context.SaveChanges();
27 |                 return true;
28 |             }
29 |             return false;
30 |         }
31 |     }
32 | }
33 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Models/SignUpModel.cs:
--------------------------------------------------------------------------------
 1 | using System.ComponentModel.DataAnnotations;
 2 | namespace Tom_s_E_shop.Models
 3 | {
 4 |     public class SignUpModel
 5 |     {
 6 |         public long UserId { get; set; }
 7 | 
 8 |         [Required(ErrorMessage="First name is required")]
 9 |         [StringLength(50, ErrorMessage="First name cannot be longer than 50 characters")]
10 |         public string Name { get; set; }
11 |         [Required(ErrorMessage="Email is required")]
12 |         [EmailAddress(ErrorMessage="Invalid Email format")]
13 |         public string Email { get; set; }
14 | 
15 |         [Required(ErrorMessage ="Phone number is required")]
16 |         [Phone(ErrorMessage ="Invalid phone number format")]
17 |         public string PhoneNumber { get; set; }
18 |         [Required(ErrorMessage="Password is required")]
19 |         [StringLength(100, MinimumLength = 6, ErrorMessage ="Password must be at least 6 characters long")]
20 |         public string Password { get; set; }
21 |         [Required(ErrorMessage="Role is required")]
22 |         [StringLength(20, ErrorMessage="Role cannot be longer than 20 characters")]
23 |         public string Role { get; set; }
24 |     }
25 | }
26 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/lib/jquery/LICENSE.txt:
--------------------------------------------------------------------------------
 1 | 
 2 | Copyright OpenJS Foundation and other contributors, https://openjsf.org/
 3 | 
 4 | Permission is hereby granted, free of charge, to any person obtaining
 5 | a copy of this software and associated documentation files (the
 6 | "Software"), to deal in the Software without restriction, including
 7 | without limitation the rights to use, copy, modify, merge, publish,
 8 | distribute, sublicense, and/or sell copies of the Software, and to
 9 | permit persons to whom the Software is furnished to do so, subject to
10 | the following conditions:
11 | 
12 | The above copyright notice and this permission notice shall be
13 | included in all copies or substantial portions of the Software.
14 | 
15 | THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
16 | EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
17 | MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
18 | NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
19 | LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
20 | OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
21 | WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/lib/jquery-validation/LICENSE.md:
--------------------------------------------------------------------------------
 1 | The MIT License (MIT)
 2 | =====================
 3 | 
 4 | Copyright Jörn Zaefferer
 5 | 
 6 | Permission is hereby granted, free of charge, to any person obtaining a copy
 7 | of this software and associated documentation files (the "Software"), to deal
 8 | in the Software without restriction, including without limitation the rights
 9 | to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
10 | copies of the Software, and to permit persons to whom the Software is
11 | furnished to do so, subject to the following conditions:
12 | 
13 | The above copyright notice and this permission notice shall be included in
14 | all copies or substantial portions of the Software.
15 | 
16 | THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
17 | IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
18 | FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
19 | AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
20 | LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
21 | OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
22 | THE SOFTWARE.
23 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Views/Account/Login.cshtml:
--------------------------------------------------------------------------------
 1 | @model Tom_s_E_shop.Models.LoginModel
 2 | 
 3 | @{
 4 |     ViewData["Title"] = "Login";
 5 | }
 6 | 
 7 | <h1>Login</h1>
 8 | <hr />
 9 | <div class="row">
10 |     <div class="col-md-4">
11 |         <form asp-action="Login">
12 |             <div asp-validation-summary="ModelOnly" class="text-danger"></div>
13 |             <div class="form-group">
14 |                 <label asp-for="Email" class="control-label"></label>
15 |                 <input asp-for="Email" class="form-control" />
16 |                 <span asp-validation-for="Email" class="text-danger"></span>
17 |             </div>
18 |             <div class="form-group">
19 |                 <label asp-for="Password" class="control-label"></label>
20 |                 <input type="password" asp-for="Password" class="form-control" />
21 |                 <span asp-validation-for="Password" class="text-danger"></span>
22 |             </div>
23 |             <div class="form-group">
24 |                 <input type="submit" value="Login" class="btn btn-primary" />
25 |             </div>
26 |         </form>
27 |     </div>
28 | </div>
29 | 
30 | @section Scripts {
31 |     @{await Html.RenderPartialAsync("_ValidationScriptsPartial");}
32 | }
33 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/lib/bootstrap/LICENSE:
--------------------------------------------------------------------------------
 1 | The MIT License (MIT)
 2 | 
 3 | Copyright (c) 2011-2021 Twitter, Inc.
 4 | Copyright (c) 2011-2021 The Bootstrap Authors
 5 | 
 6 | Permission is hereby granted, free of charge, to any person obtaining a copy
 7 | of this software and associated documentation files (the "Software"), to deal
 8 | in the Software without restriction, including without limitation the rights
 9 | to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
10 | copies of the Software, and to permit persons to whom the Software is
11 | furnished to do so, subject to the following conditions:
12 | 
13 | The above copyright notice and this permission notice shall be included in
14 | all copies or substantial portions of the Software.
15 | 
16 | THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
17 | IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
18 | FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
19 | AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
20 | LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
21 | OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
22 | THE SOFTWARE.
23 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/lib/jquery-validation-unobtrusive/LICENSE.txt:
--------------------------------------------------------------------------------
 1 | The MIT License (MIT)
 2 | 
 3 | Copyright (c) .NET Foundation and Contributors
 4 | 
 5 | All rights reserved.
 6 | 
 7 | Permission is hereby granted, free of charge, to any person obtaining a copy
 8 | of this software and associated documentation files (the "Software"), to deal
 9 | in the Software without restriction, including without limitation the rights
10 | to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
11 | copies of the Software, and to permit persons to whom the Software is
12 | furnished to do so, subject to the following conditions:
13 | 
14 | The above copyright notice and this permission notice shall be included in all
15 | copies or substantial portions of the Software.
16 | 
17 | THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
18 | IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
19 | FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
20 | AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
21 | LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
22 | OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
23 | SOFTWARE.
24 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.API/Controllers/AuthController.cs:
--------------------------------------------------------------------------------
 1 | using AuthService.Application.DTOs;
 2 | using AuthService.Application.Interfaces;
 3 | using Microsoft.AspNetCore.Mvc;
 4 | 
 5 | namespace AuthService.API.Controllers
 6 | {
 7 | 
 8 |     [Route("api/[Controller]/[action]")]
 9 |     [ApiController]
10 |     public class AuthController : Controller
11 |     {
12 |         private readonly IUserAppService _userAppService;
13 |         public AuthController(IUserAppService userAppService)
14 |         {
15 |             _userAppService = userAppService;
16 |         }
17 | 
18 | 
19 |         [HttpPost]
20 |         public IActionResult Login([FromBody] LoginDTO loginDTO)
21 |         {
22 |             var user = _userAppService.LoginUser(loginDTO);
23 |             if (user != null)
24 |             {
25 |                 return Ok(user);
26 |             }
27 |             return Unauthorized("Invalid email or password.");
28 |         }
29 | 
30 |         [HttpPost]
31 |         public IActionResult SignUp([FromBody] SignUpDTO signUpDTO, string Role)
32 |         {
33 |             var isRegistered = _userAppService.SignUpUser(signUpDTO, Role);
34 |             if (isRegistered)
35 |             {
36 |                 return Ok("User registered successfully.");
37 |             }
38 |             return BadRequest("User registration failed. User may already exist.");
39 |         }
40 |     }
41 | }
42 | 


--------------------------------------------------------------------------------
/Tom's E--Shop.slnx:
--------------------------------------------------------------------------------
 1 | <Solution>
 2 |   <Folder Name="/ApiGateways/">
 3 |     <Project Path="ApiGateways/OcelotAPIGateway/OcelotAPIGateway.csproj" Id="182efbb3-fa55-4a89-b83c-b384f8043771" />
 4 |   </Folder>
 5 |   <Folder Name="/BackendServices/" />
 6 |   <Folder Name="/BackendServices/AuthService/">
 7 |     <Project Path="BackendServices/AuthService/AuthService.API/AuthService.API.csproj" Id="cf380370-5dbb-49e2-81e4-859c11dc8985" />
 8 |     <Project Path="BackendServices/AuthService/AuthService.Application/AuthService.Application.csproj" />
 9 |     <Project Path="BackendServices/AuthService/AuthService.Domain/AuthService.Domain.csproj" />
10 |     <Project Path="BackendServices/AuthService/AuthService.Infrastructure/AuthService.Infrastructure.csproj" />
11 |   </Folder>
12 |   <Folder Name="/BackendServices/CatalogService/">
13 |     <Project Path="BackendServices/CatalogService/CatalogService.Application/CatalogService.Application.csproj" />
14 |     <Project Path="BackendServices/CatalogService/CatalogService.Domain/CatalogService.Domain.csproj" />
15 |     <Project Path="BackendServices/CatalogService/CatalogService.Infrastructure/CatalogService.Infrastructure.csproj" />
16 |     <Project Path="CatalogService.API/CatalogService.API.csproj" Id="b0cef475-0808-4755-913d-90fca09889d7" />
17 |   </Folder>
18 |   <Folder Name="/FrontendServices/">
19 |     <Project Path="FrontendServices/Tom's E-shop/Tom's E-shop.csproj" Id="22644696-0fad-4294-af40-8af8f2e0d821" />
20 |   </Folder>
21 | </Solution>
22 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Infrastructure/ServiceRegistration.cs:
--------------------------------------------------------------------------------
 1 | using AuthService.Domain.Interfaces;
 2 | using AuthService.Infrastructure.Presistance.Repositories;
 3 | using MapsterMapper;
 4 | using Microsoft.EntityFrameworkCore;
 5 | using Microsoft.Extensions.Configuration;
 6 | using Microsoft.Extensions.DependencyInjection;
 7 | 
 8 | namespace AuthService.Infrastructure
 9 | {
10 |     public class ServiceRegistration
11 |     {
12 |         public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
13 |         {
14 |             // Implementation for service registration
15 |             services.AddDbContext<Presistance.AuthServiceContext>(options =>
16 |             {
17 |                 // Configure your DbContext here, e.g., using SQL Server or another provider
18 |                 options.UseSqlServer(configuration.GetConnectionString("DBConnection"));
19 |             });
20 | 
21 | 
22 |             //Repository registartion
23 |             services.AddScoped<IUserRepository,UserRepository>();
24 | 
25 |             //Service registration
26 |             services.AddScoped<Application.Interfaces.IUserAppService,Application.Services.UserAppServices>();
27 | 
28 |             //mapster registration
29 |             var config = new Mapster.TypeAdapterConfig();
30 |             config.Scan(typeof(Application.Mapings.AuthRegister).Assembly);
31 |             services.AddSingleton(config);
32 |             services.AddScoped<IMapper, Mapper>();
33 |         }
34 |     }
35 | }
36 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Infrastructure/Persistance/CatalogServiceContext.cs:
--------------------------------------------------------------------------------
 1 | // <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
 2 | #nullable disable
 3 | using System;
 4 | using System.Collections.Generic;
 5 | using CatalogService.Domain.Entities;
 6 | using CatalogService.Infrastructure;
 7 | using Microsoft.EntityFrameworkCore;
 8 | 
 9 | namespace CatalogService.Infrastructure.Persistance;
10 | 
11 | public partial class CatalogServiceContext : DbContext
12 | {
13 |     public CatalogServiceContext(DbContextOptions<CatalogServiceContext> options)
14 |         : base(options)
15 |     {
16 |     }
17 | 
18 |     public virtual DbSet<Category> Categories { get; set; }
19 | 
20 |     public virtual DbSet<Product> Products { get; set; }
21 | 
22 |     protected override void OnModelCreating(ModelBuilder modelBuilder)
23 |     {
24 |         modelBuilder.Entity<Category>(entity =>
25 |         {
26 |             entity.Property(e => e.Name).IsRequired();
27 |         });
28 | 
29 |         modelBuilder.Entity<Product>(entity =>
30 |         {
31 |             entity.Property(e => e.Description).IsRequired();
32 |             entity.Property(e => e.Name).IsRequired();
33 |             entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
34 | 
35 |             entity.HasOne(d => d.Category).WithMany(p => p.Products).HasForeignKey(d => d.CategoryId);
36 |         });
37 | 
38 |         OnModelCreatingPartial(modelBuilder);
39 |     }
40 | 
41 |     partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
42 | }


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Infrastructure/Persistance/Repositories/ProductRepository.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Domain.Entities;
 2 | using CatalogService.Domain.Interfaces;
 3 | 
 4 | 
 5 | namespace CatalogService.Infrastructure.Persistance.Repositories
 6 | {
 7 |     
 8 |     public class ProductRepository : IProductRepository
 9 |     {
10 |         private readonly CatalogServiceContext _db;
11 |         public ProductRepository(CatalogServiceContext db)
12 |         {
13 |             _db = db;
14 |         }
15 |         public void Add(Product product)
16 |         {
17 |             _db.Products.Add(product);
18 |         }
19 | 
20 |         public void Delete(int id)
21 |         {
22 |             var product = _db.Products.Find(id);
23 |             if (product != null)
24 |             {
25 |                 _db.Products.Remove(product);
26 |             }
27 |         }
28 | 
29 |         public IEnumerable<Product> GetAll()
30 |         {
31 |             return _db.Products.ToList();
32 |         }
33 | 
34 |         public Product GetById(int id)
35 |         {
36 |             return _db.Products.Find(id);
37 |         }
38 | 
39 |         public IEnumerable<Product> GetByIds(int[] ids)
40 |         {
41 |             return _db.Products.Where(p => ids.Contains(p.ProductId)).ToList();
42 |         }
43 | 
44 |         public int SaveChanges()
45 |         {
46 |             return _db.SaveChanges();
47 |         }
48 | 
49 |         public void Update(Product product)
50 |         {
51 |             _db.Products.Update(product);
52 |         }
53 |     }
54 | }
55 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Infrastructure/ServiceRegistration.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Application.Interfaces;
 2 | using CatalogService.Application.Mapings;
 3 | using CatalogService.Application.Services;
 4 | using CatalogService.Domain.Interfaces;
 5 | using CatalogService.Infrastructure.Persistance;
 6 | using CatalogService.Infrastructure.Persistance.Repositories;
 7 | using Mapster;
 8 | using MapsterMapper;
 9 | using Microsoft.EntityFrameworkCore;
10 | using Microsoft.Extensions.Configuration;
11 | using Microsoft.Extensions.DependencyInjection;
12 | 
13 | namespace CatalogService.Infrastructure
14 | {
15 |     public class ServiceRegistration
16 |     {
17 |         public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
18 |         {
19 |             // Implementation for service registration
20 |             string connectionString = configuration.GetConnectionString("DBConnection");
21 | 
22 |             services.AddDbContext<CatalogServiceContext>(options =>
23 |             {
24 |                 // Configure your DbContext here, e.g., using SQL Server or another provider
25 |                 options.UseSqlServer(connectionString);
26 |             });
27 | 
28 |             //Repository registartion
29 |             services.AddScoped<IProductRepository, ProductRepository>();
30 | 
31 |             //Service registration
32 |             services.AddScoped<IProductAppService, ProductAppService>();
33 | 
34 |             //mapster registration
35 |             var config = TypeAdapterConfig.GlobalSettings;
36 |             config.Scan(typeof(CatalogRegister).Assembly);
37 |             services.AddSingleton(config);
38 |             services.AddScoped<IMapper, Mapper>();
39 |         }
40 |     }
41 | }
42 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Domain/efpt.config.json:
--------------------------------------------------------------------------------
 1 | {
 2 |    "CodeGenerationMode": 6,
 3 |    "ContextClassName": "CatalogServiceContext",
 4 |    "ContextNamespace": null,
 5 |    "FilterSchemas": false,
 6 |    "IncludeConnectionString": false,
 7 |    "IrregularWords": null,
 8 |    "MinimumProductVersion": "2.6.1248",
 9 |    "ModelNamespace": null,
10 |    "OutputContextPath": null,
11 |    "OutputPath": "Entities",
12 |    "PluralRules": null,
13 |    "PreserveCasingWithRegex": true,
14 |    "ProjectRootNamespace": "CatalogService.Domain",
15 |    "Schemas": null,
16 |    "SelectedHandlebarsLanguage": 2,
17 |    "SelectedToBeGenerated": 2,
18 |    "SingularRules": null,
19 |    "T4TemplatePath": null,
20 |    "Tables": [
21 |       {
22 |          "Name": "[dbo].[Categories]",
23 |          "ObjectType": 0
24 |       },
25 |       {
26 |          "Name": "[dbo].[Products]",
27 |          "ObjectType": 0
28 |       }
29 |    ],
30 |    "UiHint": null,
31 |    "UncountableWords": null,
32 |    "UseAsyncStoredProcedureCalls": true,
33 |    "UseBoolPropertiesWithoutDefaultSql": false,
34 |    "UseDatabaseNames": false,
35 |    "UseDatabaseNamesForRoutines": true,
36 |    "UseDateOnlyTimeOnly": true,
37 |    "UseDbContextSplitting": false,
38 |    "UseDecimalDataAnnotationForSprocResult": true,
39 |    "UseFluentApiOnly": true,
40 |    "UseHandleBars": false,
41 |    "UseHierarchyId": false,
42 |    "UseInflector": true,
43 |    "UseInternalAccessModifiersForSprocsAndFunctions": false,
44 |    "UseLegacyPluralizer": false,
45 |    "UseManyToManyEntity": false,
46 |    "UseNoDefaultConstructor": false,
47 |    "UseNoNavigations": false,
48 |    "UseNoObjectFilter": false,
49 |    "UseNodaTime": false,
50 |    "UseNullableReferences": false,
51 |    "UsePrefixNavigationNaming": false,
52 |    "UseSchemaFolders": false,
53 |    "UseSchemaNamespaces": false,
54 |    "UseSpatial": false,
55 |    "UseT4": false,
56 |    "UseT4Split": false
57 | }


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Infrastructure/Presistance/AuthServiceContext.cs:
--------------------------------------------------------------------------------
 1 | // <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
 2 | #nullable disable
 3 | using System;
 4 | using System.Collections.Generic;
 5 | using AuthService.Domain.Entities;
 6 | using Microsoft.EntityFrameworkCore;
 7 | 
 8 | namespace AuthService.Infrastructure.Presistance;
 9 | 
10 | public partial class AuthServiceContext : DbContext
11 | {
12 |     public AuthServiceContext(DbContextOptions<AuthServiceContext> options)
13 |         : base(options)
14 |     {
15 |     }
16 | 
17 |     public virtual DbSet<Role> Roles { get; set; }
18 | 
19 |     public virtual DbSet<User> Users { get; set; }
20 | 
21 |     protected override void OnModelCreating(ModelBuilder modelBuilder)
22 |     {
23 |         modelBuilder.Entity<Role>(entity =>
24 |         {
25 |             entity.Property(e => e.Name).IsRequired();
26 |         });
27 | 
28 |         modelBuilder.Entity<User>(entity =>
29 |         {
30 |             entity.Property(e => e.Email).IsRequired();
31 |             entity.Property(e => e.Name).IsRequired();
32 |             entity.Property(e => e.Password).IsRequired();
33 |             entity.Property(e => e.PhoneNumber).IsRequired();
34 | 
35 |             entity.HasMany(d => d.Roles).WithMany(p => p.Users)
36 |                 .UsingEntity<Dictionary<string, object>>(
37 |                     "UserRole",
38 |                     r => r.HasOne<Role>().WithMany().HasForeignKey("RoleId"),
39 |                     l => l.HasOne<User>().WithMany().HasForeignKey("UserId"),
40 |                     j =>
41 |                     {
42 |                         j.HasKey("UserId", "RoleId");
43 |                         j.ToTable("UserRoles");
44 |                     });
45 |         });
46 | 
47 |         OnModelCreatingPartial(modelBuilder);
48 |     }
49 | 
50 |     partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
51 | }


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Views/Home/Index.cshtml:
--------------------------------------------------------------------------------
 1 | @model IEnumerable<ProductModel>
 2 | 
 3 | <div class="container my-4">
 4 |     <div class="row g-4">
 5 |         @foreach (var product in Model)
 6 |         {
 7 |             <div class="col-6 col-md-4 col-lg-3">
 8 |                 <div class="card product-card h-100">
 9 | 
10 |                     <!-- Image -->
11 |                     <div class="product-image-wrapper">
12 |                         <img src="@product.ImageUrl"
13 |                              alt="@product.Name"
14 |                              class="product-image"
15 |                              onerror="this.src='/images/no-image.png'" />
16 | 
17 |                         <!-- Quick View (desktop hover) -->
18 |                         <div class="quick-view d-none d-md-flex">
19 |                             <button class="btn btn-light btn-sm"
20 |                                     onclick="openQuickView('@product.Name','@product.Description','@product.ImageUrl','@product.UnitPrice')">
21 |                                 Quick View
22 |                             </button>
23 |                         </div>
24 |                     </div>
25 | 
26 |                     <!-- Content -->
27 |                     <div class="card-body d-flex flex-column">
28 |                         <h6 class="fw-semibold text-truncate">@product.Name</h6>
29 | 
30 |                         <span class="price mb-2">
31 |                             $@product.UnitPrice.ToString("0.00")
32 |                         </span>
33 | 
34 |                         <!-- Mobile Add to Cart -->
35 |                         <button class="btn btn-primary btn-sm mt-auto add-to-cart"
36 |                                 onclick="addToCart(this)">
37 |                             🛒 Add to Cart
38 |                         </button>
39 |                     </div>
40 |                 </div>
41 |             </div>
42 |         }
43 |     </div>
44 | </div>
45 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Infrastructure/efpt.config.json:
--------------------------------------------------------------------------------
 1 | {
 2 |    "CodeGenerationMode": 6,
 3 |    "ContextClassName": "CatalogServiceContext",
 4 |    "ContextNamespace": null,
 5 |    "FilterSchemas": false,
 6 |    "IncludeConnectionString": false,
 7 |    "IrregularWords": null,
 8 |    "MinimumProductVersion": "2.6.1248",
 9 |    "ModelNamespace": null,
10 |    "OutputContextPath": ".\/Persistance",
11 |    "OutputPath": "Models",
12 |    "PluralRules": null,
13 |    "PreserveCasingWithRegex": true,
14 |    "ProjectRootNamespace": "CatalogService.Infrastructure",
15 |    "Schemas": null,
16 |    "SelectedHandlebarsLanguage": 2,
17 |    "SelectedToBeGenerated": 1,
18 |    "SingularRules": null,
19 |    "T4TemplatePath": null,
20 |    "Tables": [
21 |       {
22 |          "Name": "[dbo].[Categories]",
23 |          "ObjectType": 0
24 |       },
25 |       {
26 |          "Name": "[dbo].[Products]",
27 |          "ObjectType": 0
28 |       }
29 |    ],
30 |    "UiHint": null,
31 |    "UncountableWords": null,
32 |    "UseAsyncStoredProcedureCalls": true,
33 |    "UseBoolPropertiesWithoutDefaultSql": false,
34 |    "UseDatabaseNames": false,
35 |    "UseDatabaseNamesForRoutines": true,
36 |    "UseDateOnlyTimeOnly": true,
37 |    "UseDbContextSplitting": false,
38 |    "UseDecimalDataAnnotationForSprocResult": true,
39 |    "UseFluentApiOnly": true,
40 |    "UseHandleBars": false,
41 |    "UseHierarchyId": false,
42 |    "UseInflector": true,
43 |    "UseInternalAccessModifiersForSprocsAndFunctions": false,
44 |    "UseLegacyPluralizer": false,
45 |    "UseManyToManyEntity": false,
46 |    "UseNoDefaultConstructor": false,
47 |    "UseNoNavigations": false,
48 |    "UseNoObjectFilter": false,
49 |    "UseNodaTime": false,
50 |    "UseNullableReferences": false,
51 |    "UsePrefixNavigationNaming": false,
52 |    "UseSchemaFolders": false,
53 |    "UseSchemaNamespaces": false,
54 |    "UseSpatial": false,
55 |    "UseT4": false,
56 |    "UseT4Split": false
57 | }


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Domain/efpt.config.json:
--------------------------------------------------------------------------------
 1 | {
 2 |    "CodeGenerationMode": 6,
 3 |    "ContextClassName": "AuthServiceContext",
 4 |    "ContextNamespace": null,
 5 |    "FilterSchemas": false,
 6 |    "IncludeConnectionString": false,
 7 |    "IrregularWords": null,
 8 |    "MinimumProductVersion": "2.6.1248",
 9 |    "ModelNamespace": null,
10 |    "OutputContextPath": null,
11 |    "OutputPath": "Entities",
12 |    "PluralRules": null,
13 |    "PreserveCasingWithRegex": true,
14 |    "ProjectRootNamespace": "AuthService.Domain",
15 |    "Schemas": null,
16 |    "SelectedHandlebarsLanguage": 2,
17 |    "SelectedToBeGenerated": 2,
18 |    "SingularRules": null,
19 |    "T4TemplatePath": null,
20 |    "Tables": [
21 |       {
22 |          "Name": "[dbo].[Roles]",
23 |          "ObjectType": 0
24 |       },
25 |       {
26 |          "Name": "[dbo].[UserRoles]",
27 |          "ObjectType": 0
28 |       },
29 |       {
30 |          "Name": "[dbo].[Users]",
31 |          "ObjectType": 0
32 |       }
33 |    ],
34 |    "UiHint": null,
35 |    "UncountableWords": null,
36 |    "UseAsyncStoredProcedureCalls": true,
37 |    "UseBoolPropertiesWithoutDefaultSql": false,
38 |    "UseDatabaseNames": false,
39 |    "UseDatabaseNamesForRoutines": true,
40 |    "UseDateOnlyTimeOnly": true,
41 |    "UseDbContextSplitting": false,
42 |    "UseDecimalDataAnnotationForSprocResult": true,
43 |    "UseFluentApiOnly": true,
44 |    "UseHandleBars": false,
45 |    "UseHierarchyId": false,
46 |    "UseInflector": true,
47 |    "UseInternalAccessModifiersForSprocsAndFunctions": false,
48 |    "UseLegacyPluralizer": false,
49 |    "UseManyToManyEntity": false,
50 |    "UseNoDefaultConstructor": false,
51 |    "UseNoNavigations": false,
52 |    "UseNoObjectFilter": false,
53 |    "UseNodaTime": false,
54 |    "UseNullableReferences": false,
55 |    "UsePrefixNavigationNaming": false,
56 |    "UseSchemaFolders": false,
57 |    "UseSchemaNamespaces": false,
58 |    "UseSpatial": false,
59 |    "UseT4": false,
60 |    "UseT4Split": false
61 | }


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Infrastructure/efpt.config.json:
--------------------------------------------------------------------------------
 1 | {
 2 |    "CodeGenerationMode": 6,
 3 |    "ContextClassName": "AuthServiceContext",
 4 |    "ContextNamespace": null,
 5 |    "FilterSchemas": false,
 6 |    "IncludeConnectionString": false,
 7 |    "IrregularWords": null,
 8 |    "MinimumProductVersion": "2.6.1248",
 9 |    "ModelNamespace": null,
10 |    "OutputContextPath": ".\/Presistance",
11 |    "OutputPath": "Models",
12 |    "PluralRules": null,
13 |    "PreserveCasingWithRegex": true,
14 |    "ProjectRootNamespace": "AuthService.Infrastructure",
15 |    "Schemas": null,
16 |    "SelectedHandlebarsLanguage": 2,
17 |    "SelectedToBeGenerated": 1,
18 |    "SingularRules": null,
19 |    "T4TemplatePath": null,
20 |    "Tables": [
21 |       {
22 |          "Name": "[dbo].[Roles]",
23 |          "ObjectType": 0
24 |       },
25 |       {
26 |          "Name": "[dbo].[UserRoles]",
27 |          "ObjectType": 0
28 |       },
29 |       {
30 |          "Name": "[dbo].[Users]",
31 |          "ObjectType": 0
32 |       }
33 |    ],
34 |    "UiHint": null,
35 |    "UncountableWords": null,
36 |    "UseAsyncStoredProcedureCalls": true,
37 |    "UseBoolPropertiesWithoutDefaultSql": false,
38 |    "UseDatabaseNames": false,
39 |    "UseDatabaseNamesForRoutines": true,
40 |    "UseDateOnlyTimeOnly": true,
41 |    "UseDbContextSplitting": false,
42 |    "UseDecimalDataAnnotationForSprocResult": true,
43 |    "UseFluentApiOnly": true,
44 |    "UseHandleBars": false,
45 |    "UseHierarchyId": false,
46 |    "UseInflector": true,
47 |    "UseInternalAccessModifiersForSprocsAndFunctions": false,
48 |    "UseLegacyPluralizer": false,
49 |    "UseManyToManyEntity": false,
50 |    "UseNoDefaultConstructor": false,
51 |    "UseNoNavigations": false,
52 |    "UseNoObjectFilter": false,
53 |    "UseNodaTime": false,
54 |    "UseNullableReferences": false,
55 |    "UsePrefixNavigationNaming": false,
56 |    "UseSchemaFolders": false,
57 |    "UseSchemaNamespaces": false,
58 |    "UseSpatial": false,
59 |    "UseT4": false,
60 |    "UseT4Split": false
61 | }


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Program.cs:
--------------------------------------------------------------------------------
 1 | using Microsoft.AspNetCore.Authentication.Cookies;
 2 | using Tom_s_E_shop.HttpClients;
 3 | 
 4 | var builder = WebApplication.CreateBuilder(args);
 5 | 
 6 | // Add services to the container.
 7 | builder.Services.AddControllersWithViews();
 8 | builder.Services.AddHttpClient("HttpClient",client =>
 9 | {
10 |     client.BaseAddress = new Uri(builder.Configuration["ApiGatewayAddress"]);
11 | });
12 | 
13 | builder.Services.AddScoped<AuthServiceClient>(provider => { 
14 |     var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
15 |     var httpClient = httpClientFactory.CreateClient("HttpClient");
16 |     return new AuthServiceClient(httpClient);
17 | });
18 | 
19 | builder.Services.AddScoped<CatalogServiceClient>(provider =>
20 | {
21 |     var httpClientFactory = provider.GetRequiredService<IHttpClientFactory>();
22 |     var httpClient = httpClientFactory.CreateClient("HttpClient");
23 |     return new CatalogServiceClient(httpClient);
24 | });
25 | builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
26 |     .AddCookie(options =>
27 |     {
28 |         options.Cookie.Name = "Tomshop";
29 |         options.LoginPath = "/Account/Login";
30 |     });
31 | 
32 | var app = builder.Build();
33 | 
34 | // Configure the HTTP request pipeline.
35 | if (!app.Environment.IsDevelopment())
36 | {
37 |     app.UseExceptionHandler("/Home/Error");
38 |     // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
39 |     app.UseHsts();
40 | }
41 | 
42 | app.UseHttpsRedirection();
43 | app.UseRouting();
44 | 
45 | app.UseAuthentication();
46 | app.UseAuthorization();
47 | 
48 | app.MapStaticAssets();
49 | 
50 | app.MapControllerRoute(
51 |       name: "areas",
52 |       pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
53 |     );
54 | 
55 | app.MapControllerRoute(
56 |     name: "default",
57 |     pattern: "{controller=Home}/{action=Index}/{id?}")
58 |     .WithStaticAssets();
59 | 
60 | 
61 | app.Run();
62 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.API/Controllers/CatalogController.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Application.Interfaces;
 2 | using CatalogService.Application.Services;
 3 | using Microsoft.AspNetCore.Http;
 4 | using Microsoft.AspNetCore.Mvc;
 5 | 
 6 | namespace CatalogService.API.Controllers
 7 | {
 8 |     [Route("api/[controller]/[action]")]
 9 |     [ApiController]
10 |     public class CatalogController : ControllerBase
11 |     {
12 |         private readonly IProductAppService _productAppService;
13 |         public CatalogController(ProductAppService productAppService)
14 |         {
15 |             _productAppService = productAppService;
16 |         }
17 | 
18 |         [HttpGet]
19 |         public IActionResult GetAllProducts()
20 |         {
21 |             var products = _productAppService.GetAll();
22 |             return Ok(products);
23 |         }
24 | 
25 |         [HttpGet("{id}")]
26 |         public IActionResult GetProductById(int id)
27 |         {
28 |             try
29 |             {
30 |                 var product = _productAppService.GetById(id);
31 |                 if (product == null)
32 |                 {
33 |                     return NotFound();
34 |                 }
35 |                 return Ok(product);
36 |             }
37 |             catch (Exception ex)
38 |             {
39 |                 return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
40 |             }
41 |         }
42 | 
43 |         [HttpGet]
44 |         public IActionResult GetProductsByIds([FromQuery] int[] ids)
45 |         {
46 |             try
47 |             {
48 |                 var products = _productAppService.GetByIds(ids);
49 |                 if (products == null || !products.Any())
50 |                 {
51 |                     return NotFound();
52 |                 }
53 |                 return Ok(products);
54 | 
55 |             }
56 |             catch (Exception ex)
57 |             {
58 |                 return StatusCode(StatusCodes.Status500InternalServerError, $"Internal server error: {ex.Message}");
59 |             }
60 |         }
61 |     }
62 | }
63 | 


--------------------------------------------------------------------------------
/CatalogService.API/Controllers/CatalogController.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Application.Interfaces;
 2 | using Microsoft.AspNetCore.Http;
 3 | using Microsoft.AspNetCore.Mvc;
 4 | 
 5 | namespace CatalogService.API.Controllers
 6 | {
 7 |     [Route("api/[controller]/[action]")]
 8 |     [ApiController]
 9 |     public class CatalogController : ControllerBase
10 |     {
11 |         private readonly IProductAppService _productAppService;
12 |         public CatalogController(IProductAppService productAppService)
13 |         {
14 |             _productAppService = productAppService;
15 |         }
16 |         [HttpGet]
17 |         public IActionResult GetProducts()
18 |         {
19 |             var products = _productAppService.GetAll();
20 |             if (products == null)
21 |             {
22 |                 return NotFound();
23 |             }
24 |             return Ok(products);
25 |         }
26 | 
27 |        [HttpGet]
28 |         public IActionResult GetProductById(int id)
29 |         {
30 |             try
31 |             {
32 |                 var product = _productAppService.GetById(id);
33 |                 if (product == null)
34 |                 {
35 |                     return NotFound();
36 |                 }
37 |                 return Ok(product);
38 |             }
39 |             catch (Exception ex)
40 |             {
41 |                 return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
42 |             }
43 |         }
44 | 
45 |        
46 |         [HttpPost]
47 |         public IActionResult GetProductsByIds([FromBody] int[] ids)
48 |         {
49 |             try
50 |             {
51 |                 var products = _productAppService.GetByIds(ids);
52 |                 if (products == null)
53 |                 {
54 |                     return NotFound();
55 |                 }
56 |                 return Ok(products);
57 |             }
58 |             catch (Exception ex)
59 |             {
60 |                 return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred while processing your request.");
61 |             }
62 |         }
63 |     }
64 | }
65 | 


--------------------------------------------------------------------------------
/.gitattributes:
--------------------------------------------------------------------------------
 1 | ###############################################################################
 2 | # Set default behavior to automatically normalize line endings.
 3 | ###############################################################################
 4 | * text=auto
 5 | 
 6 | ###############################################################################
 7 | # Set default behavior for command prompt diff.
 8 | #
 9 | # This is need for earlier builds of msysgit that does not have it on by
10 | # default for csharp files.
11 | # Note: This is only used by command line
12 | ###############################################################################
13 | #*.cs     diff=csharp
14 | 
15 | ###############################################################################
16 | # Set the merge driver for project and solution files
17 | #
18 | # Merging from the command prompt will add diff markers to the files if there
19 | # are conflicts (Merging from VS is not affected by the settings below, in VS
20 | # the diff markers are never inserted). Diff markers may cause the following 
21 | # file extensions to fail to load in VS. An alternative would be to treat
22 | # these files as binary and thus will always conflict and require user
23 | # intervention with every merge. To do so, just uncomment the entries below
24 | ###############################################################################
25 | #*.sln       merge=binary
26 | #*.csproj    merge=binary
27 | #*.vbproj    merge=binary
28 | #*.vcxproj   merge=binary
29 | #*.vcproj    merge=binary
30 | #*.dbproj    merge=binary
31 | #*.fsproj    merge=binary
32 | #*.lsproj    merge=binary
33 | #*.wixproj   merge=binary
34 | #*.modelproj merge=binary
35 | #*.sqlproj   merge=binary
36 | #*.wwaproj   merge=binary
37 | 
38 | ###############################################################################
39 | # behavior for image files
40 | #
41 | # image files are treated as binary by default.
42 | ###############################################################################
43 | #*.jpg   binary
44 | #*.png   binary
45 | #*.gif   binary
46 | 
47 | ###############################################################################
48 | # diff behavior for common document formats
49 | # 
50 | # Convert binary document formats to text before diffing them. This feature
51 | # is only available from the command line. Turn it on by uncommenting the 
52 | # entries below.
53 | ###############################################################################
54 | #*.doc   diff=astextplain
55 | #*.DOC   diff=astextplain
56 | #*.docx  diff=astextplain
57 | #*.DOCX  diff=astextplain
58 | #*.dot   diff=astextplain
59 | #*.DOT   diff=astextplain
60 | #*.pdf   diff=astextplain
61 | #*.PDF   diff=astextplain
62 | #*.rtf   diff=astextplain
63 | #*.RTF   diff=astextplain
64 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Areas/User/Views/Shared/_Layout.cshtml:
--------------------------------------------------------------------------------
 1 | <!DOCTYPE html>
 2 | <html lang="en">
 3 | <head>
 4 |     <meta charset="utf-8" />
 5 |     <meta name="viewport" content="width=device-width, initial-scale=1.0" />
 6 |     <title>@ViewData["Title"] - Tom's E-shop</title>
 7 |     <script type="importmap"></script>
 8 |     <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
 9 |     <link rel="stylesheet" href="~/css/site.css" asp-append-version="true" />
10 |     <link rel="stylesheet" href="~/Tom_s_E_shop.styles.css" asp-append-version="true" />
11 | </head>
12 | <body>
13 |     <header>
14 |         <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3">
15 |             <div class="container-fluid">
16 |                 <a class="navbar-brand" asp-area="" asp-controller="Home" asp-action="Index">Tom's E-shop</a>
17 |                 <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" aria-controls="navbarSupportedContent"
18 |                         aria-expanded="false" aria-label="Toggle navigation">
19 |                     <span class="navbar-toggler-icon"></span>
20 |                 </button>
21 |                 <div class="navbar-collapse collapse d-sm-inline-flex justify-content-end">
22 |                     <ul class="navbar-nav flex-grow-1">
23 |                         <li class="nav-item">
24 |                             <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Index">Dashboard</a>
25 |                         </li>                       
26 |                     </ul>
27 |                     <ul class="navbar-nav flex-grow-1">
28 |                         <li class="nav-item">
29 |                             <span class="nav-link text-dark">Welcome : @CurrentUser.Name</span>
30 |                         </li>
31 |                         <li class="nav-item">
32 |                             <a class="nav-link text-dark" asp-area="" asp-controller="Account" asp-action="Logout">Logout</a>
33 |                         </li>
34 |                     </ul>
35 |                 </div>
36 |             </div>
37 |         </nav>
38 |     </header>
39 |     <div class="container">
40 |         <main role="main" class="pb-3">
41 |             @RenderBody()
42 |         </main>
43 |     </div>
44 | 
45 |     <footer class="border-top footer text-muted">
46 |         <div class="container">
47 |             &copy; 2025 - Tom's E-shop - <a asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
48 |         </div>
49 |     </footer>
50 |     <script src="~/lib/jquery/dist/jquery.min.js"></script>
51 |     <script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
52 |     <script src="~/js/site.js" asp-append-version="true"></script>
53 |     @await RenderSectionAsync("Scripts", required: false)
54 | </body>
55 | </html>
56 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Controllers/AccountController.cs:
--------------------------------------------------------------------------------
 1 | using Microsoft.AspNetCore.Authentication;
 2 | using Microsoft.AspNetCore.Authentication.Cookies;
 3 | using Microsoft.AspNetCore.Mvc;
 4 | using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
 5 | using System.Security.Claims;
 6 | using System.Text.Json;
 7 | using System.Threading.Tasks;
 8 | using Tom_s_E_shop.HttpClients;
 9 | using Tom_s_E_shop.Models;
10 | 
11 | namespace Tom_s_E_shop.Controllers
12 | {
13 |     public class AccountController : Controller
14 |     {
15 |         private readonly AuthServiceClient _authServiceClient;
16 | 
17 |         public AccountController(AuthServiceClient authServiceClient)
18 |         {
19 |             _authServiceClient = authServiceClient;
20 |         }
21 | 
22 |         [HttpGet]
23 |         public IActionResult Login()
24 |         {
25 |             return View();
26 |         }
27 | 
28 |         [HttpPost]
29 |         public IActionResult Login(LoginModel model ,string returnUrl = null) 
30 |         {
31 |             if (ModelState.IsValid)
32 |             {
33 |                 var user = _authServiceClient.Login(model);
34 |                 if (user != null)
35 |                 {
36 |                    GenerateTicket(user);
37 |                     if (user.Roles.Contains("User"))
38 |                     {
39 |                         return RedirectToAction("Index", "Home", new { area = "User" });
40 |                     }
41 |                 }
42 |                 else
43 |                 {
44 |                     ModelState.AddModelError(string.Empty, "Invalid login attempt.");
45 |                 }
46 |             }
47 |             return View(model);
48 |         }
49 | 
50 |         [HttpGet]
51 |         public async Task<IActionResult> Logout() {
52 |             await HttpContext.SignOutAsync();
53 |             return RedirectToAction("Login");
54 |         }
55 | 
56 |         public IActionResult UnAuthorize()
57 |         {
58 |             return View();
59 |         }
60 | 
61 |         #region Private Methods
62 |         private async void  GenerateTicket(UserModel user)
63 |         {
64 |             string strData = JsonSerializer.Serialize(user);
65 |             var claims = new List<Claim>
66 |             {
67 |                 new Claim(ClaimTypes.UserData, strData),
68 |                 new Claim(ClaimTypes.Email, user.Email),
69 |                 new Claim(ClaimTypes.Role, string.Join(",",user.Roles))
70 |             };          
71 | 
72 | 
73 | 
74 |             var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
75 |             var authProperties = new AuthenticationProperties
76 |             {
77 |                 IsPersistent = true,
78 |                 ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(60)
79 |             };
80 |             await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
81 |         }
82 |         #endregion 
83 |     }
84 | }
85 | 


--------------------------------------------------------------------------------
/BackendServices/CatalogService/CatalogService.Application/Services/ProductAppService.cs:
--------------------------------------------------------------------------------
 1 | using CatalogService.Application.DTOs;
 2 | using CatalogService.Application.Interfaces;
 3 | using CatalogService.Domain.Entities;
 4 | using CatalogService.Domain.Interfaces;
 5 | using MapsterMapper;
 6 | using Microsoft.Extensions.Configuration;
 7 | 
 8 | namespace CatalogService.Application.Services
 9 | {
10 |     public class ProductAppService : IProductAppService
11 |     {
12 |         private readonly IProductRepository _productRepository;
13 |         private readonly IMapper _mapper;
14 |         private readonly IConfiguration _configuration;
15 |         private readonly string _baseUrl;
16 |         public ProductAppService(IProductRepository productRepository, IMapper mapper, IConfiguration configuration)
17 |         {
18 |             _productRepository = productRepository;
19 |             _mapper = mapper;
20 |             _configuration = configuration;
21 |             _baseUrl = _configuration["ImageServer"] ?? string.Empty;
22 |         }
23 |         public void Add(ProductDTO productDto)
24 |         {
25 |             var entity = _mapper.Map<CatalogService.Domain.Entities.Product>(productDto);
26 |             _productRepository.Add(entity);
27 |             _productRepository.SaveChanges();
28 |         }
29 | 
30 |         public void Delete(int id)
31 |         {
32 |             _productRepository.Delete(id);
33 |             _productRepository.SaveChanges();
34 |         }
35 | 
36 |         public IEnumerable<ProductDTO> GetAll()
37 |         {
38 |             var products = _productRepository.GetAll();
39 |             if (products == null || !products.Any())
40 |             {
41 |                 return null;
42 |             }
43 |             foreach (var product in products)
44 |             {
45 |                 product.ImageUrl = _baseUrl+ product.ImageUrl;
46 |             }
47 |             return _mapper.Map<IEnumerable<ProductDTO>>(products);
48 |         }
49 | 
50 |         public ProductDTO GetById(int id)
51 |         {
52 |             var product = _productRepository.GetById(id);
53 |             if (product == null)
54 |             {
55 |                 return null;
56 |             }
57 |             product.ImageUrl = _baseUrl + product.ImageUrl;
58 |             return _mapper.Map<ProductDTO>(product);
59 |         }
60 | 
61 |         public IEnumerable<ProductDTO> GetByIds(int[] ids)
62 |         {
63 |             var products = _productRepository.GetByIds(ids);
64 |             if (products == null || !products.Any())
65 |             {
66 |                 return null;
67 |             }
68 |             foreach (var product in products)
69 |             {
70 |                 product.ImageUrl = _baseUrl + product.ImageUrl;
71 |             }
72 |             return _mapper.Map<IEnumerable<ProductDTO>>(products);
73 |         }
74 | 
75 |         public void Update(ProductDTO productDto)
76 |         {
77 |             var entity = _mapper.Map<Product>(productDto);
78 |             _productRepository.Update(entity);
79 |             _productRepository.SaveChanges();   
80 |         }
81 |     }
82 | }
83 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/css/site.css:
--------------------------------------------------------------------------------
  1 | html {
  2 |   font-size: 14px;
  3 | }
  4 | 
  5 | @media (min-width: 768px) {
  6 |   html {
  7 |     font-size: 16px;
  8 |   }
  9 | }
 10 | 
 11 | .btn:focus, .btn:active:focus, .btn-link.nav-link:focus, .form-control:focus, .form-check-input:focus {
 12 |   box-shadow: 0 0 0 0.1rem white, 0 0 0 0.25rem #258cfb;
 13 | }
 14 | 
 15 | html {
 16 |   position: relative;
 17 |   min-height: 100%;
 18 | }
 19 | 
 20 | body {
 21 |   margin-bottom: 60px;
 22 | }
 23 | 
 24 | .form-floating > .form-control-plaintext::placeholder, .form-floating > .form-control::placeholder {
 25 |   color: var(--bs-secondary-color);
 26 |   text-align: end;
 27 | }
 28 | 
 29 | .form-floating > .form-control-plaintext:focus::placeholder, .form-floating > .form-control:focus::placeholder {
 30 |   text-align: start;
 31 | }
 32 | 
 33 | .product-card {
 34 |     transition: transform 0.2s ease, box-shadow 0.2s ease;
 35 |     border-radius: 12px;
 36 | }
 37 | 
 38 |     .product-card:hover {
 39 |         transform: translateY(-5px);
 40 |         box-shadow: 0 12px 25px rgba(0, 0, 0, 0.12);
 41 |     }
 42 | 
 43 | .product-image-wrapper {
 44 |     height: 220px;
 45 |     background: #f8f9fa;
 46 |     display: flex;
 47 |     align-items: center;
 48 |     justify-content: center;
 49 |     border-top-left-radius: 12px;
 50 |     border-top-right-radius: 12px;
 51 |     overflow: hidden;
 52 | }
 53 | 
 54 | .product-image {
 55 |     max-height: 100%;
 56 |     max-width: 100%;
 57 |     object-fit: contain;
 58 |     padding: 10px;
 59 | }
 60 | 
 61 | .price {
 62 |     font-size: 1.1rem;
 63 |     font-weight: 600;
 64 |     color: #198754; /* bootstrap green */
 65 | }
 66 | 
 67 | .card-text {
 68 |     display: -webkit-box;
 69 |     -webkit-line-clamp: 2;
 70 |     -webkit-box-orient: vertical;
 71 |     overflow: hidden;
 72 | }
 73 | /* Card */
 74 | .product-card {
 75 |     border-radius: 14px;
 76 |     border: none;
 77 |     overflow: hidden;
 78 |     transition: transform 0.2s ease, box-shadow 0.2s ease;
 79 | }
 80 | 
 81 |     .product-card:hover {
 82 |         transform: translateY(-6px);
 83 |         box-shadow: 0 14px 30px rgba(0,0,0,0.12);
 84 |     }
 85 | 
 86 | /* Image */
 87 | .product-image-wrapper {
 88 |     position: relative;
 89 |     height: 200px;
 90 |     background: #f8f9fa;
 91 |     display: flex;
 92 |     align-items: center;
 93 |     justify-content: center;
 94 | }
 95 | 
 96 | .product-image {
 97 |     max-height: 100%;
 98 |     max-width: 100%;
 99 |     object-fit: contain;
100 |     padding: 12px;
101 | }
102 | 
103 | /* Price */
104 | .price {
105 |     font-size: 1.1rem;
106 |     font-weight: 600;
107 |     color: #198754;
108 | }
109 | 
110 | /* Quick View Overlay (desktop only) */
111 | .quick-view {
112 |     position: absolute;
113 |     inset: 0;
114 |     background: rgba(0,0,0,0.55);
115 |     align-items: center;
116 |     justify-content: center;
117 |     opacity: 0;
118 |     transition: opacity 0.25s ease;
119 | }
120 | 
121 | .product-card:hover .quick-view {
122 |     opacity: 1;
123 | }
124 | 
125 | /* Add to Cart animation */
126 | .add-to-cart {
127 |     transition: transform 0.15s ease, box-shadow 0.15s ease;
128 | }
129 | 
130 |     .add-to-cart:active {
131 |         transform: scale(0.92);
132 |     }
133 | 
134 | /* Mobile-first tweaks */
135 | @media (max-width: 576px) {
136 |     .product-image-wrapper {
137 |         height: 160px;
138 |     }
139 | 
140 |     .price {
141 |         font-size: 1rem;
142 |     }
143 | }
144 | 


--------------------------------------------------------------------------------
/BackendServices/AuthService/AuthService.Application/Services/UserAppServices.cs:
--------------------------------------------------------------------------------
  1 | using System;
  2 | using System.Collections.Generic;
  3 | using System.Linq;
  4 | using AuthService.Application.DTOs;
  5 | using AuthService.Application.Interfaces;
  6 | using AuthService.Domain.Entities;
  7 | using AuthService.Domain.Interfaces;
  8 | using MapsterMapper;
  9 | using BC =BCrypt.Net.BCrypt;
 10 | using Microsoft.Extensions.Configuration;
 11 | using Microsoft.IdentityModel.Tokens;
 12 | using System.IdentityModel.Tokens.Jwt;
 13 | using System.Security.Claims;
 14 | 
 15 | namespace AuthService.Application.Services
 16 | {
 17 |     public class UserAppServices : IUserAppService
 18 |     {
 19 |         private readonly IConfiguration configuration;
 20 |         private readonly IUserRepository _userRepository;
 21 |         private readonly IMapper _mapper;
 22 | 
 23 | 
 24 | 
 25 |         public UserAppServices(IUserRepository userRepository, IMapper mapper, IConfiguration configuration)
 26 |         {
 27 |             _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
 28 |             _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
 29 |             this.configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
 30 |         }
 31 |         public UserDTO LoginUser(LoginDTO loginDTO)
 32 |         {
 33 |             User user = _userRepository.GetUserByEmail(loginDTO.Email);
 34 |             if (user != null)
 35 |             {
 36 |                 bool isPasswordValid = BC.Verify(loginDTO.Password, user.Password);
 37 |                 if (isPasswordValid)
 38 |                 {
 39 |                     UserDTO data = _mapper.Map<UserDTO>(user);
 40 |                     //UserDTO userDTO = new UserDTO
 41 |                     //{
 42 |                     //    UserId = user.Id,
 43 |                     //    Name = user.Name,
 44 |                     //    Email = user.Email,
 45 |                     //    PhoneNumber = user.PhoneNumber,
 46 |                     //    Roles = user.Roles.Select(r => r.Name).ToArray(),
 47 |                     //    Token = "GeneratedJWTToken" // Placeholder for actual token generation logic
 48 |                     //};  
 49 |                     //return userDTO;
 50 |                     data.Token = GenerateJwtToken(data); // Placeholder for actual token generation logic
 51 |                     return data;
 52 |                 }
 53 |             }
 54 |             return null;
 55 |         }
 56 | 
 57 |         public bool SignUpUser(SignUpDTO signUpDTO, string roles)
 58 |         {
 59 |             User existingUser = _userRepository.GetUserByEmail(signUpDTO.Email);
 60 |             if (existingUser == null)
 61 |             {
 62 |                 User newUser = _mapper.Map<User>(signUpDTO);
 63 |                 //User newUser = new User
 64 |                 //{
 65 |                 //    Name = signUpDTO.Name,
 66 |                 //    Email = signUpDTO.Email,
 67 |                 //    Password = BC.HashPassword(signUpDTO.Password),
 68 |                 //    PhoneNumber = signUpDTO.PhoneNumber,
 69 |                 //    EmailConfirmed = false,
 70 |                 //    CreatedDate = DateTime.UtcNow
 71 |                 //};
 72 |                 return _userRepository.RegisterUser(newUser, roles);
 73 | 
 74 |             }
 75 |             return false;
 76 |         }
 77 | 
 78 |         private string GenerateJwtToken(UserDTO user)
 79 |         {
 80 |             // Implement JWT token generation logic here
 81 |             var key = configuration["Jwt:Key"];
 82 |             if (string.IsNullOrWhiteSpace(key))
 83 |                 throw new InvalidOperationException("JWT signing key is not configured. Set 'Jwt:Key' in configuration.");
 84 | 
 85 |             var securityKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(key));
 86 |             var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
 87 | 
 88 |             if (!int.TryParse(configuration["Jwt:ExpireMinutes"], out var expireMinutes) || expireMinutes <= 0)
 89 |                 expireMinutes = 60; // reasonable default
 90 | 
 91 |             var roles = user?.Roles ?? Array.Empty<string>();
 92 | 
 93 |             var claims = new List<Claim>
 94 |             {
 95 |                 new Claim(JwtRegisteredClaimNames.Sub, user?.Name ?? string.Empty),
 96 |                 new Claim(JwtRegisteredClaimNames.Email, user?.Email ?? string.Empty),
 97 |                 new Claim("Roles", string.Join(",", roles)),
 98 |                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
 99 |             };
100 | 
101 |             // Add individual role claims
102 |             foreach (var role in roles.Where(r => !string.IsNullOrWhiteSpace(r)))
103 |             {
104 |                 claims.Add(new Claim(ClaimTypes.Role, role));
105 |             }
106 | 
107 |             var token = new JwtSecurityToken(
108 |                 issuer: configuration["Jwt:Issuer"],
109 |                 audience: configuration["Jwt:Audience"],
110 |                 claims: claims,
111 |                 expires: DateTime.UtcNow.AddMinutes(expireMinutes),
112 |                 signingCredentials: credentials
113 |             );
114 |             return new JwtSecurityTokenHandler().WriteToken(token);
115 |         }
116 |     }
117 | }
118 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js:
--------------------------------------------------------------------------------
1 | /**
2 |  * @license
3 |  * Unobtrusive validation support library for jQuery and jQuery Validate
4 |  * Copyright (c) .NET Foundation. All rights reserved.
5 |  * Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
6 |  * @version v4.0.0
7 |  */
8 | !function(a){"function"==typeof define&&define.amd?define("jquery.validate.unobtrusive",["jquery-validation"],a):"object"==typeof module&&module.exports?module.exports=a(require("jquery-validation")):jQuery.validator.unobtrusive=a(jQuery)}(function(s){var a,o=s.validator,d="unobtrusiveValidation";function l(a,e,n){a.rules[e]=n,a.message&&(a.messages[e]=a.message)}function u(a){return a.replace(/([!"#$%&'()*+,./:;<=>?@\[\\\]^`{|}~])/g,"\\$1")}function n(a){return a.substr(0,a.lastIndexOf(".")+1)}function m(a,e){return a=0===a.indexOf("*.")?a.replace("*.",e):a}function f(a){var e=s(this),n="__jquery_unobtrusive_validation_form_reset";if(!e.data(n)){e.data(n,!0);try{e.data("validator").resetForm()}finally{e.removeData(n)}e.find(".validation-summary-errors").addClass("validation-summary-valid").removeClass("validation-summary-errors"),e.find(".field-validation-error").addClass("field-validation-valid").removeClass("field-validation-error").removeData("unobtrusiveContainer").find(">*").removeData("unobtrusiveContainer")}}function p(n){function a(a,e){(a=r[a])&&s.isFunction(a)&&a.apply(n,e)}var e=s(n),t=e.data(d),i=s.proxy(f,n),r=o.unobtrusive.options||{};return t||(t={options:{errorClass:r.errorClass||"input-validation-error",errorElement:r.errorElement||"span",errorPlacement:function(){!function(a,e){var e=s(this).find("[data-valmsg-for='"+u(e[0].name)+"']"),n=(n=e.attr("data-valmsg-replace"))?!1!==s.parseJSON(n):null;e.removeClass("field-validation-valid").addClass("field-validation-error"),a.data("unobtrusiveContainer",e),n?(e.empty(),a.removeClass("input-validation-error").appendTo(e)):a.hide()}.apply(n,arguments),a("errorPlacement",arguments)},invalidHandler:function(){!function(a,e){var n=s(this).find("[data-valmsg-summary=true]"),t=n.find("ul");t&&t.length&&e.errorList.length&&(t.empty(),n.addClass("validation-summary-errors").removeClass("validation-summary-valid"),s.each(e.errorList,function(){s("<li />").html(this.message).appendTo(t)}))}.apply(n,arguments),a("invalidHandler",arguments)},messages:{},rules:{},success:function(){!function(a){var e,n=a.data("unobtrusiveContainer");n&&(e=(e=n.attr("data-valmsg-replace"))?s.parseJSON(e):null,n.addClass("field-validation-valid").removeClass("field-validation-error"),a.removeData("unobtrusiveContainer"),e&&n.empty())}.apply(n,arguments),a("success",arguments)}},attachValidation:function(){e.off("reset."+d,i).on("reset."+d,i).validate(this.options)},validate:function(){return e.validate(),e.valid()}},e.data(d,t)),t}return o.unobtrusive={adapters:[],parseElement:function(t,a){var e,i,r,o=s(t),d=o.parents("form")[0];d&&((e=p(d)).options.rules[t.name]=i={},e.options.messages[t.name]=r={},s.each(this.adapters,function(){var a="data-val-"+this.name,e=o.attr(a),n={};void 0!==e&&(a+="-",s.each(this.params,function(){n[this]=o.attr(a+this)}),this.adapt({element:t,form:d,message:e,params:n,rules:i,messages:r}))}),s.extend(i,{__dummy__:!0}),a||e.attachValidation())},parse:function(a){var a=s(a),e=a.parents().addBack().filter("form").add(a.find("form")).has("[data-val=true]");a.find("[data-val=true]").each(function(){o.unobtrusive.parseElement(this,!0)}),e.each(function(){var a=p(this);a&&a.attachValidation()})}},(a=o.unobtrusive.adapters).add=function(a,e,n){return n||(n=e,e=[]),this.push({name:a,params:e,adapt:n}),this},a.addBool=function(e,n){return this.add(e,function(a){l(a,n||e,!0)})},a.addMinMax=function(a,t,i,r,e,n){return this.add(a,[e||"min",n||"max"],function(a){var e=a.params.min,n=a.params.max;e&&n?l(a,r,[e,n]):e?l(a,t,e):n&&l(a,i,n)})},a.addSingleVal=function(e,n,t){return this.add(e,[n||"val"],function(a){l(a,t||e,a.params[n])})},o.addMethod("__dummy__",function(a,e,n){return!0}),o.addMethod("regex",function(a,e,n){return!!this.optional(e)||(e=new RegExp(n).exec(a))&&0===e.index&&e[0].length===a.length}),o.addMethod("nonalphamin",function(a,e,n){var t;return t=n?(t=a.match(/\W/g))&&t.length>=n:t}),o.methods.extension?(a.addSingleVal("accept","mimtype"),a.addSingleVal("extension","extension")):a.addSingleVal("extension","extension","accept"),a.addSingleVal("regex","pattern"),a.addBool("creditcard").addBool("date").addBool("digits").addBool("email").addBool("number").addBool("url"),a.addMinMax("length","minlength","maxlength","rangelength").addMinMax("range","min","max","range"),a.addMinMax("minlength","minlength").addMinMax("maxlength","minlength","maxlength"),a.add("equalto",["other"],function(a){var e=n(a.element.name),e=m(a.params.other,e);l(a,"equalTo",s(a.form).find(":input").filter("[name='"+u(e)+"']")[0])}),a.add("required",function(a){"INPUT"===a.element.tagName.toUpperCase()&&"CHECKBOX"===a.element.type.toUpperCase()||l(a,"required",!0)}),a.add("remote",["url","type","additionalfields"],function(t){var i={url:t.params.url,type:t.params.type||"GET",data:{}},r=n(t.element.name);s.each((t.params.additionalfields||t.element.name).replace(/^\s+|\s+$/g,"").split(/\s*,\s*/g),function(a,e){var n=m(e,r);i.data[n]=function(){var a=s(t.form).find(":input").filter("[name='"+u(n)+"']");return a.is(":checkbox")?a.filter(":checked").val()||a.filter(":hidden").val()||"":a.is(":radio")?a.filter(":checked").val()||"":a.val()}}),l(t,"remote",i)}),a.add("password",["min","nonalphamin","regex"],function(a){a.params.min&&l(a,"minlength",a.params.min),a.params.nonalphamin&&l(a,"nonalphamin",a.params.nonalphamin),a.params.regex&&l(a,"regex",a.params.regex)}),a.add("fileextensions",["extensions"],function(a){l(a,"extension",a.params.extensions)}),s(function(){o.unobtrusive.parse(document)}),o.unobtrusive});


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/Views/Shared/_Layout.cshtml:
--------------------------------------------------------------------------------
  1 | <!DOCTYPE html>
  2 | <html lang="en">
  3 | <head>
  4 |     <meta charset="utf-8" />
  5 |     <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  6 |     <title>@ViewData["Title"] - Tom's E-shop</title>
  7 |     <script type="importmap"></script>
  8 |     <link rel="stylesheet" href="~/lib/bootstrap/dist/css/bootstrap.min.css" />
  9 |     <link rel="stylesheet" href="~/css/site.css" asp-append-version="true" />
 10 |     <link rel="stylesheet" href="~/Tom_s_E_shop.styles.css" asp-append-version="true" />
 11 | </head>
 12 | <body>
 13 |     <header>
 14 |         <nav class="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3">
 15 |             <div class="container-fluid">
 16 |                 <a class="navbar-brand" asp-area="" asp-controller="Home" asp-action="Index">Tom's E-shop</a>
 17 |                 <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target=".navbar-collapse" aria-controls="navbarSupportedContent"
 18 |                         aria-expanded="false" aria-label="Toggle navigation">
 19 |                     <span class="navbar-toggler-icon"></span>
 20 |                 </button>
 21 |                 <div class="navbar-collapse collapse d-sm-inline-flex justify-content-end">
 22 |                     <ul class="navbar-nav flex-grow-1">
 23 |                         <li class="nav-item">
 24 |                             <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Index">Home</a>
 25 |                         </li>
 26 |                         <li class="nav-item">
 27 |                             <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
 28 |                         </li>
 29 |                     </ul>
 30 |                     <ul class="navbar-nav flex-grow-1">
 31 |                         @if(CurrentUser != null)
 32 |                         {
 33 |                             <ul class="navbar-nav flex-grow-1">
 34 |                                 <li class="nav-item">
 35 |                                     <span class="nav-link text-dark">Welcome : @CurrentUser.Name</span>
 36 |                                 </li>
 37 |                                 <li class="nav-item">
 38 |                                     <a class="nav-link text-dark" asp-area="" asp-controller="Account" asp-action="Logout">Logout</a>
 39 |                                 </li>
 40 |                             </ul>
 41 |                         }
 42 |                         else
 43 |                         {
 44 |                             <ul>
 45 |                             <li class="nav-item">
 46 |                                 <a class="nav-link text-dark" asp-area="" asp-controller="Account" asp-action="Login">Login</a>
 47 |                             </li>
 48 |                             <li class="nav-item">
 49 |                                 <a class="nav-link text-dark" asp-area="" asp-controller="Account" asp-action="SignUp">SignUp</a>
 50 |                             </li>
 51 |                             </ul>
 52 |                         }
 53 |                     </ul>
 54 |                 </div>
 55 |             </div>
 56 |         </nav>
 57 |     </header>
 58 |     <div class="container">
 59 |         <main role="main" class="pb-3">
 60 |             @RenderBody()
 61 |         </main>
 62 |     </div>
 63 | 
 64 |     <footer class="border-top footer text-muted">
 65 |         <div class="container">
 66 |             &copy; 2025 - Tom's E-shop - <a asp-area="" asp-controller="Home" asp-action="Privacy">Privacy</a>
 67 |         </div>
 68 |     </footer>
 69 |     <script src="~/lib/jquery/dist/jquery.min.js"></script>
 70 |     <script src="~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"></script>
 71 |     <script src="~/js/site.js" asp-append-version="true"></script>
 72 |     <script>
 73 |         function addToCart(button) {
 74 |             button.innerText = "✔ Added";
 75 |             button.classList.remove("btn-primary");
 76 |             button.classList.add("btn-success");
 77 | 
 78 |             setTimeout(() => {
 79 |                 button.innerText = "🛒 Add to Cart";
 80 |                 button.classList.remove("btn-success");
 81 |                 button.classList.add("btn-primary");
 82 |             }, 1200);
 83 |         }
 84 | 
 85 |         function openQuickView(name, description, imageUrl, price) {
 86 |             const modalHtml = `
 87 |             <div class="modal fade" id="quickViewModal" tabindex="-1">
 88 |                 <div class="modal-dialog modal-dialog-centered">
 89 |                     <div class="modal-content">
 90 |                         <div class="modal-body text-center">
 91 |                             <img src="${imageUrl}" class="img-fluid mb-3" style="max-height:200px"/>
 92 |                             <h5>${name}</h5>
 93 |                             <p class="text-muted small">${description}</p>
 94 |                             <h6 class="text-success">$${price}</h6>
 95 |                             <button class="btn btn-primary mt-2" onclick="addToCart(this)">
 96 |                                 🛒 Add to Cart
 97 |                             </button>
 98 |                         </div>
 99 |                     </div>
100 |                 </div>
101 |             </div>`;
102 | 
103 |             document.body.insertAdjacentHTML("beforeend", modalHtml);
104 |             const modal = new bootstrap.Modal(document.getElementById("quickViewModal"));
105 |             modal.show();
106 | 
107 |             document.getElementById("quickViewModal").addEventListener("hidden.bs.modal", function () {
108 |                 this.remove();
109 |             });
110 |         }
111 |     </script>
112 |     @await RenderSectionAsync("Scripts", required: false)
113 | </body>
114 | </html>
115 | 


--------------------------------------------------------------------------------
/.gitignore:
--------------------------------------------------------------------------------
  1 | ## Ignore Visual Studio temporary files, build results, and
  2 | ## files generated by popular Visual Studio add-ons.
  3 | ##
  4 | ## Get latest from https://github.com/github/gitignore/blob/master/VisualStudio.gitignore
  5 | 
  6 | # User-specific files
  7 | *.rsuser
  8 | *.suo
  9 | *.user
 10 | *.userosscache
 11 | *.sln.docstates
 12 | 
 13 | # User-specific files (MonoDevelop/Xamarin Studio)
 14 | *.userprefs
 15 | 
 16 | # Mono auto generated files
 17 | mono_crash.*
 18 | 
 19 | # Build results
 20 | [Dd]ebug/
 21 | [Dd]ebugPublic/
 22 | [Rr]elease/
 23 | [Rr]eleases/
 24 | x64/
 25 | x86/
 26 | [Ww][Ii][Nn]32/
 27 | [Aa][Rr][Mm]/
 28 | [Aa][Rr][Mm]64/
 29 | bld/
 30 | [Bb]in/
 31 | [Oo]bj/
 32 | [Oo]ut/
 33 | [Ll]og/
 34 | [Ll]ogs/
 35 | 
 36 | # Visual Studio 2015/2017 cache/options directory
 37 | .vs/
 38 | # Uncomment if you have tasks that create the project's static files in wwwroot
 39 | #wwwroot/
 40 | 
 41 | # Visual Studio 2017 auto generated files
 42 | Generated\ Files/
 43 | 
 44 | # MSTest test Results
 45 | [Tt]est[Rr]esult*/
 46 | [Bb]uild[Ll]og.*
 47 | 
 48 | # NUnit
 49 | *.VisualState.xml
 50 | TestResult.xml
 51 | nunit-*.xml
 52 | 
 53 | # Build Results of an ATL Project
 54 | [Dd]ebugPS/
 55 | [Rr]eleasePS/
 56 | dlldata.c
 57 | 
 58 | # Benchmark Results
 59 | BenchmarkDotNet.Artifacts/
 60 | 
 61 | # .NET Core
 62 | project.lock.json
 63 | project.fragment.lock.json
 64 | artifacts/
 65 | 
 66 | # ASP.NET Scaffolding
 67 | ScaffoldingReadMe.txt
 68 | 
 69 | # StyleCop
 70 | StyleCopReport.xml
 71 | 
 72 | # Files built by Visual Studio
 73 | *_i.c
 74 | *_p.c
 75 | *_h.h
 76 | *.ilk
 77 | *.meta
 78 | *.obj
 79 | *.iobj
 80 | *.pch
 81 | *.pdb
 82 | *.ipdb
 83 | *.pgc
 84 | *.pgd
 85 | *.rsp
 86 | *.sbr
 87 | *.tlb
 88 | *.tli
 89 | *.tlh
 90 | *.tmp
 91 | *.tmp_proj
 92 | *_wpftmp.csproj
 93 | *.log
 94 | *.vspscc
 95 | *.vssscc
 96 | .builds
 97 | *.pidb
 98 | *.svclog
 99 | *.scc
100 | 
101 | # Chutzpah Test files
102 | _Chutzpah*
103 | 
104 | # Visual C++ cache files
105 | ipch/
106 | *.aps
107 | *.ncb
108 | *.opendb
109 | *.opensdf
110 | *.sdf
111 | *.cachefile
112 | *.VC.db
113 | *.VC.VC.opendb
114 | 
115 | # Visual Studio profiler
116 | *.psess
117 | *.vsp
118 | *.vspx
119 | *.sap
120 | 
121 | # Visual Studio Trace Files
122 | *.e2e
123 | 
124 | # TFS 2012 Local Workspace
125 | $tf/
126 | 
127 | # Guidance Automation Toolkit
128 | *.gpState
129 | 
130 | # ReSharper is a .NET coding add-in
131 | _ReSharper*/
132 | *.[Rr]e[Ss]harper
133 | *.DotSettings.user
134 | 
135 | # TeamCity is a build add-in
136 | _TeamCity*
137 | 
138 | # DotCover is a Code Coverage Tool
139 | *.dotCover
140 | 
141 | # AxoCover is a Code Coverage Tool
142 | .axoCover/*
143 | !.axoCover/settings.json
144 | 
145 | # Coverlet is a free, cross platform Code Coverage Tool
146 | coverage*.json
147 | coverage*.xml
148 | coverage*.info
149 | 
150 | # Visual Studio code coverage results
151 | *.coverage
152 | *.coveragexml
153 | 
154 | # NCrunch
155 | _NCrunch_*
156 | .*crunch*.local.xml
157 | nCrunchTemp_*
158 | 
159 | # MightyMoose
160 | *.mm.*
161 | AutoTest.Net/
162 | 
163 | # Web workbench (sass)
164 | .sass-cache/
165 | 
166 | # Installshield output folder
167 | [Ee]xpress/
168 | 
169 | # DocProject is a documentation generator add-in
170 | DocProject/buildhelp/
171 | DocProject/Help/*.HxT
172 | DocProject/Help/*.HxC
173 | DocProject/Help/*.hhc
174 | DocProject/Help/*.hhk
175 | DocProject/Help/*.hhp
176 | DocProject/Help/Html2
177 | DocProject/Help/html
178 | 
179 | # Click-Once directory
180 | publish/
181 | 
182 | # Publish Web Output
183 | *.[Pp]ublish.xml
184 | *.azurePubxml
185 | # Note: Comment the next line if you want to checkin your web deploy settings,
186 | # but database connection strings (with potential passwords) will be unencrypted
187 | *.pubxml
188 | *.publishproj
189 | 
190 | # Microsoft Azure Web App publish settings. Comment the next line if you want to
191 | # checkin your Azure Web App publish settings, but sensitive information contained
192 | # in these scripts will be unencrypted
193 | PublishScripts/
194 | 
195 | # NuGet Packages
196 | *.nupkg
197 | # NuGet Symbol Packages
198 | *.snupkg
199 | # The packages folder can be ignored because of Package Restore
200 | **/[Pp]ackages/*
201 | # except build/, which is used as an MSBuild target.
202 | !**/[Pp]ackages/build/
203 | # Uncomment if necessary however generally it will be regenerated when needed
204 | #!**/[Pp]ackages/repositories.config
205 | # NuGet v3's project.json files produces more ignorable files
206 | *.nuget.props
207 | *.nuget.targets
208 | 
209 | # Microsoft Azure Build Output
210 | csx/
211 | *.build.csdef
212 | 
213 | # Microsoft Azure Emulator
214 | ecf/
215 | rcf/
216 | 
217 | # Windows Store app package directories and files
218 | AppPackages/
219 | BundleArtifacts/
220 | Package.StoreAssociation.xml
221 | _pkginfo.txt
222 | *.appx
223 | *.appxbundle
224 | *.appxupload
225 | 
226 | # Visual Studio cache files
227 | # files ending in .cache can be ignored
228 | *.[Cc]ache
229 | # but keep track of directories ending in .cache
230 | !?*.[Cc]ache/
231 | 
232 | # Others
233 | ClientBin/
234 | ~$*
235 | *~
236 | *.dbmdl
237 | *.dbproj.schemaview
238 | *.jfm
239 | *.pfx
240 | *.publishsettings
241 | orleans.codegen.cs
242 | 
243 | # Including strong name files can present a security risk
244 | # (https://github.com/github/gitignore/pull/2483#issue-259490424)
245 | #*.snk
246 | 
247 | # Since there are multiple workflows, uncomment next line to ignore bower_components
248 | # (https://github.com/github/gitignore/pull/1529#issuecomment-104372622)
249 | #bower_components/
250 | 
251 | # RIA/Silverlight projects
252 | Generated_Code/
253 | 
254 | # Backup & report files from converting an old project file
255 | # to a newer Visual Studio version. Backup files are not needed,
256 | # because we have git ;-)
257 | _UpgradeReport_Files/
258 | Backup*/
259 | UpgradeLog*.XML
260 | UpgradeLog*.htm
261 | ServiceFabricBackup/
262 | *.rptproj.bak
263 | 
264 | # SQL Server files
265 | *.mdf
266 | *.ldf
267 | *.ndf
268 | 
269 | # Business Intelligence projects
270 | *.rdl.data
271 | *.bim.layout
272 | *.bim_*.settings
273 | *.rptproj.rsuser
274 | *- [Bb]ackup.rdl
275 | *- [Bb]ackup ([0-9]).rdl
276 | *- [Bb]ackup ([0-9][0-9]).rdl
277 | 
278 | # Microsoft Fakes
279 | FakesAssemblies/
280 | 
281 | # GhostDoc plugin setting file
282 | *.GhostDoc.xml
283 | 
284 | # Node.js Tools for Visual Studio
285 | .ntvs_analysis.dat
286 | node_modules/
287 | 
288 | # Visual Studio 6 build log
289 | *.plg
290 | 
291 | # Visual Studio 6 workspace options file
292 | *.opt
293 | 
294 | # Visual Studio 6 auto-generated workspace file (contains which files were open etc.)
295 | *.vbw
296 | 
297 | # Visual Studio LightSwitch build output
298 | **/*.HTMLClient/GeneratedArtifacts
299 | **/*.DesktopClient/GeneratedArtifacts
300 | **/*.DesktopClient/ModelManifest.xml
301 | **/*.Server/GeneratedArtifacts
302 | **/*.Server/ModelManifest.xml
303 | _Pvt_Extensions
304 | 
305 | # Paket dependency manager
306 | .paket/paket.exe
307 | paket-files/
308 | 
309 | # FAKE - F# Make
310 | .fake/
311 | 
312 | # CodeRush personal settings
313 | .cr/personal
314 | 
315 | # Python Tools for Visual Studio (PTVS)
316 | __pycache__/
317 | *.pyc
318 | 
319 | # Cake - Uncomment if you are using it
320 | # tools/**
321 | # !tools/packages.config
322 | 
323 | # Tabs Studio
324 | *.tss
325 | 
326 | # Telerik's JustMock configuration file
327 | *.jmconfig
328 | 
329 | # BizTalk build output
330 | *.btp.cs
331 | *.btm.cs
332 | *.odx.cs
333 | *.xsd.cs
334 | 
335 | # OpenCover UI analysis results
336 | OpenCover/
337 | 
338 | # Azure Stream Analytics local run output
339 | ASALocalRun/
340 | 
341 | # MSBuild Binary and Structured Log
342 | *.binlog
343 | 
344 | # NVidia Nsight GPU debugger configuration file
345 | *.nvuser
346 | 
347 | # MFractors (Xamarin productivity tool) working folder
348 | .mfractor/
349 | 
350 | # Local History for Visual Studio
351 | .localhistory/
352 | 
353 | # BeatPulse healthcheck temp database
354 | healthchecksdb
355 | 
356 | # Backup folder for Package Reference Convert tool in Visual Studio 2017
357 | MigrationBackup/
358 | 
359 | # Ionide (cross platform F# VS Code tools) working folder
360 | .ionide/
361 | 
362 | # Fody - auto-generated XML schema
363 | FodyWeavers.xsd


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.min.css:
--------------------------------------------------------------------------------
1 | /*!
2 |  * Bootstrap Reboot v5.3.3 (https://getbootstrap.com/)
3 |  * Copyright 2011-2024 The Bootstrap Authors
4 |  * Licensed under MIT (https://github.com/twbs/bootstrap/blob/main/LICENSE)
5 |  */:root,[data-bs-theme=light]{--bs-blue:#0d6efd;--bs-indigo:#6610f2;--bs-purple:#6f42c1;--bs-pink:#d63384;--bs-red:#dc3545;--bs-orange:#fd7e14;--bs-yellow:#ffc107;--bs-green:#198754;--bs-teal:#20c997;--bs-cyan:#0dcaf0;--bs-black:#000;--bs-white:#fff;--bs-gray:#6c757d;--bs-gray-dark:#343a40;--bs-gray-100:#f8f9fa;--bs-gray-200:#e9ecef;--bs-gray-300:#dee2e6;--bs-gray-400:#ced4da;--bs-gray-500:#adb5bd;--bs-gray-600:#6c757d;--bs-gray-700:#495057;--bs-gray-800:#343a40;--bs-gray-900:#212529;--bs-primary:#0d6efd;--bs-secondary:#6c757d;--bs-success:#198754;--bs-info:#0dcaf0;--bs-warning:#ffc107;--bs-danger:#dc3545;--bs-light:#f8f9fa;--bs-dark:#212529;--bs-primary-rgb:13,110,253;--bs-secondary-rgb:108,117,125;--bs-success-rgb:25,135,84;--bs-info-rgb:13,202,240;--bs-warning-rgb:255,193,7;--bs-danger-rgb:220,53,69;--bs-light-rgb:248,249,250;--bs-dark-rgb:33,37,41;--bs-primary-text-emphasis:#052c65;--bs-secondary-text-emphasis:#2b2f32;--bs-success-text-emphasis:#0a3622;--bs-info-text-emphasis:#055160;--bs-warning-text-emphasis:#664d03;--bs-danger-text-emphasis:#58151c;--bs-light-text-emphasis:#495057;--bs-dark-text-emphasis:#495057;--bs-primary-bg-subtle:#cfe2ff;--bs-secondary-bg-subtle:#e2e3e5;--bs-success-bg-subtle:#d1e7dd;--bs-info-bg-subtle:#cff4fc;--bs-warning-bg-subtle:#fff3cd;--bs-danger-bg-subtle:#f8d7da;--bs-light-bg-subtle:#fcfcfd;--bs-dark-bg-subtle:#ced4da;--bs-primary-border-subtle:#9ec5fe;--bs-secondary-border-subtle:#c4c8cb;--bs-success-border-subtle:#a3cfbb;--bs-info-border-subtle:#9eeaf9;--bs-warning-border-subtle:#ffe69c;--bs-danger-border-subtle:#f1aeb5;--bs-light-border-subtle:#e9ecef;--bs-dark-border-subtle:#adb5bd;--bs-white-rgb:255,255,255;--bs-black-rgb:0,0,0;--bs-font-sans-serif:system-ui,-apple-system,"Segoe UI",Roboto,"Helvetica Neue","Noto Sans","Liberation Sans",Arial,sans-serif,"Apple Color Emoji","Segoe UI Emoji","Segoe UI Symbol","Noto Color Emoji";--bs-font-monospace:SFMono-Regular,Menlo,Monaco,Consolas,"Liberation Mono","Courier New",monospace;--bs-gradient:linear-gradient(180deg, rgba(255, 255, 255, 0.15), rgba(255, 255, 255, 0));--bs-body-font-family:var(--bs-font-sans-serif);--bs-body-font-size:1rem;--bs-body-font-weight:400;--bs-body-line-height:1.5;--bs-body-color:#212529;--bs-body-color-rgb:33,37,41;--bs-body-bg:#fff;--bs-body-bg-rgb:255,255,255;--bs-emphasis-color:#000;--bs-emphasis-color-rgb:0,0,0;--bs-secondary-color:rgba(33, 37, 41, 0.75);--bs-secondary-color-rgb:33,37,41;--bs-secondary-bg:#e9ecef;--bs-secondary-bg-rgb:233,236,239;--bs-tertiary-color:rgba(33, 37, 41, 0.5);--bs-tertiary-color-rgb:33,37,41;--bs-tertiary-bg:#f8f9fa;--bs-tertiary-bg-rgb:248,249,250;--bs-heading-color:inherit;--bs-link-color:#0d6efd;--bs-link-color-rgb:13,110,253;--bs-link-decoration:underline;--bs-link-hover-color:#0a58ca;--bs-link-hover-color-rgb:10,88,202;--bs-code-color:#d63384;--bs-highlight-color:#212529;--bs-highlight-bg:#fff3cd;--bs-border-width:1px;--bs-border-style:solid;--bs-border-color:#dee2e6;--bs-border-color-translucent:rgba(0, 0, 0, 0.175);--bs-border-radius:0.375rem;--bs-border-radius-sm:0.25rem;--bs-border-radius-lg:0.5rem;--bs-border-radius-xl:1rem;--bs-border-radius-xxl:2rem;--bs-border-radius-2xl:var(--bs-border-radius-xxl);--bs-border-radius-pill:50rem;--bs-box-shadow:0 0.5rem 1rem rgba(0, 0, 0, 0.15);--bs-box-shadow-sm:0 0.125rem 0.25rem rgba(0, 0, 0, 0.075);--bs-box-shadow-lg:0 1rem 3rem rgba(0, 0, 0, 0.175);--bs-box-shadow-inset:inset 0 1px 2px rgba(0, 0, 0, 0.075);--bs-focus-ring-width:0.25rem;--bs-focus-ring-opacity:0.25;--bs-focus-ring-color:rgba(13, 110, 253, 0.25);--bs-form-valid-color:#198754;--bs-form-valid-border-color:#198754;--bs-form-invalid-color:#dc3545;--bs-form-invalid-border-color:#dc3545}[data-bs-theme=dark]{color-scheme:dark;--bs-body-color:#dee2e6;--bs-body-color-rgb:222,226,230;--bs-body-bg:#212529;--bs-body-bg-rgb:33,37,41;--bs-emphasis-color:#fff;--bs-emphasis-color-rgb:255,255,255;--bs-secondary-color:rgba(222, 226, 230, 0.75);--bs-secondary-color-rgb:222,226,230;--bs-secondary-bg:#343a40;--bs-secondary-bg-rgb:52,58,64;--bs-tertiary-color:rgba(222, 226, 230, 0.5);--bs-tertiary-color-rgb:222,226,230;--bs-tertiary-bg:#2b3035;--bs-tertiary-bg-rgb:43,48,53;--bs-primary-text-emphasis:#6ea8fe;--bs-secondary-text-emphasis:#a7acb1;--bs-success-text-emphasis:#75b798;--bs-info-text-emphasis:#6edff6;--bs-warning-text-emphasis:#ffda6a;--bs-danger-text-emphasis:#ea868f;--bs-light-text-emphasis:#f8f9fa;--bs-dark-text-emphasis:#dee2e6;--bs-primary-bg-subtle:#031633;--bs-secondary-bg-subtle:#161719;--bs-success-bg-subtle:#051b11;--bs-info-bg-subtle:#032830;--bs-warning-bg-subtle:#332701;--bs-danger-bg-subtle:#2c0b0e;--bs-light-bg-subtle:#343a40;--bs-dark-bg-subtle:#1a1d20;--bs-primary-border-subtle:#084298;--bs-secondary-border-subtle:#41464b;--bs-success-border-subtle:#0f5132;--bs-info-border-subtle:#087990;--bs-warning-border-subtle:#997404;--bs-danger-border-subtle:#842029;--bs-light-border-subtle:#495057;--bs-dark-border-subtle:#343a40;--bs-heading-color:inherit;--bs-link-color:#6ea8fe;--bs-link-hover-color:#8bb9fe;--bs-link-color-rgb:110,168,254;--bs-link-hover-color-rgb:139,185,254;--bs-code-color:#e685b5;--bs-highlight-color:#dee2e6;--bs-highlight-bg:#664d03;--bs-border-color:#495057;--bs-border-color-translucent:rgba(255, 255, 255, 0.15);--bs-form-valid-color:#75b798;--bs-form-valid-border-color:#75b798;--bs-form-invalid-color:#ea868f;--bs-form-invalid-border-color:#ea868f}*,::after,::before{box-sizing:border-box}@media (prefers-reduced-motion:no-preference){:root{scroll-behavior:smooth}}body{margin:0;font-family:var(--bs-body-font-family);font-size:var(--bs-body-font-size);font-weight:var(--bs-body-font-weight);line-height:var(--bs-body-line-height);color:var(--bs-body-color);text-align:var(--bs-body-text-align);background-color:var(--bs-body-bg);-webkit-text-size-adjust:100%;-webkit-tap-highlight-color:transparent}hr{margin:1rem 0;color:inherit;border:0;border-top:var(--bs-border-width) solid;opacity:.25}h1,h2,h3,h4,h5,h6{margin-top:0;margin-bottom:.5rem;font-weight:500;line-height:1.2;color:var(--bs-heading-color)}h1{font-size:calc(1.375rem + 1.5vw)}@media (min-width:1200px){h1{font-size:2.5rem}}h2{font-size:calc(1.325rem + .9vw)}@media (min-width:1200px){h2{font-size:2rem}}h3{font-size:calc(1.3rem + .6vw)}@media (min-width:1200px){h3{font-size:1.75rem}}h4{font-size:calc(1.275rem + .3vw)}@media (min-width:1200px){h4{font-size:1.5rem}}h5{font-size:1.25rem}h6{font-size:1rem}p{margin-top:0;margin-bottom:1rem}abbr[title]{-webkit-text-decoration:underline dotted;text-decoration:underline dotted;cursor:help;-webkit-text-decoration-skip-ink:none;text-decoration-skip-ink:none}address{margin-bottom:1rem;font-style:normal;line-height:inherit}ol,ul{padding-left:2rem}dl,ol,ul{margin-top:0;margin-bottom:1rem}ol ol,ol ul,ul ol,ul ul{margin-bottom:0}dt{font-weight:700}dd{margin-bottom:.5rem;margin-left:0}blockquote{margin:0 0 1rem}b,strong{font-weight:bolder}small{font-size:.875em}mark{padding:.1875em;color:var(--bs-highlight-color);background-color:var(--bs-highlight-bg)}sub,sup{position:relative;font-size:.75em;line-height:0;vertical-align:baseline}sub{bottom:-.25em}sup{top:-.5em}a{color:rgba(var(--bs-link-color-rgb),var(--bs-link-opacity,1));text-decoration:underline}a:hover{--bs-link-color-rgb:var(--bs-link-hover-color-rgb)}a:not([href]):not([class]),a:not([href]):not([class]):hover{color:inherit;text-decoration:none}code,kbd,pre,samp{font-family:var(--bs-font-monospace);font-size:1em}pre{display:block;margin-top:0;margin-bottom:1rem;overflow:auto;font-size:.875em}pre code{font-size:inherit;color:inherit;word-break:normal}code{font-size:.875em;color:var(--bs-code-color);word-wrap:break-word}a>code{color:inherit}kbd{padding:.1875rem .375rem;font-size:.875em;color:var(--bs-body-bg);background-color:var(--bs-body-color);border-radius:.25rem}kbd kbd{padding:0;font-size:1em}figure{margin:0 0 1rem}img,svg{vertical-align:middle}table{caption-side:bottom;border-collapse:collapse}caption{padding-top:.5rem;padding-bottom:.5rem;color:var(--bs-secondary-color);text-align:left}th{text-align:inherit;text-align:-webkit-match-parent}tbody,td,tfoot,th,thead,tr{border-color:inherit;border-style:solid;border-width:0}label{display:inline-block}button{border-radius:0}button:focus:not(:focus-visible){outline:0}button,input,optgroup,select,textarea{margin:0;font-family:inherit;font-size:inherit;line-height:inherit}button,select{text-transform:none}[role=button]{cursor:pointer}select{word-wrap:normal}select:disabled{opacity:1}[list]:not([type=date]):not([type=datetime-local]):not([type=month]):not([type=week]):not([type=time])::-webkit-calendar-picker-indicator{display:none!important}[type=button],[type=reset],[type=submit],button{-webkit-appearance:button}[type=button]:not(:disabled),[type=reset]:not(:disabled),[type=submit]:not(:disabled),button:not(:disabled){cursor:pointer}::-moz-focus-inner{padding:0;border-style:none}textarea{resize:vertical}fieldset{min-width:0;padding:0;margin:0;border:0}legend{float:left;width:100%;padding:0;margin-bottom:.5rem;font-size:calc(1.275rem + .3vw);line-height:inherit}@media (min-width:1200px){legend{font-size:1.5rem}}legend+*{clear:left}::-webkit-datetime-edit-day-field,::-webkit-datetime-edit-fields-wrapper,::-webkit-datetime-edit-hour-field,::-webkit-datetime-edit-minute,::-webkit-datetime-edit-month-field,::-webkit-datetime-edit-text,::-webkit-datetime-edit-year-field{padding:0}::-webkit-inner-spin-button{height:auto}[type=search]{-webkit-appearance:textfield;outline-offset:-2px}::-webkit-search-decoration{-webkit-appearance:none}::-webkit-color-swatch-wrapper{padding:0}::-webkit-file-upload-button{font:inherit;-webkit-appearance:button}::file-selector-button{font:inherit;-webkit-appearance:button}output{display:inline-block}iframe{border:0}summary{display:list-item;cursor:pointer}progress{vertical-align:baseline}[hidden]{display:none!important}
6 | /*# sourceMappingURL=bootstrap-reboot.min.css.map */


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.min.css:
--------------------------------------------------------------------------------
1 | /*!
2 |  * Bootstrap Reboot v5.3.3 (https://getbootstrap.com/)
3 |  * Copyright 2011-2024 The Bootstrap Authors
4 |  * Licensed under MIT (https://github.com/twbs/bootstrap/blob/main/LICENSE)
5 |  */:root,[data-bs-theme=light]{--bs-blue:#0d6efd;--bs-indigo:#6610f2;--bs-purple:#6f42c1;--bs-pink:#d63384;--bs-red:#dc3545;--bs-orange:#fd7e14;--bs-yellow:#ffc107;--bs-green:#198754;--bs-teal:#20c997;--bs-cyan:#0dcaf0;--bs-black:#000;--bs-white:#fff;--bs-gray:#6c757d;--bs-gray-dark:#343a40;--bs-gray-100:#f8f9fa;--bs-gray-200:#e9ecef;--bs-gray-300:#dee2e6;--bs-gray-400:#ced4da;--bs-gray-500:#adb5bd;--bs-gray-600:#6c757d;--bs-gray-700:#495057;--bs-gray-800:#343a40;--bs-gray-900:#212529;--bs-primary:#0d6efd;--bs-secondary:#6c757d;--bs-success:#198754;--bs-info:#0dcaf0;--bs-warning:#ffc107;--bs-danger:#dc3545;--bs-light:#f8f9fa;--bs-dark:#212529;--bs-primary-rgb:13,110,253;--bs-secondary-rgb:108,117,125;--bs-success-rgb:25,135,84;--bs-info-rgb:13,202,240;--bs-warning-rgb:255,193,7;--bs-danger-rgb:220,53,69;--bs-light-rgb:248,249,250;--bs-dark-rgb:33,37,41;--bs-primary-text-emphasis:#052c65;--bs-secondary-text-emphasis:#2b2f32;--bs-success-text-emphasis:#0a3622;--bs-info-text-emphasis:#055160;--bs-warning-text-emphasis:#664d03;--bs-danger-text-emphasis:#58151c;--bs-light-text-emphasis:#495057;--bs-dark-text-emphasis:#495057;--bs-primary-bg-subtle:#cfe2ff;--bs-secondary-bg-subtle:#e2e3e5;--bs-success-bg-subtle:#d1e7dd;--bs-info-bg-subtle:#cff4fc;--bs-warning-bg-subtle:#fff3cd;--bs-danger-bg-subtle:#f8d7da;--bs-light-bg-subtle:#fcfcfd;--bs-dark-bg-subtle:#ced4da;--bs-primary-border-subtle:#9ec5fe;--bs-secondary-border-subtle:#c4c8cb;--bs-success-border-subtle:#a3cfbb;--bs-info-border-subtle:#9eeaf9;--bs-warning-border-subtle:#ffe69c;--bs-danger-border-subtle:#f1aeb5;--bs-light-border-subtle:#e9ecef;--bs-dark-border-subtle:#adb5bd;--bs-white-rgb:255,255,255;--bs-black-rgb:0,0,0;--bs-font-sans-serif:system-ui,-apple-system,"Segoe UI",Roboto,"Helvetica Neue","Noto Sans","Liberation Sans",Arial,sans-serif,"Apple Color Emoji","Segoe UI Emoji","Segoe UI Symbol","Noto Color Emoji";--bs-font-monospace:SFMono-Regular,Menlo,Monaco,Consolas,"Liberation Mono","Courier New",monospace;--bs-gradient:linear-gradient(180deg, rgba(255, 255, 255, 0.15), rgba(255, 255, 255, 0));--bs-body-font-family:var(--bs-font-sans-serif);--bs-body-font-size:1rem;--bs-body-font-weight:400;--bs-body-line-height:1.5;--bs-body-color:#212529;--bs-body-color-rgb:33,37,41;--bs-body-bg:#fff;--bs-body-bg-rgb:255,255,255;--bs-emphasis-color:#000;--bs-emphasis-color-rgb:0,0,0;--bs-secondary-color:rgba(33, 37, 41, 0.75);--bs-secondary-color-rgb:33,37,41;--bs-secondary-bg:#e9ecef;--bs-secondary-bg-rgb:233,236,239;--bs-tertiary-color:rgba(33, 37, 41, 0.5);--bs-tertiary-color-rgb:33,37,41;--bs-tertiary-bg:#f8f9fa;--bs-tertiary-bg-rgb:248,249,250;--bs-heading-color:inherit;--bs-link-color:#0d6efd;--bs-link-color-rgb:13,110,253;--bs-link-decoration:underline;--bs-link-hover-color:#0a58ca;--bs-link-hover-color-rgb:10,88,202;--bs-code-color:#d63384;--bs-highlight-color:#212529;--bs-highlight-bg:#fff3cd;--bs-border-width:1px;--bs-border-style:solid;--bs-border-color:#dee2e6;--bs-border-color-translucent:rgba(0, 0, 0, 0.175);--bs-border-radius:0.375rem;--bs-border-radius-sm:0.25rem;--bs-border-radius-lg:0.5rem;--bs-border-radius-xl:1rem;--bs-border-radius-xxl:2rem;--bs-border-radius-2xl:var(--bs-border-radius-xxl);--bs-border-radius-pill:50rem;--bs-box-shadow:0 0.5rem 1rem rgba(0, 0, 0, 0.15);--bs-box-shadow-sm:0 0.125rem 0.25rem rgba(0, 0, 0, 0.075);--bs-box-shadow-lg:0 1rem 3rem rgba(0, 0, 0, 0.175);--bs-box-shadow-inset:inset 0 1px 2px rgba(0, 0, 0, 0.075);--bs-focus-ring-width:0.25rem;--bs-focus-ring-opacity:0.25;--bs-focus-ring-color:rgba(13, 110, 253, 0.25);--bs-form-valid-color:#198754;--bs-form-valid-border-color:#198754;--bs-form-invalid-color:#dc3545;--bs-form-invalid-border-color:#dc3545}[data-bs-theme=dark]{color-scheme:dark;--bs-body-color:#dee2e6;--bs-body-color-rgb:222,226,230;--bs-body-bg:#212529;--bs-body-bg-rgb:33,37,41;--bs-emphasis-color:#fff;--bs-emphasis-color-rgb:255,255,255;--bs-secondary-color:rgba(222, 226, 230, 0.75);--bs-secondary-color-rgb:222,226,230;--bs-secondary-bg:#343a40;--bs-secondary-bg-rgb:52,58,64;--bs-tertiary-color:rgba(222, 226, 230, 0.5);--bs-tertiary-color-rgb:222,226,230;--bs-tertiary-bg:#2b3035;--bs-tertiary-bg-rgb:43,48,53;--bs-primary-text-emphasis:#6ea8fe;--bs-secondary-text-emphasis:#a7acb1;--bs-success-text-emphasis:#75b798;--bs-info-text-emphasis:#6edff6;--bs-warning-text-emphasis:#ffda6a;--bs-danger-text-emphasis:#ea868f;--bs-light-text-emphasis:#f8f9fa;--bs-dark-text-emphasis:#dee2e6;--bs-primary-bg-subtle:#031633;--bs-secondary-bg-subtle:#161719;--bs-success-bg-subtle:#051b11;--bs-info-bg-subtle:#032830;--bs-warning-bg-subtle:#332701;--bs-danger-bg-subtle:#2c0b0e;--bs-light-bg-subtle:#343a40;--bs-dark-bg-subtle:#1a1d20;--bs-primary-border-subtle:#084298;--bs-secondary-border-subtle:#41464b;--bs-success-border-subtle:#0f5132;--bs-info-border-subtle:#087990;--bs-warning-border-subtle:#997404;--bs-danger-border-subtle:#842029;--bs-light-border-subtle:#495057;--bs-dark-border-subtle:#343a40;--bs-heading-color:inherit;--bs-link-color:#6ea8fe;--bs-link-hover-color:#8bb9fe;--bs-link-color-rgb:110,168,254;--bs-link-hover-color-rgb:139,185,254;--bs-code-color:#e685b5;--bs-highlight-color:#dee2e6;--bs-highlight-bg:#664d03;--bs-border-color:#495057;--bs-border-color-translucent:rgba(255, 255, 255, 0.15);--bs-form-valid-color:#75b798;--bs-form-valid-border-color:#75b798;--bs-form-invalid-color:#ea868f;--bs-form-invalid-border-color:#ea868f}*,::after,::before{box-sizing:border-box}@media (prefers-reduced-motion:no-preference){:root{scroll-behavior:smooth}}body{margin:0;font-family:var(--bs-body-font-family);font-size:var(--bs-body-font-size);font-weight:var(--bs-body-font-weight);line-height:var(--bs-body-line-height);color:var(--bs-body-color);text-align:var(--bs-body-text-align);background-color:var(--bs-body-bg);-webkit-text-size-adjust:100%;-webkit-tap-highlight-color:transparent}hr{margin:1rem 0;color:inherit;border:0;border-top:var(--bs-border-width) solid;opacity:.25}h1,h2,h3,h4,h5,h6{margin-top:0;margin-bottom:.5rem;font-weight:500;line-height:1.2;color:var(--bs-heading-color)}h1{font-size:calc(1.375rem + 1.5vw)}@media (min-width:1200px){h1{font-size:2.5rem}}h2{font-size:calc(1.325rem + .9vw)}@media (min-width:1200px){h2{font-size:2rem}}h3{font-size:calc(1.3rem + .6vw)}@media (min-width:1200px){h3{font-size:1.75rem}}h4{font-size:calc(1.275rem + .3vw)}@media (min-width:1200px){h4{font-size:1.5rem}}h5{font-size:1.25rem}h6{font-size:1rem}p{margin-top:0;margin-bottom:1rem}abbr[title]{-webkit-text-decoration:underline dotted;text-decoration:underline dotted;cursor:help;-webkit-text-decoration-skip-ink:none;text-decoration-skip-ink:none}address{margin-bottom:1rem;font-style:normal;line-height:inherit}ol,ul{padding-right:2rem}dl,ol,ul{margin-top:0;margin-bottom:1rem}ol ol,ol ul,ul ol,ul ul{margin-bottom:0}dt{font-weight:700}dd{margin-bottom:.5rem;margin-right:0}blockquote{margin:0 0 1rem}b,strong{font-weight:bolder}small{font-size:.875em}mark{padding:.1875em;color:var(--bs-highlight-color);background-color:var(--bs-highlight-bg)}sub,sup{position:relative;font-size:.75em;line-height:0;vertical-align:baseline}sub{bottom:-.25em}sup{top:-.5em}a{color:rgba(var(--bs-link-color-rgb),var(--bs-link-opacity,1));text-decoration:underline}a:hover{--bs-link-color-rgb:var(--bs-link-hover-color-rgb)}a:not([href]):not([class]),a:not([href]):not([class]):hover{color:inherit;text-decoration:none}code,kbd,pre,samp{font-family:var(--bs-font-monospace);font-size:1em}pre{display:block;margin-top:0;margin-bottom:1rem;overflow:auto;font-size:.875em}pre code{font-size:inherit;color:inherit;word-break:normal}code{font-size:.875em;color:var(--bs-code-color);word-wrap:break-word}a>code{color:inherit}kbd{padding:.1875rem .375rem;font-size:.875em;color:var(--bs-body-bg);background-color:var(--bs-body-color);border-radius:.25rem}kbd kbd{padding:0;font-size:1em}figure{margin:0 0 1rem}img,svg{vertical-align:middle}table{caption-side:bottom;border-collapse:collapse}caption{padding-top:.5rem;padding-bottom:.5rem;color:var(--bs-secondary-color);text-align:right}th{text-align:inherit;text-align:-webkit-match-parent}tbody,td,tfoot,th,thead,tr{border-color:inherit;border-style:solid;border-width:0}label{display:inline-block}button{border-radius:0}button:focus:not(:focus-visible){outline:0}button,input,optgroup,select,textarea{margin:0;font-family:inherit;font-size:inherit;line-height:inherit}button,select{text-transform:none}[role=button]{cursor:pointer}select{word-wrap:normal}select:disabled{opacity:1}[list]:not([type=date]):not([type=datetime-local]):not([type=month]):not([type=week]):not([type=time])::-webkit-calendar-picker-indicator{display:none!important}[type=button],[type=reset],[type=submit],button{-webkit-appearance:button}[type=button]:not(:disabled),[type=reset]:not(:disabled),[type=submit]:not(:disabled),button:not(:disabled){cursor:pointer}::-moz-focus-inner{padding:0;border-style:none}textarea{resize:vertical}fieldset{min-width:0;padding:0;margin:0;border:0}legend{float:right;width:100%;padding:0;margin-bottom:.5rem;font-size:calc(1.275rem + .3vw);line-height:inherit}@media (min-width:1200px){legend{font-size:1.5rem}}legend+*{clear:right}::-webkit-datetime-edit-day-field,::-webkit-datetime-edit-fields-wrapper,::-webkit-datetime-edit-hour-field,::-webkit-datetime-edit-minute,::-webkit-datetime-edit-month-field,::-webkit-datetime-edit-text,::-webkit-datetime-edit-year-field{padding:0}::-webkit-inner-spin-button{height:auto}[type=search]{-webkit-appearance:textfield;outline-offset:-2px}[type=email],[type=number],[type=tel],[type=url]{direction:ltr}::-webkit-search-decoration{-webkit-appearance:none}::-webkit-color-swatch-wrapper{padding:0}::-webkit-file-upload-button{font:inherit;-webkit-appearance:button}::file-selector-button{font:inherit;-webkit-appearance:button}output{display:inline-block}iframe{border:0}summary{display:list-item;cursor:pointer}progress{vertical-align:baseline}[hidden]{display:none!important}
6 | /*# sourceMappingURL=bootstrap-reboot.rtl.min.css.map */


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.rtl.css:
--------------------------------------------------------------------------------
  1 | /*!
  2 |  * Bootstrap Reboot v5.3.3 (https://getbootstrap.com/)
  3 |  * Copyright 2011-2024 The Bootstrap Authors
  4 |  * Licensed under MIT (https://github.com/twbs/bootstrap/blob/main/LICENSE)
  5 |  */
  6 | :root,
  7 | [data-bs-theme=light] {
  8 |   --bs-blue: #0d6efd;
  9 |   --bs-indigo: #6610f2;
 10 |   --bs-purple: #6f42c1;
 11 |   --bs-pink: #d63384;
 12 |   --bs-red: #dc3545;
 13 |   --bs-orange: #fd7e14;
 14 |   --bs-yellow: #ffc107;
 15 |   --bs-green: #198754;
 16 |   --bs-teal: #20c997;
 17 |   --bs-cyan: #0dcaf0;
 18 |   --bs-black: #000;
 19 |   --bs-white: #fff;
 20 |   --bs-gray: #6c757d;
 21 |   --bs-gray-dark: #343a40;
 22 |   --bs-gray-100: #f8f9fa;
 23 |   --bs-gray-200: #e9ecef;
 24 |   --bs-gray-300: #dee2e6;
 25 |   --bs-gray-400: #ced4da;
 26 |   --bs-gray-500: #adb5bd;
 27 |   --bs-gray-600: #6c757d;
 28 |   --bs-gray-700: #495057;
 29 |   --bs-gray-800: #343a40;
 30 |   --bs-gray-900: #212529;
 31 |   --bs-primary: #0d6efd;
 32 |   --bs-secondary: #6c757d;
 33 |   --bs-success: #198754;
 34 |   --bs-info: #0dcaf0;
 35 |   --bs-warning: #ffc107;
 36 |   --bs-danger: #dc3545;
 37 |   --bs-light: #f8f9fa;
 38 |   --bs-dark: #212529;
 39 |   --bs-primary-rgb: 13, 110, 253;
 40 |   --bs-secondary-rgb: 108, 117, 125;
 41 |   --bs-success-rgb: 25, 135, 84;
 42 |   --bs-info-rgb: 13, 202, 240;
 43 |   --bs-warning-rgb: 255, 193, 7;
 44 |   --bs-danger-rgb: 220, 53, 69;
 45 |   --bs-light-rgb: 248, 249, 250;
 46 |   --bs-dark-rgb: 33, 37, 41;
 47 |   --bs-primary-text-emphasis: #052c65;
 48 |   --bs-secondary-text-emphasis: #2b2f32;
 49 |   --bs-success-text-emphasis: #0a3622;
 50 |   --bs-info-text-emphasis: #055160;
 51 |   --bs-warning-text-emphasis: #664d03;
 52 |   --bs-danger-text-emphasis: #58151c;
 53 |   --bs-light-text-emphasis: #495057;
 54 |   --bs-dark-text-emphasis: #495057;
 55 |   --bs-primary-bg-subtle: #cfe2ff;
 56 |   --bs-secondary-bg-subtle: #e2e3e5;
 57 |   --bs-success-bg-subtle: #d1e7dd;
 58 |   --bs-info-bg-subtle: #cff4fc;
 59 |   --bs-warning-bg-subtle: #fff3cd;
 60 |   --bs-danger-bg-subtle: #f8d7da;
 61 |   --bs-light-bg-subtle: #fcfcfd;
 62 |   --bs-dark-bg-subtle: #ced4da;
 63 |   --bs-primary-border-subtle: #9ec5fe;
 64 |   --bs-secondary-border-subtle: #c4c8cb;
 65 |   --bs-success-border-subtle: #a3cfbb;
 66 |   --bs-info-border-subtle: #9eeaf9;
 67 |   --bs-warning-border-subtle: #ffe69c;
 68 |   --bs-danger-border-subtle: #f1aeb5;
 69 |   --bs-light-border-subtle: #e9ecef;
 70 |   --bs-dark-border-subtle: #adb5bd;
 71 |   --bs-white-rgb: 255, 255, 255;
 72 |   --bs-black-rgb: 0, 0, 0;
 73 |   --bs-font-sans-serif: system-ui, -apple-system, "Segoe UI", Roboto, "Helvetica Neue", "Noto Sans", "Liberation Sans", Arial, sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji";
 74 |   --bs-font-monospace: SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
 75 |   --bs-gradient: linear-gradient(180deg, rgba(255, 255, 255, 0.15), rgba(255, 255, 255, 0));
 76 |   --bs-body-font-family: var(--bs-font-sans-serif);
 77 |   --bs-body-font-size: 1rem;
 78 |   --bs-body-font-weight: 400;
 79 |   --bs-body-line-height: 1.5;
 80 |   --bs-body-color: #212529;
 81 |   --bs-body-color-rgb: 33, 37, 41;
 82 |   --bs-body-bg: #fff;
 83 |   --bs-body-bg-rgb: 255, 255, 255;
 84 |   --bs-emphasis-color: #000;
 85 |   --bs-emphasis-color-rgb: 0, 0, 0;
 86 |   --bs-secondary-color: rgba(33, 37, 41, 0.75);
 87 |   --bs-secondary-color-rgb: 33, 37, 41;
 88 |   --bs-secondary-bg: #e9ecef;
 89 |   --bs-secondary-bg-rgb: 233, 236, 239;
 90 |   --bs-tertiary-color: rgba(33, 37, 41, 0.5);
 91 |   --bs-tertiary-color-rgb: 33, 37, 41;
 92 |   --bs-tertiary-bg: #f8f9fa;
 93 |   --bs-tertiary-bg-rgb: 248, 249, 250;
 94 |   --bs-heading-color: inherit;
 95 |   --bs-link-color: #0d6efd;
 96 |   --bs-link-color-rgb: 13, 110, 253;
 97 |   --bs-link-decoration: underline;
 98 |   --bs-link-hover-color: #0a58ca;
 99 |   --bs-link-hover-color-rgb: 10, 88, 202;
100 |   --bs-code-color: #d63384;
101 |   --bs-highlight-color: #212529;
102 |   --bs-highlight-bg: #fff3cd;
103 |   --bs-border-width: 1px;
104 |   --bs-border-style: solid;
105 |   --bs-border-color: #dee2e6;
106 |   --bs-border-color-translucent: rgba(0, 0, 0, 0.175);
107 |   --bs-border-radius: 0.375rem;
108 |   --bs-border-radius-sm: 0.25rem;
109 |   --bs-border-radius-lg: 0.5rem;
110 |   --bs-border-radius-xl: 1rem;
111 |   --bs-border-radius-xxl: 2rem;
112 |   --bs-border-radius-2xl: var(--bs-border-radius-xxl);
113 |   --bs-border-radius-pill: 50rem;
114 |   --bs-box-shadow: 0 0.5rem 1rem rgba(0, 0, 0, 0.15);
115 |   --bs-box-shadow-sm: 0 0.125rem 0.25rem rgba(0, 0, 0, 0.075);
116 |   --bs-box-shadow-lg: 0 1rem 3rem rgba(0, 0, 0, 0.175);
117 |   --bs-box-shadow-inset: inset 0 1px 2px rgba(0, 0, 0, 0.075);
118 |   --bs-focus-ring-width: 0.25rem;
119 |   --bs-focus-ring-opacity: 0.25;
120 |   --bs-focus-ring-color: rgba(13, 110, 253, 0.25);
121 |   --bs-form-valid-color: #198754;
122 |   --bs-form-valid-border-color: #198754;
123 |   --bs-form-invalid-color: #dc3545;
124 |   --bs-form-invalid-border-color: #dc3545;
125 | }
126 | 
127 | [data-bs-theme=dark] {
128 |   color-scheme: dark;
129 |   --bs-body-color: #dee2e6;
130 |   --bs-body-color-rgb: 222, 226, 230;
131 |   --bs-body-bg: #212529;
132 |   --bs-body-bg-rgb: 33, 37, 41;
133 |   --bs-emphasis-color: #fff;
134 |   --bs-emphasis-color-rgb: 255, 255, 255;
135 |   --bs-secondary-color: rgba(222, 226, 230, 0.75);
136 |   --bs-secondary-color-rgb: 222, 226, 230;
137 |   --bs-secondary-bg: #343a40;
138 |   --bs-secondary-bg-rgb: 52, 58, 64;
139 |   --bs-tertiary-color: rgba(222, 226, 230, 0.5);
140 |   --bs-tertiary-color-rgb: 222, 226, 230;
141 |   --bs-tertiary-bg: #2b3035;
142 |   --bs-tertiary-bg-rgb: 43, 48, 53;
143 |   --bs-primary-text-emphasis: #6ea8fe;
144 |   --bs-secondary-text-emphasis: #a7acb1;
145 |   --bs-success-text-emphasis: #75b798;
146 |   --bs-info-text-emphasis: #6edff6;
147 |   --bs-warning-text-emphasis: #ffda6a;
148 |   --bs-danger-text-emphasis: #ea868f;
149 |   --bs-light-text-emphasis: #f8f9fa;
150 |   --bs-dark-text-emphasis: #dee2e6;
151 |   --bs-primary-bg-subtle: #031633;
152 |   --bs-secondary-bg-subtle: #161719;
153 |   --bs-success-bg-subtle: #051b11;
154 |   --bs-info-bg-subtle: #032830;
155 |   --bs-warning-bg-subtle: #332701;
156 |   --bs-danger-bg-subtle: #2c0b0e;
157 |   --bs-light-bg-subtle: #343a40;
158 |   --bs-dark-bg-subtle: #1a1d20;
159 |   --bs-primary-border-subtle: #084298;
160 |   --bs-secondary-border-subtle: #41464b;
161 |   --bs-success-border-subtle: #0f5132;
162 |   --bs-info-border-subtle: #087990;
163 |   --bs-warning-border-subtle: #997404;
164 |   --bs-danger-border-subtle: #842029;
165 |   --bs-light-border-subtle: #495057;
166 |   --bs-dark-border-subtle: #343a40;
167 |   --bs-heading-color: inherit;
168 |   --bs-link-color: #6ea8fe;
169 |   --bs-link-hover-color: #8bb9fe;
170 |   --bs-link-color-rgb: 110, 168, 254;
171 |   --bs-link-hover-color-rgb: 139, 185, 254;
172 |   --bs-code-color: #e685b5;
173 |   --bs-highlight-color: #dee2e6;
174 |   --bs-highlight-bg: #664d03;
175 |   --bs-border-color: #495057;
176 |   --bs-border-color-translucent: rgba(255, 255, 255, 0.15);
177 |   --bs-form-valid-color: #75b798;
178 |   --bs-form-valid-border-color: #75b798;
179 |   --bs-form-invalid-color: #ea868f;
180 |   --bs-form-invalid-border-color: #ea868f;
181 | }
182 | 
183 | *,
184 | *::before,
185 | *::after {
186 |   box-sizing: border-box;
187 | }
188 | 
189 | @media (prefers-reduced-motion: no-preference) {
190 |   :root {
191 |     scroll-behavior: smooth;
192 |   }
193 | }
194 | 
195 | body {
196 |   margin: 0;
197 |   font-family: var(--bs-body-font-family);
198 |   font-size: var(--bs-body-font-size);
199 |   font-weight: var(--bs-body-font-weight);
200 |   line-height: var(--bs-body-line-height);
201 |   color: var(--bs-body-color);
202 |   text-align: var(--bs-body-text-align);
203 |   background-color: var(--bs-body-bg);
204 |   -webkit-text-size-adjust: 100%;
205 |   -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
206 | }
207 | 
208 | hr {
209 |   margin: 1rem 0;
210 |   color: inherit;
211 |   border: 0;
212 |   border-top: var(--bs-border-width) solid;
213 |   opacity: 0.25;
214 | }
215 | 
216 | h6, h5, h4, h3, h2, h1 {
217 |   margin-top: 0;
218 |   margin-bottom: 0.5rem;
219 |   font-weight: 500;
220 |   line-height: 1.2;
221 |   color: var(--bs-heading-color);
222 | }
223 | 
224 | h1 {
225 |   font-size: calc(1.375rem + 1.5vw);
226 | }
227 | @media (min-width: 1200px) {
228 |   h1 {
229 |     font-size: 2.5rem;
230 |   }
231 | }
232 | 
233 | h2 {
234 |   font-size: calc(1.325rem + 0.9vw);
235 | }
236 | @media (min-width: 1200px) {
237 |   h2 {
238 |     font-size: 2rem;
239 |   }
240 | }
241 | 
242 | h3 {
243 |   font-size: calc(1.3rem + 0.6vw);
244 | }
245 | @media (min-width: 1200px) {
246 |   h3 {
247 |     font-size: 1.75rem;
248 |   }
249 | }
250 | 
251 | h4 {
252 |   font-size: calc(1.275rem + 0.3vw);
253 | }
254 | @media (min-width: 1200px) {
255 |   h4 {
256 |     font-size: 1.5rem;
257 |   }
258 | }
259 | 
260 | h5 {
261 |   font-size: 1.25rem;
262 | }
263 | 
264 | h6 {
265 |   font-size: 1rem;
266 | }
267 | 
268 | p {
269 |   margin-top: 0;
270 |   margin-bottom: 1rem;
271 | }
272 | 
273 | abbr[title] {
274 |   -webkit-text-decoration: underline dotted;
275 |   text-decoration: underline dotted;
276 |   cursor: help;
277 |   -webkit-text-decoration-skip-ink: none;
278 |   text-decoration-skip-ink: none;
279 | }
280 | 
281 | address {
282 |   margin-bottom: 1rem;
283 |   font-style: normal;
284 |   line-height: inherit;
285 | }
286 | 
287 | ol,
288 | ul {
289 |   padding-right: 2rem;
290 | }
291 | 
292 | ol,
293 | ul,
294 | dl {
295 |   margin-top: 0;
296 |   margin-bottom: 1rem;
297 | }
298 | 
299 | ol ol,
300 | ul ul,
301 | ol ul,
302 | ul ol {
303 |   margin-bottom: 0;
304 | }
305 | 
306 | dt {
307 |   font-weight: 700;
308 | }
309 | 
310 | dd {
311 |   margin-bottom: 0.5rem;
312 |   margin-right: 0;
313 | }
314 | 
315 | blockquote {
316 |   margin: 0 0 1rem;
317 | }
318 | 
319 | b,
320 | strong {
321 |   font-weight: bolder;
322 | }
323 | 
324 | small {
325 |   font-size: 0.875em;
326 | }
327 | 
328 | mark {
329 |   padding: 0.1875em;
330 |   color: var(--bs-highlight-color);
331 |   background-color: var(--bs-highlight-bg);
332 | }
333 | 
334 | sub,
335 | sup {
336 |   position: relative;
337 |   font-size: 0.75em;
338 |   line-height: 0;
339 |   vertical-align: baseline;
340 | }
341 | 
342 | sub {
343 |   bottom: -0.25em;
344 | }
345 | 
346 | sup {
347 |   top: -0.5em;
348 | }
349 | 
350 | a {
351 |   color: rgba(var(--bs-link-color-rgb), var(--bs-link-opacity, 1));
352 |   text-decoration: underline;
353 | }
354 | a:hover {
355 |   --bs-link-color-rgb: var(--bs-link-hover-color-rgb);
356 | }
357 | 
358 | a:not([href]):not([class]), a:not([href]):not([class]):hover {
359 |   color: inherit;
360 |   text-decoration: none;
361 | }
362 | 
363 | pre,
364 | code,
365 | kbd,
366 | samp {
367 |   font-family: var(--bs-font-monospace);
368 |   font-size: 1em;
369 | }
370 | 
371 | pre {
372 |   display: block;
373 |   margin-top: 0;
374 |   margin-bottom: 1rem;
375 |   overflow: auto;
376 |   font-size: 0.875em;
377 | }
378 | pre code {
379 |   font-size: inherit;
380 |   color: inherit;
381 |   word-break: normal;
382 | }
383 | 
384 | code {
385 |   font-size: 0.875em;
386 |   color: var(--bs-code-color);
387 |   word-wrap: break-word;
388 | }
389 | a > code {
390 |   color: inherit;
391 | }
392 | 
393 | kbd {
394 |   padding: 0.1875rem 0.375rem;
395 |   font-size: 0.875em;
396 |   color: var(--bs-body-bg);
397 |   background-color: var(--bs-body-color);
398 |   border-radius: 0.25rem;
399 | }
400 | kbd kbd {
401 |   padding: 0;
402 |   font-size: 1em;
403 | }
404 | 
405 | figure {
406 |   margin: 0 0 1rem;
407 | }
408 | 
409 | img,
410 | svg {
411 |   vertical-align: middle;
412 | }
413 | 
414 | table {
415 |   caption-side: bottom;
416 |   border-collapse: collapse;
417 | }
418 | 
419 | caption {
420 |   padding-top: 0.5rem;
421 |   padding-bottom: 0.5rem;
422 |   color: var(--bs-secondary-color);
423 |   text-align: right;
424 | }
425 | 
426 | th {
427 |   text-align: inherit;
428 |   text-align: -webkit-match-parent;
429 | }
430 | 
431 | thead,
432 | tbody,
433 | tfoot,
434 | tr,
435 | td,
436 | th {
437 |   border-color: inherit;
438 |   border-style: solid;
439 |   border-width: 0;
440 | }
441 | 
442 | label {
443 |   display: inline-block;
444 | }
445 | 
446 | button {
447 |   border-radius: 0;
448 | }
449 | 
450 | button:focus:not(:focus-visible) {
451 |   outline: 0;
452 | }
453 | 
454 | input,
455 | button,
456 | select,
457 | optgroup,
458 | textarea {
459 |   margin: 0;
460 |   font-family: inherit;
461 |   font-size: inherit;
462 |   line-height: inherit;
463 | }
464 | 
465 | button,
466 | select {
467 |   text-transform: none;
468 | }
469 | 
470 | [role=button] {
471 |   cursor: pointer;
472 | }
473 | 
474 | select {
475 |   word-wrap: normal;
476 | }
477 | select:disabled {
478 |   opacity: 1;
479 | }
480 | 
481 | [list]:not([type=date]):not([type=datetime-local]):not([type=month]):not([type=week]):not([type=time])::-webkit-calendar-picker-indicator {
482 |   display: none !important;
483 | }
484 | 
485 | button,
486 | [type=button],
487 | [type=reset],
488 | [type=submit] {
489 |   -webkit-appearance: button;
490 | }
491 | button:not(:disabled),
492 | [type=button]:not(:disabled),
493 | [type=reset]:not(:disabled),
494 | [type=submit]:not(:disabled) {
495 |   cursor: pointer;
496 | }
497 | 
498 | ::-moz-focus-inner {
499 |   padding: 0;
500 |   border-style: none;
501 | }
502 | 
503 | textarea {
504 |   resize: vertical;
505 | }
506 | 
507 | fieldset {
508 |   min-width: 0;
509 |   padding: 0;
510 |   margin: 0;
511 |   border: 0;
512 | }
513 | 
514 | legend {
515 |   float: right;
516 |   width: 100%;
517 |   padding: 0;
518 |   margin-bottom: 0.5rem;
519 |   font-size: calc(1.275rem + 0.3vw);
520 |   line-height: inherit;
521 | }
522 | @media (min-width: 1200px) {
523 |   legend {
524 |     font-size: 1.5rem;
525 |   }
526 | }
527 | legend + * {
528 |   clear: right;
529 | }
530 | 
531 | ::-webkit-datetime-edit-fields-wrapper,
532 | ::-webkit-datetime-edit-text,
533 | ::-webkit-datetime-edit-minute,
534 | ::-webkit-datetime-edit-hour-field,
535 | ::-webkit-datetime-edit-day-field,
536 | ::-webkit-datetime-edit-month-field,
537 | ::-webkit-datetime-edit-year-field {
538 |   padding: 0;
539 | }
540 | 
541 | ::-webkit-inner-spin-button {
542 |   height: auto;
543 | }
544 | 
545 | [type=search] {
546 |   -webkit-appearance: textfield;
547 |   outline-offset: -2px;
548 | }
549 | 
550 | [type="tel"],
551 | [type="url"],
552 | [type="email"],
553 | [type="number"] {
554 |   direction: ltr;
555 | }
556 | ::-webkit-search-decoration {
557 |   -webkit-appearance: none;
558 | }
559 | 
560 | ::-webkit-color-swatch-wrapper {
561 |   padding: 0;
562 | }
563 | 
564 | ::-webkit-file-upload-button {
565 |   font: inherit;
566 |   -webkit-appearance: button;
567 | }
568 | 
569 | ::file-selector-button {
570 |   font: inherit;
571 |   -webkit-appearance: button;
572 | }
573 | 
574 | output {
575 |   display: inline-block;
576 | }
577 | 
578 | iframe {
579 |   border: 0;
580 | }
581 | 
582 | summary {
583 |   display: list-item;
584 |   cursor: pointer;
585 | }
586 | 
587 | progress {
588 |   vertical-align: baseline;
589 | }
590 | 
591 | [hidden] {
592 |   display: none !important;
593 | }
594 | /*# sourceMappingURL=bootstrap-reboot.rtl.css.map */


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/lib/bootstrap/dist/css/bootstrap-reboot.css:
--------------------------------------------------------------------------------
  1 | /*!
  2 |  * Bootstrap Reboot v5.3.3 (https://getbootstrap.com/)
  3 |  * Copyright 2011-2024 The Bootstrap Authors
  4 |  * Licensed under MIT (https://github.com/twbs/bootstrap/blob/main/LICENSE)
  5 |  */
  6 | :root,
  7 | [data-bs-theme=light] {
  8 |   --bs-blue: #0d6efd;
  9 |   --bs-indigo: #6610f2;
 10 |   --bs-purple: #6f42c1;
 11 |   --bs-pink: #d63384;
 12 |   --bs-red: #dc3545;
 13 |   --bs-orange: #fd7e14;
 14 |   --bs-yellow: #ffc107;
 15 |   --bs-green: #198754;
 16 |   --bs-teal: #20c997;
 17 |   --bs-cyan: #0dcaf0;
 18 |   --bs-black: #000;
 19 |   --bs-white: #fff;
 20 |   --bs-gray: #6c757d;
 21 |   --bs-gray-dark: #343a40;
 22 |   --bs-gray-100: #f8f9fa;
 23 |   --bs-gray-200: #e9ecef;
 24 |   --bs-gray-300: #dee2e6;
 25 |   --bs-gray-400: #ced4da;
 26 |   --bs-gray-500: #adb5bd;
 27 |   --bs-gray-600: #6c757d;
 28 |   --bs-gray-700: #495057;
 29 |   --bs-gray-800: #343a40;
 30 |   --bs-gray-900: #212529;
 31 |   --bs-primary: #0d6efd;
 32 |   --bs-secondary: #6c757d;
 33 |   --bs-success: #198754;
 34 |   --bs-info: #0dcaf0;
 35 |   --bs-warning: #ffc107;
 36 |   --bs-danger: #dc3545;
 37 |   --bs-light: #f8f9fa;
 38 |   --bs-dark: #212529;
 39 |   --bs-primary-rgb: 13, 110, 253;
 40 |   --bs-secondary-rgb: 108, 117, 125;
 41 |   --bs-success-rgb: 25, 135, 84;
 42 |   --bs-info-rgb: 13, 202, 240;
 43 |   --bs-warning-rgb: 255, 193, 7;
 44 |   --bs-danger-rgb: 220, 53, 69;
 45 |   --bs-light-rgb: 248, 249, 250;
 46 |   --bs-dark-rgb: 33, 37, 41;
 47 |   --bs-primary-text-emphasis: #052c65;
 48 |   --bs-secondary-text-emphasis: #2b2f32;
 49 |   --bs-success-text-emphasis: #0a3622;
 50 |   --bs-info-text-emphasis: #055160;
 51 |   --bs-warning-text-emphasis: #664d03;
 52 |   --bs-danger-text-emphasis: #58151c;
 53 |   --bs-light-text-emphasis: #495057;
 54 |   --bs-dark-text-emphasis: #495057;
 55 |   --bs-primary-bg-subtle: #cfe2ff;
 56 |   --bs-secondary-bg-subtle: #e2e3e5;
 57 |   --bs-success-bg-subtle: #d1e7dd;
 58 |   --bs-info-bg-subtle: #cff4fc;
 59 |   --bs-warning-bg-subtle: #fff3cd;
 60 |   --bs-danger-bg-subtle: #f8d7da;
 61 |   --bs-light-bg-subtle: #fcfcfd;
 62 |   --bs-dark-bg-subtle: #ced4da;
 63 |   --bs-primary-border-subtle: #9ec5fe;
 64 |   --bs-secondary-border-subtle: #c4c8cb;
 65 |   --bs-success-border-subtle: #a3cfbb;
 66 |   --bs-info-border-subtle: #9eeaf9;
 67 |   --bs-warning-border-subtle: #ffe69c;
 68 |   --bs-danger-border-subtle: #f1aeb5;
 69 |   --bs-light-border-subtle: #e9ecef;
 70 |   --bs-dark-border-subtle: #adb5bd;
 71 |   --bs-white-rgb: 255, 255, 255;
 72 |   --bs-black-rgb: 0, 0, 0;
 73 |   --bs-font-sans-serif: system-ui, -apple-system, "Segoe UI", Roboto, "Helvetica Neue", "Noto Sans", "Liberation Sans", Arial, sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji";
 74 |   --bs-font-monospace: SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
 75 |   --bs-gradient: linear-gradient(180deg, rgba(255, 255, 255, 0.15), rgba(255, 255, 255, 0));
 76 |   --bs-body-font-family: var(--bs-font-sans-serif);
 77 |   --bs-body-font-size: 1rem;
 78 |   --bs-body-font-weight: 400;
 79 |   --bs-body-line-height: 1.5;
 80 |   --bs-body-color: #212529;
 81 |   --bs-body-color-rgb: 33, 37, 41;
 82 |   --bs-body-bg: #fff;
 83 |   --bs-body-bg-rgb: 255, 255, 255;
 84 |   --bs-emphasis-color: #000;
 85 |   --bs-emphasis-color-rgb: 0, 0, 0;
 86 |   --bs-secondary-color: rgba(33, 37, 41, 0.75);
 87 |   --bs-secondary-color-rgb: 33, 37, 41;
 88 |   --bs-secondary-bg: #e9ecef;
 89 |   --bs-secondary-bg-rgb: 233, 236, 239;
 90 |   --bs-tertiary-color: rgba(33, 37, 41, 0.5);
 91 |   --bs-tertiary-color-rgb: 33, 37, 41;
 92 |   --bs-tertiary-bg: #f8f9fa;
 93 |   --bs-tertiary-bg-rgb: 248, 249, 250;
 94 |   --bs-heading-color: inherit;
 95 |   --bs-link-color: #0d6efd;
 96 |   --bs-link-color-rgb: 13, 110, 253;
 97 |   --bs-link-decoration: underline;
 98 |   --bs-link-hover-color: #0a58ca;
 99 |   --bs-link-hover-color-rgb: 10, 88, 202;
100 |   --bs-code-color: #d63384;
101 |   --bs-highlight-color: #212529;
102 |   --bs-highlight-bg: #fff3cd;
103 |   --bs-border-width: 1px;
104 |   --bs-border-style: solid;
105 |   --bs-border-color: #dee2e6;
106 |   --bs-border-color-translucent: rgba(0, 0, 0, 0.175);
107 |   --bs-border-radius: 0.375rem;
108 |   --bs-border-radius-sm: 0.25rem;
109 |   --bs-border-radius-lg: 0.5rem;
110 |   --bs-border-radius-xl: 1rem;
111 |   --bs-border-radius-xxl: 2rem;
112 |   --bs-border-radius-2xl: var(--bs-border-radius-xxl);
113 |   --bs-border-radius-pill: 50rem;
114 |   --bs-box-shadow: 0 0.5rem 1rem rgba(0, 0, 0, 0.15);
115 |   --bs-box-shadow-sm: 0 0.125rem 0.25rem rgba(0, 0, 0, 0.075);
116 |   --bs-box-shadow-lg: 0 1rem 3rem rgba(0, 0, 0, 0.175);
117 |   --bs-box-shadow-inset: inset 0 1px 2px rgba(0, 0, 0, 0.075);
118 |   --bs-focus-ring-width: 0.25rem;
119 |   --bs-focus-ring-opacity: 0.25;
120 |   --bs-focus-ring-color: rgba(13, 110, 253, 0.25);
121 |   --bs-form-valid-color: #198754;
122 |   --bs-form-valid-border-color: #198754;
123 |   --bs-form-invalid-color: #dc3545;
124 |   --bs-form-invalid-border-color: #dc3545;
125 | }
126 | 
127 | [data-bs-theme=dark] {
128 |   color-scheme: dark;
129 |   --bs-body-color: #dee2e6;
130 |   --bs-body-color-rgb: 222, 226, 230;
131 |   --bs-body-bg: #212529;
132 |   --bs-body-bg-rgb: 33, 37, 41;
133 |   --bs-emphasis-color: #fff;
134 |   --bs-emphasis-color-rgb: 255, 255, 255;
135 |   --bs-secondary-color: rgba(222, 226, 230, 0.75);
136 |   --bs-secondary-color-rgb: 222, 226, 230;
137 |   --bs-secondary-bg: #343a40;
138 |   --bs-secondary-bg-rgb: 52, 58, 64;
139 |   --bs-tertiary-color: rgba(222, 226, 230, 0.5);
140 |   --bs-tertiary-color-rgb: 222, 226, 230;
141 |   --bs-tertiary-bg: #2b3035;
142 |   --bs-tertiary-bg-rgb: 43, 48, 53;
143 |   --bs-primary-text-emphasis: #6ea8fe;
144 |   --bs-secondary-text-emphasis: #a7acb1;
145 |   --bs-success-text-emphasis: #75b798;
146 |   --bs-info-text-emphasis: #6edff6;
147 |   --bs-warning-text-emphasis: #ffda6a;
148 |   --bs-danger-text-emphasis: #ea868f;
149 |   --bs-light-text-emphasis: #f8f9fa;
150 |   --bs-dark-text-emphasis: #dee2e6;
151 |   --bs-primary-bg-subtle: #031633;
152 |   --bs-secondary-bg-subtle: #161719;
153 |   --bs-success-bg-subtle: #051b11;
154 |   --bs-info-bg-subtle: #032830;
155 |   --bs-warning-bg-subtle: #332701;
156 |   --bs-danger-bg-subtle: #2c0b0e;
157 |   --bs-light-bg-subtle: #343a40;
158 |   --bs-dark-bg-subtle: #1a1d20;
159 |   --bs-primary-border-subtle: #084298;
160 |   --bs-secondary-border-subtle: #41464b;
161 |   --bs-success-border-subtle: #0f5132;
162 |   --bs-info-border-subtle: #087990;
163 |   --bs-warning-border-subtle: #997404;
164 |   --bs-danger-border-subtle: #842029;
165 |   --bs-light-border-subtle: #495057;
166 |   --bs-dark-border-subtle: #343a40;
167 |   --bs-heading-color: inherit;
168 |   --bs-link-color: #6ea8fe;
169 |   --bs-link-hover-color: #8bb9fe;
170 |   --bs-link-color-rgb: 110, 168, 254;
171 |   --bs-link-hover-color-rgb: 139, 185, 254;
172 |   --bs-code-color: #e685b5;
173 |   --bs-highlight-color: #dee2e6;
174 |   --bs-highlight-bg: #664d03;
175 |   --bs-border-color: #495057;
176 |   --bs-border-color-translucent: rgba(255, 255, 255, 0.15);
177 |   --bs-form-valid-color: #75b798;
178 |   --bs-form-valid-border-color: #75b798;
179 |   --bs-form-invalid-color: #ea868f;
180 |   --bs-form-invalid-border-color: #ea868f;
181 | }
182 | 
183 | *,
184 | *::before,
185 | *::after {
186 |   box-sizing: border-box;
187 | }
188 | 
189 | @media (prefers-reduced-motion: no-preference) {
190 |   :root {
191 |     scroll-behavior: smooth;
192 |   }
193 | }
194 | 
195 | body {
196 |   margin: 0;
197 |   font-family: var(--bs-body-font-family);
198 |   font-size: var(--bs-body-font-size);
199 |   font-weight: var(--bs-body-font-weight);
200 |   line-height: var(--bs-body-line-height);
201 |   color: var(--bs-body-color);
202 |   text-align: var(--bs-body-text-align);
203 |   background-color: var(--bs-body-bg);
204 |   -webkit-text-size-adjust: 100%;
205 |   -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
206 | }
207 | 
208 | hr {
209 |   margin: 1rem 0;
210 |   color: inherit;
211 |   border: 0;
212 |   border-top: var(--bs-border-width) solid;
213 |   opacity: 0.25;
214 | }
215 | 
216 | h6, h5, h4, h3, h2, h1 {
217 |   margin-top: 0;
218 |   margin-bottom: 0.5rem;
219 |   font-weight: 500;
220 |   line-height: 1.2;
221 |   color: var(--bs-heading-color);
222 | }
223 | 
224 | h1 {
225 |   font-size: calc(1.375rem + 1.5vw);
226 | }
227 | @media (min-width: 1200px) {
228 |   h1 {
229 |     font-size: 2.5rem;
230 |   }
231 | }
232 | 
233 | h2 {
234 |   font-size: calc(1.325rem + 0.9vw);
235 | }
236 | @media (min-width: 1200px) {
237 |   h2 {
238 |     font-size: 2rem;
239 |   }
240 | }
241 | 
242 | h3 {
243 |   font-size: calc(1.3rem + 0.6vw);
244 | }
245 | @media (min-width: 1200px) {
246 |   h3 {
247 |     font-size: 1.75rem;
248 |   }
249 | }
250 | 
251 | h4 {
252 |   font-size: calc(1.275rem + 0.3vw);
253 | }
254 | @media (min-width: 1200px) {
255 |   h4 {
256 |     font-size: 1.5rem;
257 |   }
258 | }
259 | 
260 | h5 {
261 |   font-size: 1.25rem;
262 | }
263 | 
264 | h6 {
265 |   font-size: 1rem;
266 | }
267 | 
268 | p {
269 |   margin-top: 0;
270 |   margin-bottom: 1rem;
271 | }
272 | 
273 | abbr[title] {
274 |   -webkit-text-decoration: underline dotted;
275 |   text-decoration: underline dotted;
276 |   cursor: help;
277 |   -webkit-text-decoration-skip-ink: none;
278 |   text-decoration-skip-ink: none;
279 | }
280 | 
281 | address {
282 |   margin-bottom: 1rem;
283 |   font-style: normal;
284 |   line-height: inherit;
285 | }
286 | 
287 | ol,
288 | ul {
289 |   padding-left: 2rem;
290 | }
291 | 
292 | ol,
293 | ul,
294 | dl {
295 |   margin-top: 0;
296 |   margin-bottom: 1rem;
297 | }
298 | 
299 | ol ol,
300 | ul ul,
301 | ol ul,
302 | ul ol {
303 |   margin-bottom: 0;
304 | }
305 | 
306 | dt {
307 |   font-weight: 700;
308 | }
309 | 
310 | dd {
311 |   margin-bottom: 0.5rem;
312 |   margin-left: 0;
313 | }
314 | 
315 | blockquote {
316 |   margin: 0 0 1rem;
317 | }
318 | 
319 | b,
320 | strong {
321 |   font-weight: bolder;
322 | }
323 | 
324 | small {
325 |   font-size: 0.875em;
326 | }
327 | 
328 | mark {
329 |   padding: 0.1875em;
330 |   color: var(--bs-highlight-color);
331 |   background-color: var(--bs-highlight-bg);
332 | }
333 | 
334 | sub,
335 | sup {
336 |   position: relative;
337 |   font-size: 0.75em;
338 |   line-height: 0;
339 |   vertical-align: baseline;
340 | }
341 | 
342 | sub {
343 |   bottom: -0.25em;
344 | }
345 | 
346 | sup {
347 |   top: -0.5em;
348 | }
349 | 
350 | a {
351 |   color: rgba(var(--bs-link-color-rgb), var(--bs-link-opacity, 1));
352 |   text-decoration: underline;
353 | }
354 | a:hover {
355 |   --bs-link-color-rgb: var(--bs-link-hover-color-rgb);
356 | }
357 | 
358 | a:not([href]):not([class]), a:not([href]):not([class]):hover {
359 |   color: inherit;
360 |   text-decoration: none;
361 | }
362 | 
363 | pre,
364 | code,
365 | kbd,
366 | samp {
367 |   font-family: var(--bs-font-monospace);
368 |   font-size: 1em;
369 | }
370 | 
371 | pre {
372 |   display: block;
373 |   margin-top: 0;
374 |   margin-bottom: 1rem;
375 |   overflow: auto;
376 |   font-size: 0.875em;
377 | }
378 | pre code {
379 |   font-size: inherit;
380 |   color: inherit;
381 |   word-break: normal;
382 | }
383 | 
384 | code {
385 |   font-size: 0.875em;
386 |   color: var(--bs-code-color);
387 |   word-wrap: break-word;
388 | }
389 | a > code {
390 |   color: inherit;
391 | }
392 | 
393 | kbd {
394 |   padding: 0.1875rem 0.375rem;
395 |   font-size: 0.875em;
396 |   color: var(--bs-body-bg);
397 |   background-color: var(--bs-body-color);
398 |   border-radius: 0.25rem;
399 | }
400 | kbd kbd {
401 |   padding: 0;
402 |   font-size: 1em;
403 | }
404 | 
405 | figure {
406 |   margin: 0 0 1rem;
407 | }
408 | 
409 | img,
410 | svg {
411 |   vertical-align: middle;
412 | }
413 | 
414 | table {
415 |   caption-side: bottom;
416 |   border-collapse: collapse;
417 | }
418 | 
419 | caption {
420 |   padding-top: 0.5rem;
421 |   padding-bottom: 0.5rem;
422 |   color: var(--bs-secondary-color);
423 |   text-align: left;
424 | }
425 | 
426 | th {
427 |   text-align: inherit;
428 |   text-align: -webkit-match-parent;
429 | }
430 | 
431 | thead,
432 | tbody,
433 | tfoot,
434 | tr,
435 | td,
436 | th {
437 |   border-color: inherit;
438 |   border-style: solid;
439 |   border-width: 0;
440 | }
441 | 
442 | label {
443 |   display: inline-block;
444 | }
445 | 
446 | button {
447 |   border-radius: 0;
448 | }
449 | 
450 | button:focus:not(:focus-visible) {
451 |   outline: 0;
452 | }
453 | 
454 | input,
455 | button,
456 | select,
457 | optgroup,
458 | textarea {
459 |   margin: 0;
460 |   font-family: inherit;
461 |   font-size: inherit;
462 |   line-height: inherit;
463 | }
464 | 
465 | button,
466 | select {
467 |   text-transform: none;
468 | }
469 | 
470 | [role=button] {
471 |   cursor: pointer;
472 | }
473 | 
474 | select {
475 |   word-wrap: normal;
476 | }
477 | select:disabled {
478 |   opacity: 1;
479 | }
480 | 
481 | [list]:not([type=date]):not([type=datetime-local]):not([type=month]):not([type=week]):not([type=time])::-webkit-calendar-picker-indicator {
482 |   display: none !important;
483 | }
484 | 
485 | button,
486 | [type=button],
487 | [type=reset],
488 | [type=submit] {
489 |   -webkit-appearance: button;
490 | }
491 | button:not(:disabled),
492 | [type=button]:not(:disabled),
493 | [type=reset]:not(:disabled),
494 | [type=submit]:not(:disabled) {
495 |   cursor: pointer;
496 | }
497 | 
498 | ::-moz-focus-inner {
499 |   padding: 0;
500 |   border-style: none;
501 | }
502 | 
503 | textarea {
504 |   resize: vertical;
505 | }
506 | 
507 | fieldset {
508 |   min-width: 0;
509 |   padding: 0;
510 |   margin: 0;
511 |   border: 0;
512 | }
513 | 
514 | legend {
515 |   float: left;
516 |   width: 100%;
517 |   padding: 0;
518 |   margin-bottom: 0.5rem;
519 |   font-size: calc(1.275rem + 0.3vw);
520 |   line-height: inherit;
521 | }
522 | @media (min-width: 1200px) {
523 |   legend {
524 |     font-size: 1.5rem;
525 |   }
526 | }
527 | legend + * {
528 |   clear: left;
529 | }
530 | 
531 | ::-webkit-datetime-edit-fields-wrapper,
532 | ::-webkit-datetime-edit-text,
533 | ::-webkit-datetime-edit-minute,
534 | ::-webkit-datetime-edit-hour-field,
535 | ::-webkit-datetime-edit-day-field,
536 | ::-webkit-datetime-edit-month-field,
537 | ::-webkit-datetime-edit-year-field {
538 |   padding: 0;
539 | }
540 | 
541 | ::-webkit-inner-spin-button {
542 |   height: auto;
543 | }
544 | 
545 | [type=search] {
546 |   -webkit-appearance: textfield;
547 |   outline-offset: -2px;
548 | }
549 | 
550 | /* rtl:raw:
551 | [type="tel"],
552 | [type="url"],
553 | [type="email"],
554 | [type="number"] {
555 |   direction: ltr;
556 | }
557 | */
558 | ::-webkit-search-decoration {
559 |   -webkit-appearance: none;
560 | }
561 | 
562 | ::-webkit-color-swatch-wrapper {
563 |   padding: 0;
564 | }
565 | 
566 | ::-webkit-file-upload-button {
567 |   font: inherit;
568 |   -webkit-appearance: button;
569 | }
570 | 
571 | ::file-selector-button {
572 |   font: inherit;
573 |   -webkit-appearance: button;
574 | }
575 | 
576 | output {
577 |   display: inline-block;
578 | }
579 | 
580 | iframe {
581 |   border: 0;
582 | }
583 | 
584 | summary {
585 |   display: list-item;
586 |   cursor: pointer;
587 | }
588 | 
589 | progress {
590 |   vertical-align: baseline;
591 | }
592 | 
593 | [hidden] {
594 |   display: none !important;
595 | }
596 | 
597 | /*# sourceMappingURL=bootstrap-reboot.css.map */


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/lib/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.js:
--------------------------------------------------------------------------------
  1 | /**
  2 |  * @license
  3 |  * Unobtrusive validation support library for jQuery and jQuery Validate
  4 |  * Copyright (c) .NET Foundation. All rights reserved.
  5 |  * Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
  6 |  * @version v4.0.0
  7 |  */
  8 | 
  9 | /*jslint white: true, browser: true, onevar: true, undef: true, nomen: true, eqeqeq: true, plusplus: true, bitwise: true, regexp: true, newcap: true, immed: true, strict: false */
 10 | /*global document: false, jQuery: false */
 11 | 
 12 | (function (factory) {
 13 |     if (typeof define === 'function' && define.amd) {
 14 |         // AMD. Register as an anonymous module.
 15 |         define("jquery.validate.unobtrusive", ['jquery-validation'], factory);
 16 |     } else if (typeof module === 'object' && module.exports) {
 17 |         // CommonJS-like environments that support module.exports     
 18 |         module.exports = factory(require('jquery-validation'));
 19 |     } else {
 20 |         // Browser global
 21 |         jQuery.validator.unobtrusive = factory(jQuery);
 22 |     }
 23 | }(function ($) {
 24 |     var $jQval = $.validator,
 25 |         adapters,
 26 |         data_validation = "unobtrusiveValidation";
 27 | 
 28 |     function setValidationValues(options, ruleName, value) {
 29 |         options.rules[ruleName] = value;
 30 |         if (options.message) {
 31 |             options.messages[ruleName] = options.message;
 32 |         }
 33 |     }
 34 | 
 35 |     function splitAndTrim(value) {
 36 |         return value.replace(/^\s+|\s+$/g, "").split(/\s*,\s*/g);
 37 |     }
 38 | 
 39 |     function escapeAttributeValue(value) {
 40 |         // As mentioned on http://api.jquery.com/category/selectors/
 41 |         return value.replace(/([!"#$%&'()*+,./:;<=>?@\[\\\]^`{|}~])/g, "\\$1");
 42 |     }
 43 | 
 44 |     function getModelPrefix(fieldName) {
 45 |         return fieldName.substr(0, fieldName.lastIndexOf(".") + 1);
 46 |     }
 47 | 
 48 |     function appendModelPrefix(value, prefix) {
 49 |         if (value.indexOf("*.") === 0) {
 50 |             value = value.replace("*.", prefix);
 51 |         }
 52 |         return value;
 53 |     }
 54 | 
 55 |     function onError(error, inputElement) {  // 'this' is the form element
 56 |         var container = $(this).find("[data-valmsg-for='" + escapeAttributeValue(inputElement[0].name) + "']"),
 57 |             replaceAttrValue = container.attr("data-valmsg-replace"),
 58 |             replace = replaceAttrValue ? $.parseJSON(replaceAttrValue) !== false : null;
 59 | 
 60 |         container.removeClass("field-validation-valid").addClass("field-validation-error");
 61 |         error.data("unobtrusiveContainer", container);
 62 | 
 63 |         if (replace) {
 64 |             container.empty();
 65 |             error.removeClass("input-validation-error").appendTo(container);
 66 |         }
 67 |         else {
 68 |             error.hide();
 69 |         }
 70 |     }
 71 | 
 72 |     function onErrors(event, validator) {  // 'this' is the form element
 73 |         var container = $(this).find("[data-valmsg-summary=true]"),
 74 |             list = container.find("ul");
 75 | 
 76 |         if (list && list.length && validator.errorList.length) {
 77 |             list.empty();
 78 |             container.addClass("validation-summary-errors").removeClass("validation-summary-valid");
 79 | 
 80 |             $.each(validator.errorList, function () {
 81 |                 $("<li />").html(this.message).appendTo(list);
 82 |             });
 83 |         }
 84 |     }
 85 | 
 86 |     function onSuccess(error) {  // 'this' is the form element
 87 |         var container = error.data("unobtrusiveContainer");
 88 | 
 89 |         if (container) {
 90 |             var replaceAttrValue = container.attr("data-valmsg-replace"),
 91 |                 replace = replaceAttrValue ? $.parseJSON(replaceAttrValue) : null;
 92 | 
 93 |             container.addClass("field-validation-valid").removeClass("field-validation-error");
 94 |             error.removeData("unobtrusiveContainer");
 95 | 
 96 |             if (replace) {
 97 |                 container.empty();
 98 |             }
 99 |         }
100 |     }
101 | 
102 |     function onReset(event) {  // 'this' is the form element
103 |         var $form = $(this),
104 |             key = '__jquery_unobtrusive_validation_form_reset';
105 |         if ($form.data(key)) {
106 |             return;
107 |         }
108 |         // Set a flag that indicates we're currently resetting the form.
109 |         $form.data(key, true);
110 |         try {
111 |             $form.data("validator").resetForm();
112 |         } finally {
113 |             $form.removeData(key);
114 |         }
115 | 
116 |         $form.find(".validation-summary-errors")
117 |             .addClass("validation-summary-valid")
118 |             .removeClass("validation-summary-errors");
119 |         $form.find(".field-validation-error")
120 |             .addClass("field-validation-valid")
121 |             .removeClass("field-validation-error")
122 |             .removeData("unobtrusiveContainer")
123 |             .find(">*")  // If we were using valmsg-replace, get the underlying error
124 |             .removeData("unobtrusiveContainer");
125 |     }
126 | 
127 |     function validationInfo(form) {
128 |         var $form = $(form),
129 |             result = $form.data(data_validation),
130 |             onResetProxy = $.proxy(onReset, form),
131 |             defaultOptions = $jQval.unobtrusive.options || {},
132 |             execInContext = function (name, args) {
133 |                 var func = defaultOptions[name];
134 |                 func && $.isFunction(func) && func.apply(form, args);
135 |             };
136 | 
137 |         if (!result) {
138 |             result = {
139 |                 options: {  // options structure passed to jQuery Validate's validate() method
140 |                     errorClass: defaultOptions.errorClass || "input-validation-error",
141 |                     errorElement: defaultOptions.errorElement || "span",
142 |                     errorPlacement: function () {
143 |                         onError.apply(form, arguments);
144 |                         execInContext("errorPlacement", arguments);
145 |                     },
146 |                     invalidHandler: function () {
147 |                         onErrors.apply(form, arguments);
148 |                         execInContext("invalidHandler", arguments);
149 |                     },
150 |                     messages: {},
151 |                     rules: {},
152 |                     success: function () {
153 |                         onSuccess.apply(form, arguments);
154 |                         execInContext("success", arguments);
155 |                     }
156 |                 },
157 |                 attachValidation: function () {
158 |                     $form
159 |                         .off("reset." + data_validation, onResetProxy)
160 |                         .on("reset." + data_validation, onResetProxy)
161 |                         .validate(this.options);
162 |                 },
163 |                 validate: function () {  // a validation function that is called by unobtrusive Ajax
164 |                     $form.validate();
165 |                     return $form.valid();
166 |                 }
167 |             };
168 |             $form.data(data_validation, result);
169 |         }
170 | 
171 |         return result;
172 |     }
173 | 
174 |     $jQval.unobtrusive = {
175 |         adapters: [],
176 | 
177 |         parseElement: function (element, skipAttach) {
178 |             /// <summary>
179 |             /// Parses a single HTML element for unobtrusive validation attributes.
180 |             /// </summary>
181 |             /// <param name="element" domElement="true">The HTML element to be parsed.</param>
182 |             /// <param name="skipAttach" type="Boolean">[Optional] true to skip attaching the
183 |             /// validation to the form. If parsing just this single element, you should specify true.
184 |             /// If parsing several elements, you should specify false, and manually attach the validation
185 |             /// to the form when you are finished. The default is false.</param>
186 |             var $element = $(element),
187 |                 form = $element.parents("form")[0],
188 |                 valInfo, rules, messages;
189 | 
190 |             if (!form) {  // Cannot do client-side validation without a form
191 |                 return;
192 |             }
193 | 
194 |             valInfo = validationInfo(form);
195 |             valInfo.options.rules[element.name] = rules = {};
196 |             valInfo.options.messages[element.name] = messages = {};
197 | 
198 |             $.each(this.adapters, function () {
199 |                 var prefix = "data-val-" + this.name,
200 |                     message = $element.attr(prefix),
201 |                     paramValues = {};
202 | 
203 |                 if (message !== undefined) {  // Compare against undefined, because an empty message is legal (and falsy)
204 |                     prefix += "-";
205 | 
206 |                     $.each(this.params, function () {
207 |                         paramValues[this] = $element.attr(prefix + this);
208 |                     });
209 | 
210 |                     this.adapt({
211 |                         element: element,
212 |                         form: form,
213 |                         message: message,
214 |                         params: paramValues,
215 |                         rules: rules,
216 |                         messages: messages
217 |                     });
218 |                 }
219 |             });
220 | 
221 |             $.extend(rules, { "__dummy__": true });
222 | 
223 |             if (!skipAttach) {
224 |                 valInfo.attachValidation();
225 |             }
226 |         },
227 | 
228 |         parse: function (selector) {
229 |             /// <summary>
230 |             /// Parses all the HTML elements in the specified selector. It looks for input elements decorated
231 |             /// with the [data-val=true] attribute value and enables validation according to the data-val-*
232 |             /// attribute values.
233 |             /// </summary>
234 |             /// <param name="selector" type="String">Any valid jQuery selector.</param>
235 | 
236 |             // $forms includes all forms in selector's DOM hierarchy (parent, children and self) that have at least one
237 |             // element with data-val=true
238 |             var $selector = $(selector),
239 |                 $forms = $selector.parents()
240 |                     .addBack()
241 |                     .filter("form")
242 |                     .add($selector.find("form"))
243 |                     .has("[data-val=true]");
244 | 
245 |             $selector.find("[data-val=true]").each(function () {
246 |                 $jQval.unobtrusive.parseElement(this, true);
247 |             });
248 | 
249 |             $forms.each(function () {
250 |                 var info = validationInfo(this);
251 |                 if (info) {
252 |                     info.attachValidation();
253 |                 }
254 |             });
255 |         }
256 |     };
257 | 
258 |     adapters = $jQval.unobtrusive.adapters;
259 | 
260 |     adapters.add = function (adapterName, params, fn) {
261 |         /// <summary>Adds a new adapter to convert unobtrusive HTML into a jQuery Validate validation.</summary>
262 |         /// <param name="adapterName" type="String">The name of the adapter to be added. This matches the name used
263 |         /// in the data-val-nnnn HTML attribute (where nnnn is the adapter name).</param>
264 |         /// <param name="params" type="Array" optional="true">[Optional] An array of parameter names (strings) that will
265 |         /// be extracted from the data-val-nnnn-mmmm HTML attributes (where nnnn is the adapter name, and
266 |         /// mmmm is the parameter name).</param>
267 |         /// <param name="fn" type="Function">The function to call, which adapts the values from the HTML
268 |         /// attributes into jQuery Validate rules and/or messages.</param>
269 |         /// <returns type="jQuery.validator.unobtrusive.adapters" />
270 |         if (!fn) {  // Called with no params, just a function
271 |             fn = params;
272 |             params = [];
273 |         }
274 |         this.push({ name: adapterName, params: params, adapt: fn });
275 |         return this;
276 |     };
277 | 
278 |     adapters.addBool = function (adapterName, ruleName) {
279 |         /// <summary>Adds a new adapter to convert unobtrusive HTML into a jQuery Validate validation, where
280 |         /// the jQuery Validate validation rule has no parameter values.</summary>
281 |         /// <param name="adapterName" type="String">The name of the adapter to be added. This matches the name used
282 |         /// in the data-val-nnnn HTML attribute (where nnnn is the adapter name).</param>
283 |         /// <param name="ruleName" type="String" optional="true">[Optional] The name of the jQuery Validate rule. If not provided, the value
284 |         /// of adapterName will be used instead.</param>
285 |         /// <returns type="jQuery.validator.unobtrusive.adapters" />
286 |         return this.add(adapterName, function (options) {
287 |             setValidationValues(options, ruleName || adapterName, true);
288 |         });
289 |     };
290 | 
291 |     adapters.addMinMax = function (adapterName, minRuleName, maxRuleName, minMaxRuleName, minAttribute, maxAttribute) {
292 |         /// <summary>Adds a new adapter to convert unobtrusive HTML into a jQuery Validate validation, where
293 |         /// the jQuery Validate validation has three potential rules (one for min-only, one for max-only, and
294 |         /// one for min-and-max). The HTML parameters are expected to be named -min and -max.</summary>
295 |         /// <param name="adapterName" type="String">The name of the adapter to be added. This matches the name used
296 |         /// in the data-val-nnnn HTML attribute (where nnnn is the adapter name).</param>
297 |         /// <param name="minRuleName" type="String">The name of the jQuery Validate rule to be used when you only
298 |         /// have a minimum value.</param>
299 |         /// <param name="maxRuleName" type="String">The name of the jQuery Validate rule to be used when you only
300 |         /// have a maximum value.</param>
301 |         /// <param name="minMaxRuleName" type="String">The name of the jQuery Validate rule to be used when you
302 |         /// have both a minimum and maximum value.</param>
303 |         /// <param name="minAttribute" type="String" optional="true">[Optional] The name of the HTML attribute that
304 |         /// contains the minimum value. The default is "min".</param>
305 |         /// <param name="maxAttribute" type="String" optional="true">[Optional] The name of the HTML attribute that
306 |         /// contains the maximum value. The default is "max".</param>
307 |         /// <returns type="jQuery.validator.unobtrusive.adapters" />
308 |         return this.add(adapterName, [minAttribute || "min", maxAttribute || "max"], function (options) {
309 |             var min = options.params.min,
310 |                 max = options.params.max;
311 | 
312 |             if (min && max) {
313 |                 setValidationValues(options, minMaxRuleName, [min, max]);
314 |             }
315 |             else if (min) {
316 |                 setValidationValues(options, minRuleName, min);
317 |             }
318 |             else if (max) {
319 |                 setValidationValues(options, maxRuleName, max);
320 |             }
321 |         });
322 |     };
323 | 
324 |     adapters.addSingleVal = function (adapterName, attribute, ruleName) {
325 |         /// <summary>Adds a new adapter to convert unobtrusive HTML into a jQuery Validate validation, where
326 |         /// the jQuery Validate validation rule has a single value.</summary>
327 |         /// <param name="adapterName" type="String">The name of the adapter to be added. This matches the name used
328 |         /// in the data-val-nnnn HTML attribute(where nnnn is the adapter name).</param>
329 |         /// <param name="attribute" type="String">[Optional] The name of the HTML attribute that contains the value.
330 |         /// The default is "val".</param>
331 |         /// <param name="ruleName" type="String" optional="true">[Optional] The name of the jQuery Validate rule. If not provided, the value
332 |         /// of adapterName will be used instead.</param>
333 |         /// <returns type="jQuery.validator.unobtrusive.adapters" />
334 |         return this.add(adapterName, [attribute || "val"], function (options) {
335 |             setValidationValues(options, ruleName || adapterName, options.params[attribute]);
336 |         });
337 |     };
338 | 
339 |     $jQval.addMethod("__dummy__", function (value, element, params) {
340 |         return true;
341 |     });
342 | 
343 |     $jQval.addMethod("regex", function (value, element, params) {
344 |         var match;
345 |         if (this.optional(element)) {
346 |             return true;
347 |         }
348 | 
349 |         match = new RegExp(params).exec(value);
350 |         return (match && (match.index === 0) && (match[0].length === value.length));
351 |     });
352 | 
353 |     $jQval.addMethod("nonalphamin", function (value, element, nonalphamin) {
354 |         var match;
355 |         if (nonalphamin) {
356 |             match = value.match(/\W/g);
357 |             match = match && match.length >= nonalphamin;
358 |         }
359 |         return match;
360 |     });
361 | 
362 |     if ($jQval.methods.extension) {
363 |         adapters.addSingleVal("accept", "mimtype");
364 |         adapters.addSingleVal("extension", "extension");
365 |     } else {
366 |         // for backward compatibility, when the 'extension' validation method does not exist, such as with versions
367 |         // of JQuery Validation plugin prior to 1.10, we should use the 'accept' method for
368 |         // validating the extension, and ignore mime-type validations as they are not supported.
369 |         adapters.addSingleVal("extension", "extension", "accept");
370 |     }
371 | 
372 |     adapters.addSingleVal("regex", "pattern");
373 |     adapters.addBool("creditcard").addBool("date").addBool("digits").addBool("email").addBool("number").addBool("url");
374 |     adapters.addMinMax("length", "minlength", "maxlength", "rangelength").addMinMax("range", "min", "max", "range");
375 |     adapters.addMinMax("minlength", "minlength").addMinMax("maxlength", "minlength", "maxlength");
376 |     adapters.add("equalto", ["other"], function (options) {
377 |         var prefix = getModelPrefix(options.element.name),
378 |             other = options.params.other,
379 |             fullOtherName = appendModelPrefix(other, prefix),
380 |             element = $(options.form).find(":input").filter("[name='" + escapeAttributeValue(fullOtherName) + "']")[0];
381 | 
382 |         setValidationValues(options, "equalTo", element);
383 |     });
384 |     adapters.add("required", function (options) {
385 |         // jQuery Validate equates "required" with "mandatory" for checkbox elements
386 |         if (options.element.tagName.toUpperCase() !== "INPUT" || options.element.type.toUpperCase() !== "CHECKBOX") {
387 |             setValidationValues(options, "required", true);
388 |         }
389 |     });
390 |     adapters.add("remote", ["url", "type", "additionalfields"], function (options) {
391 |         var value = {
392 |             url: options.params.url,
393 |             type: options.params.type || "GET",
394 |             data: {}
395 |         },
396 |             prefix = getModelPrefix(options.element.name);
397 | 
398 |         $.each(splitAndTrim(options.params.additionalfields || options.element.name), function (i, fieldName) {
399 |             var paramName = appendModelPrefix(fieldName, prefix);
400 |             value.data[paramName] = function () {
401 |                 var field = $(options.form).find(":input").filter("[name='" + escapeAttributeValue(paramName) + "']");
402 |                 // For checkboxes and radio buttons, only pick up values from checked fields.
403 |                 if (field.is(":checkbox")) {
404 |                     return field.filter(":checked").val() || field.filter(":hidden").val() || '';
405 |                 }
406 |                 else if (field.is(":radio")) {
407 |                     return field.filter(":checked").val() || '';
408 |                 }
409 |                 return field.val();
410 |             };
411 |         });
412 | 
413 |         setValidationValues(options, "remote", value);
414 |     });
415 |     adapters.add("password", ["min", "nonalphamin", "regex"], function (options) {
416 |         if (options.params.min) {
417 |             setValidationValues(options, "minlength", options.params.min);
418 |         }
419 |         if (options.params.nonalphamin) {
420 |             setValidationValues(options, "nonalphamin", options.params.nonalphamin);
421 |         }
422 |         if (options.params.regex) {
423 |             setValidationValues(options, "regex", options.params.regex);
424 |         }
425 |     });
426 |     adapters.add("fileextensions", ["extensions"], function (options) {
427 |         setValidationValues(options, "extension", options.params.extensions);
428 |     });
429 | 
430 |     $(function () {
431 |         $jQval.unobtrusive.parse(document);
432 |     });
433 | 
434 |     return $jQval.unobtrusive;
435 | }));
436 | 


--------------------------------------------------------------------------------
/FrontendServices/Tom's E-shop/wwwroot/lib/jquery-validation/dist/additional-methods.min.js:
--------------------------------------------------------------------------------
1 | /*! jQuery Validation Plugin - v1.21.0 - 7/17/2024
2 |  * https://jqueryvalidation.org/
3 |  * Copyright (c) 2024 Jörn Zaefferer; Licensed MIT */
4 | !function(a){"function"==typeof define&&define.amd?define(["jquery","./jquery.validate.min"],a):"object"==typeof module&&module.exports?module.exports=a(require("jquery")):a(jQuery)}(function(a){return function(){function b(a){return a.replace(/<.[^<>]*?>/g," ").replace(/&nbsp;|&#160;/gi," ").replace(/[.(),;:!?%#$'\"_+=\/\-“”’]*/g,"")}a.validator.addMethod("maxWords",function(a,c,d){return this.optional(c)||b(a).match(/\b\w+\b/g).length<=d},a.validator.format("Please enter {0} words or less.")),a.validator.addMethod("minWords",function(a,c,d){return this.optional(c)||b(a).match(/\b\w+\b/g).length>=d},a.validator.format("Please enter at least {0} words.")),a.validator.addMethod("rangeWords",function(a,c,d){var e=b(a),f=/\b\w+\b/g;return this.optional(c)||e.match(f).length>=d[0]&&e.match(f).length<=d[1]},a.validator.format("Please enter between {0} and {1} words."))}(),a.validator.addMethod("abaRoutingNumber",function(a){var b=0,c=a.split(""),d=c.length;if(9!==d)return!1;for(var e=0;e<d;e+=3)b+=3*parseInt(c[e],10)+7*parseInt(c[e+1],10)+parseInt(c[e+2],10);return 0!==b&&b%10===0},"Please enter a valid routing number."),a.validator.addMethod("accept",function(b,c,d){var e,f,g,h="string"==typeof d?d.replace(/\s/g,""):"image/*",i=this.optional(c);if(i)return i;if("file"===a(c).attr("type")&&(h=h.replace(/[\-\[\]\/\{\}\(\)\+\?\.\\\^\$\|]/g,"\\$&").replace(/,/g,"|").replace(/\/\*/g,"/.*"),c.files&&c.files.length))for(g=new RegExp(".?("+h+")$","i"),e=0;e<c.files.length;e++)if(f=c.files[e],!f.type.match(g))return!1;return!0},a.validator.format("Please enter a value with a valid mimetype.")),a.validator.addMethod("alphanumeric",function(a,b){return this.optional(b)||/^\w+$/i.test(a)},"Letters, numbers, and underscores only please."),a.validator.addMethod("bankaccountNL",function(a,b){if(this.optional(b))return!0;if(!/^[0-9]{9}|([0-9]{2} ){3}[0-9]{3}$/.test(a))return!1;var c,d,e,f=a.replace(/ /g,""),g=0,h=f.length;for(c=0;c<h;c++)d=h-c,e=f.substring(c,c+1),g+=d*e;return g%11===0},"Please specify a valid bank account number."),a.validator.addMethod("bankorgiroaccountNL",function(b,c){return this.optional(c)||a.validator.methods.bankaccountNL.call(this,b,c)||a.validator.methods.giroaccountNL.call(this,b,c)},"Please specify a valid bank or giro account number."),a.validator.addMethod("bic",function(a,b){return this.optional(b)||/^([A-Z]{6}[A-Z2-9][A-NP-Z1-9])(X{3}|[A-WY-Z0-9][A-Z0-9]{2})?$/.test(a.toUpperCase())},"Please specify a valid BIC code."),a.validator.addMethod("cifES",function(a,b){"use strict";function c(a){return a%2===0}if(this.optional(b))return!0;var d,e,f,g,h=new RegExp(/^([ABCDEFGHJKLMNPQRSUVW])(\d{7})([0-9A-J])$/gi),i=a.substring(0,1),j=a.substring(1,8),k=a.substring(8,9),l=0,m=0,n=0;if(9!==a.length||!h.test(a))return!1;for(d=0;d<j.length;d++)e=parseInt(j[d],10),c(d)?(e*=2,n+=e<10?e:e-9):m+=e;return l=m+n,f=(10-l.toString().substr(-1)).toString(),f=parseInt(f,10)>9?"0":f,g="JABCDEFGHI".substr(f,1).toString(),i.match(/[ABEH]/)?k===f:i.match(/[KPQS]/)?k===g:k===f||k===g},"Please specify a valid CIF number."),a.validator.addMethod("cnhBR",function(a){if(a=a.replace(/([~!@#$%^&*()_+=`{}\[\]\-|\\:;'<>,.\/? ])+/g,""),11!==a.length)return!1;var b,c,d,e,f,g,h=0,i=0;if(b=a.charAt(0),new Array(12).join(b)===a)return!1;for(e=0,f=9,g=0;e<9;++e,--f)h+=+(a.charAt(e)*f);for(c=h%11,c>=10&&(c=0,i=2),h=0,e=0,f=1,g=0;e<9;++e,++f)h+=+(a.charAt(e)*f);return d=h%11,d>=10?d=0:d-=i,String(c).concat(d)===a.substr(-2)},"Please specify a valid CNH number."),a.validator.addMethod("cnpjBR",function(a,b){"use strict";if(this.optional(b))return!0;if(a=a.replace(/[^\d]+/g,""),14!==a.length)return!1;if("00000000000000"===a||"11111111111111"===a||"22222222222222"===a||"33333333333333"===a||"44444444444444"===a||"55555555555555"===a||"66666666666666"===a||"77777777777777"===a||"88888888888888"===a||"99999999999999"===a)return!1;for(var c=a.length-2,d=a.substring(0,c),e=a.substring(c),f=0,g=c-7,h=c;h>=1;h--)f+=d.charAt(c-h)*g--,g<2&&(g=9);var i=f%11<2?0:11-f%11;if(i!==parseInt(e.charAt(0),10))return!1;c+=1,d=a.substring(0,c),f=0,g=c-7;for(var j=c;j>=1;j--)f+=d.charAt(c-j)*g--,g<2&&(g=9);return i=f%11<2?0:11-f%11,i===parseInt(e.charAt(1),10)},"Please specify a CNPJ value number."),a.validator.addMethod("cpfBR",function(a,b){"use strict";if(this.optional(b))return!0;if(a=a.replace(/([~!@#$%^&*()_+=`{}\[\]\-|\\:;'<>,.\/? ])+/g,""),11!==a.length)return!1;var c,d,e,f,g=0;if(c=parseInt(a.substring(9,10),10),d=parseInt(a.substring(10,11),10),e=function(a,b){var c=10*a%11;return 10!==c&&11!==c||(c=0),c===b},""===a||"00000000000"===a||"11111111111"===a||"22222222222"===a||"33333333333"===a||"44444444444"===a||"55555555555"===a||"66666666666"===a||"77777777777"===a||"88888888888"===a||"99999999999"===a)return!1;for(f=1;f<=9;f++)g+=parseInt(a.substring(f-1,f),10)*(11-f);if(e(g,c)){for(g=0,f=1;f<=10;f++)g+=parseInt(a.substring(f-1,f),10)*(12-f);return e(g,d)}return!1},"Please specify a valid CPF number."),a.validator.addMethod("creditcard",function(a,b){if(this.optional(b))return"dependency-mismatch";if(/[^0-9 \-]+/.test(a))return!1;var c,d,e=0,f=0,g=!1;if(a=a.replace(/\D/g,""),a.length<13||a.length>19)return!1;for(c=a.length-1;c>=0;c--)d=a.charAt(c),f=parseInt(d,10),g&&(f*=2)>9&&(f-=9),e+=f,g=!g;return e%10===0},"Please enter a valid credit card number."),a.validator.addMethod("creditcardtypes",function(a,b,c){if(/[^0-9\-]+/.test(a))return!1;a=a.replace(/\D/g,"");var d=0;return c.mastercard&&(d|=1),c.visa&&(d|=2),c.amex&&(d|=4),c.dinersclub&&(d|=8),c.enroute&&(d|=16),c.discover&&(d|=32),c.jcb&&(d|=64),c.unknown&&(d|=128),c.all&&(d=255),1&d&&(/^(5[12345])/.test(a)||/^(2[234567])/.test(a))?16===a.length:2&d&&/^(4)/.test(a)?16===a.length:4&d&&/^(3[47])/.test(a)?15===a.length:8&d&&/^(3(0[012345]|[68]))/.test(a)?14===a.length:16&d&&/^(2(014|149))/.test(a)?15===a.length:32&d&&/^(6011)/.test(a)?16===a.length:64&d&&/^(3)/.test(a)?16===a.length:64&d&&/^(2131|1800)/.test(a)?15===a.length:!!(128&d)},"Please enter a valid credit card number."),a.validator.addMethod("currency",function(a,b,c){var d,e="string"==typeof c,f=e?c:c[0],g=!!e||c[1];return f=f.replace(/,/g,""),f=g?f+"]":f+"]?",d="^["+f+"([1-9]{1}[0-9]{0,2}(\\,[0-9]{3})*(\\.[0-9]{0,2})?|[1-9]{1}[0-9]{0,}(\\.[0-9]{0,2})?|0(\\.[0-9]{0,2})?|(\\.[0-9]{1,2})?)$",d=new RegExp(d),this.optional(b)||d.test(a)},"Please specify a valid currency."),a.validator.addMethod("dateFA",function(a,b){return this.optional(b)||/^[1-4]\d{3}\/((0?[1-6]\/((3[0-1])|([1-2][0-9])|(0?[1-9])))|((1[0-2]|(0?[7-9]))\/(30|([1-2][0-9])|(0?[1-9]))))$/.test(a)},a.validator.messages.date),a.validator.addMethod("dateITA",function(a,b){var c,d,e,f,g,h=!1,i=/^\d{1,2}\/\d{1,2}\/\d{4}$/;return i.test(a)?(c=a.split("/"),d=parseInt(c[0],10),e=parseInt(c[1],10),f=parseInt(c[2],10),g=new Date(Date.UTC(f,e-1,d,12,0,0,0)),h=g.getUTCFullYear()===f&&g.getUTCMonth()===e-1&&g.getUTCDate()===d):h=!1,this.optional(b)||h},a.validator.messages.date),a.validator.addMethod("dateNL",function(a,b){return this.optional(b)||/^(0?[1-9]|[12]\d|3[01])[\.\/\-](0?[1-9]|1[012])[\.\/\-]([12]\d)?(\d\d)$/.test(a)},a.validator.messages.date),a.validator.addMethod("extension",function(a,b,c){return c="string"==typeof c?c.replace(/,/g,"|"):"png|jpe?g|gif",this.optional(b)||a.match(new RegExp("\\.("+c+")$","i"))},a.validator.format("Please enter a value with a valid extension.")),a.validator.addMethod("giroaccountNL",function(a,b){return this.optional(b)||/^[0-9]{1,7}$/.test(a)},"Please specify a valid giro account number."),a.validator.addMethod("greaterThan",function(b,c,d){var e=a(d);return this.settings.onfocusout&&e.not(".validate-greaterThan-blur").length&&e.addClass("validate-greaterThan-blur").on("blur.validate-greaterThan",function(){a(c).valid()}),b>e.val()},"Please enter a greater value."),a.validator.addMethod("greaterThanEqual",function(b,c,d){var e=a(d);return this.settings.onfocusout&&e.not(".validate-greaterThanEqual-blur").length&&e.addClass("validate-greaterThanEqual-blur").on("blur.validate-greaterThanEqual",function(){a(c).valid()}),b>=e.val()},"Please enter a greater value."),a.validator.addMethod("iban",function(a,b){if(this.optional(b))return!0;var c,d,e,f,g,h,i,j,k,l=a.replace(/ /g,"").toUpperCase(),m="",n=!0,o="",p="",q=5;if(l.length<q)return!1;if(c=l.substring(0,2),h={AL:"\\d{8}[\\dA-Z]{16}",AD:"\\d{8}[\\dA-Z]{12}",AT:"\\d{16}",AZ:"[\\dA-Z]{4}\\d{20}",BE:"\\d{12}",BH:"[A-Z]{4}[\\dA-Z]{14}",BA:"\\d{16}",BR:"\\d{23}[A-Z][\\dA-Z]",BG:"[A-Z]{4}\\d{6}[\\dA-Z]{8}",CR:"\\d{17}",HR:"\\d{17}",CY:"\\d{8}[\\dA-Z]{16}",CZ:"\\d{20}",DK:"\\d{14}",DO:"[A-Z]{4}\\d{20}",EE:"\\d{16}",FO:"\\d{14}",FI:"\\d{14}",FR:"\\d{10}[\\dA-Z]{11}\\d{2}",GE:"[\\dA-Z]{2}\\d{16}",DE:"\\d{18}",GI:"[A-Z]{4}[\\dA-Z]{15}",GR:"\\d{7}[\\dA-Z]{16}",GL:"\\d{14}",GT:"[\\dA-Z]{4}[\\dA-Z]{20}",HU:"\\d{24}",IS:"\\d{22}",IE:"[\\dA-Z]{4}\\d{14}",IL:"\\d{19}",IT:"[A-Z]\\d{10}[\\dA-Z]{12}",KZ:"\\d{3}[\\dA-Z]{13}",KW:"[A-Z]{4}[\\dA-Z]{22}",LV:"[A-Z]{4}[\\dA-Z]{13}",LB:"\\d{4}[\\dA-Z]{20}",LI:"\\d{5}[\\dA-Z]{12}",LT:"\\d{16}",LU:"\\d{3}[\\dA-Z]{13}",MK:"\\d{3}[\\dA-Z]{10}\\d{2}",MT:"[A-Z]{4}\\d{5}[\\dA-Z]{18}",MR:"\\d{23}",MU:"[A-Z]{4}\\d{19}[A-Z]{3}",MC:"\\d{10}[\\dA-Z]{11}\\d{2}",MD:"[\\dA-Z]{2}\\d{18}",ME:"\\d{18}",NL:"[A-Z]{4}\\d{10}",NO:"\\d{11}",PK:"[\\dA-Z]{4}\\d{16}",PS:"[\\dA-Z]{4}\\d{21}",PL:"\\d{24}",PT:"\\d{21}",RO:"[A-Z]{4}[\\dA-Z]{16}",SM:"[A-Z]\\d{10}[\\dA-Z]{12}",SA:"\\d{2}[\\dA-Z]{18}",RS:"\\d{18}",SK:"\\d{20}",SI:"\\d{15}",ES:"\\d{20}",SE:"\\d{20}",CH:"\\d{5}[\\dA-Z]{12}",TN:"\\d{20}",TR:"\\d{5}[\\dA-Z]{17}",AE:"\\d{3}\\d{16}",GB:"[A-Z]{4}\\d{14}",VG:"[\\dA-Z]{4}\\d{16}"},g=h[c],"undefined"!=typeof g&&(i=new RegExp("^[A-Z]{2}\\d{2}"+g+"$",""),!i.test(l)))return!1;for(d=l.substring(4,l.length)+l.substring(0,4),j=0;j<d.length;j++)e=d.charAt(j),"0"!==e&&(n=!1),n||(m+="0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ".indexOf(e));for(k=0;k<m.length;k++)f=m.charAt(k),p=""+o+f,o=p%97;return 1===o},"Please specify a valid IBAN."),a.validator.addMethod("integer",function(a,b){return this.optional(b)||/^-?\d+$/.test(a)},"A positive or negative non-decimal number please."),a.validator.addMethod("ipv4",function(a,b){return this.optional(b)||/^(25[0-5]|2[0-4]\d|[01]?\d\d?)\.(25[0-5]|2[0-4]\d|[01]?\d\d?)\.(25[0-5]|2[0-4]\d|[01]?\d\d?)\.(25[0-5]|2[0-4]\d|[01]?\d\d?)$/i.test(a)},"Please enter a valid IP v4 address."),a.validator.addMethod("ipv6",function(a,b){return this.optional(b)||/^((([0-9A-Fa-f]{1,4}:){7}[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){6}:[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){5}:([0-9A-Fa-f]{1,4}:)?[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){4}:([0-9A-Fa-f]{1,4}:){0,2}[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){3}:([0-9A-Fa-f]{1,4}:){0,3}[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){2}:([0-9A-Fa-f]{1,4}:){0,4}[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){6}((\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b)\.){3}(\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b))|(([0-9A-Fa-f]{1,4}:){0,5}:((\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b)\.){3}(\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b))|(::([0-9A-Fa-f]{1,4}:){0,5}((\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b)\.){3}(\b((25[0-5])|(1\d{2})|(2[0-4]\d)|(\d{1,2}))\b))|([0-9A-Fa-f]{1,4}::([0-9A-Fa-f]{1,4}:){0,5}[0-9A-Fa-f]{1,4})|(::([0-9A-Fa-f]{1,4}:){0,6}[0-9A-Fa-f]{1,4})|(([0-9A-Fa-f]{1,4}:){1,7}:))$/i.test(a)},"Please enter a valid IP v6 address."),a.validator.addMethod("lessThan",function(b,c,d){var e=a(d);return this.settings.onfocusout&&e.not(".validate-lessThan-blur").length&&e.addClass("validate-lessThan-blur").on("blur.validate-lessThan",function(){a(c).valid()}),b<e.val()},"Please enter a lesser value."),a.validator.addMethod("lessThanEqual",function(b,c,d){var e=a(d);return this.settings.onfocusout&&e.not(".validate-lessThanEqual-blur").length&&e.addClass("validate-lessThanEqual-blur").on("blur.validate-lessThanEqual",function(){a(c).valid()}),b<=e.val()},"Please enter a lesser value."),a.validator.addMethod("lettersonly",function(a,b){return this.optional(b)||/^[a-z]+$/i.test(a)},"Letters only please."),a.validator.addMethod("letterswithbasicpunc",function(a,b){return this.optional(b)||/^[a-z\-.,()'"\s]+$/i.test(a)},"Letters or punctuation only please."),a.validator.addMethod("maxfiles",function(b,c,d){return!!this.optional(c)||!("file"===a(c).attr("type")&&c.files&&c.files.length>d)},a.validator.format("Please select no more than {0} files.")),a.validator.addMethod("maxsize",function(b,c,d){if(this.optional(c))return!0;if("file"===a(c).attr("type")&&c.files&&c.files.length)for(var e=0;e<c.files.length;e++)if(c.files[e].size>d)return!1;return!0},a.validator.format("File size must not exceed {0} bytes each.")),a.validator.addMethod("maxsizetotal",function(b,c,d){if(this.optional(c))return!0;if("file"===a(c).attr("type")&&c.files&&c.files.length)for(var e=0,f=0;f<c.files.length;f++)if(e+=c.files[f].size,e>d)return!1;return!0},a.validator.format("Total size of all files must not exceed {0} bytes.")),a.validator.addMethod("mobileNL",function(a,b){return this.optional(b)||/^((\+|00(\s|\s?\-\s?)?)31(\s|\s?\-\s?)?(\(0\)[\-\s]?)?|0)6((\s|\s?\-\s?)?[0-9]){8}$/.test(a)},"Please specify a valid mobile number."),a.validator.addMethod("mobileRU",function(a,b){var c=a.replace(/\(|\)|\s+|-/g,"");return this.optional(b)||c.length>9&&/^((\+7|7|8)+([0-9]){10})$/.test(c)},"Please specify a valid mobile number."),a.validator.addMethod("mobileUK",function(a,b){return a=a.replace(/\(|\)|\s+|-/g,""),this.optional(b)||a.length>9&&a.match(/^(?:(?:(?:00\s?|\+)44\s?|0)7(?:[1345789]\d{2}|624)\s?\d{3}\s?\d{3})$/)},"Please specify a valid mobile number."),a.validator.addMethod("netmask",function(a,b){return this.optional(b)||/^(254|252|248|240|224|192|128)\.0\.0\.0|255\.(254|252|248|240|224|192|128|0)\.0\.0|255\.255\.(254|252|248|240|224|192|128|0)\.0|255\.255\.255\.(254|252|248|240|224|192|128|0)/i.test(a)},"Please enter a valid netmask."),a.validator.addMethod("nieES",function(a,b){"use strict";if(this.optional(b))return!0;var c,d=new RegExp(/^[MXYZ]{1}[0-9]{7,8}[TRWAGMYFPDXBNJZSQVHLCKET]{1}$/gi),e="TRWAGMYFPDXBNJZSQVHLCKET",f=a.substr(a.length-1).toUpperCase();return a=a.toString().toUpperCase(),!(a.length>10||a.length<9||!d.test(a))&&(a=a.replace(/^[X]/,"0").replace(/^[Y]/,"1").replace(/^[Z]/,"2"),c=9===a.length?a.substr(0,8):a.substr(0,9),e.charAt(parseInt(c,10)%23)===f)},"Please specify a valid NIE number."),a.validator.addMethod("nifES",function(a,b){"use strict";return!!this.optional(b)||(a=a.toUpperCase(),!!a.match("((^[A-Z]{1}[0-9]{7}[A-Z0-9]{1}$|^[T]{1}[A-Z0-9]{8}$)|^[0-9]{8}[A-Z]{1}$)")&&(/^[0-9]{8}[A-Z]{1}$/.test(a)?"TRWAGMYFPDXBNJZSQVHLCKE".charAt(a.substring(8,0)%23)===a.charAt(8):!!/^[KLM]{1}/.test(a)&&a[8]==="TRWAGMYFPDXBNJZSQVHLCKE".charAt(a.substring(8,1)%23)))},"Please specify a valid NIF number."),a.validator.addMethod("nipPL",function(a){"use strict";if(a=a.replace(/[^0-9]/g,""),10!==a.length)return!1;for(var b=[6,5,7,2,3,4,5,6,7],c=0,d=0;d<9;d++)c+=b[d]*a[d];var e=c%11,f=10===e?0:e;return f===parseInt(a[9],10)},"Please specify a valid NIP number."),a.validator.addMethod("nisBR",function(a){var b,c,d,e,f,g=0;if(a=a.replace(/([~!@#$%^&*()_+=`{}\[\]\-|\\:;'<>,.\/? ])+/g,""),11!==a.length)return!1;for(c=parseInt(a.substring(10,11),10),b=parseInt(a.substring(0,10),10),e=2;e<12;e++)f=e,10===e&&(f=2),11===e&&(f=3),g+=b%10*f,b=parseInt(b/10,10);return d=g%11,d=d>1?11-d:0,c===d},"Please specify a valid NIS/PIS number."),a.validator.addMethod("notEqualTo",function(b,c,d){return this.optional(c)||!a.validator.methods.equalTo.call(this,b,c,d)},"Please enter a different value, values must not be the same."),a.validator.addMethod("nowhitespace",function(a,b){return this.optional(b)||/^\S+$/i.test(a)},"No white space please."),a.validator.addMethod("pattern",function(a,b,c){return!!this.optional(b)||("string"==typeof c&&(c=new RegExp("^(?:"+c+")$")),c.test(a))},"Invalid format."),a.validator.addMethod("phoneNL",function(a,b){return this.optional(b)||/^((\+|00(\s|\s?\-\s?)?)31(\s|\s?\-\s?)?(\(0\)[\-\s]?)?|0)[1-9]((\s|\s?\-\s?)?[0-9]){8}$/.test(a)},"Please specify a valid phone number."),a.validator.addMethod("phonePL",function(a,b){a=a.replace(/\s+/g,"");var c=/^(?:(?:(?:\+|00)?48)|(?:\(\+?48\)))?(?:1[2-8]|2[2-69]|3[2-49]|4[1-68]|5[0-9]|6[0-35-9]|[7-8][1-9]|9[145])\d{7}$/;return this.optional(b)||c.test(a)},"Please specify a valid phone number."),a.validator.addMethod("phonesUK",function(a,b){return a=a.replace(/\(|\)|\s+|-/g,""),this.optional(b)||a.length>9&&a.match(/^(?:(?:(?:00\s?|\+)44\s?|0)(?:1\d{8,9}|[23]\d{9}|7(?:[1345789]\d{8}|624\d{6})))$/)},"Please specify a valid uk phone number."),a.validator.addMethod("phoneUK",function(a,b){return a=a.replace(/\(|\)|\s+|-/g,""),this.optional(b)||a.length>9&&a.match(/^(?:(?:(?:00\s?|\+)44\s?)|(?:\(?0))(?:\d{2}\)?\s?\d{4}\s?\d{4}|\d{3}\)?\s?\d{3}\s?\d{3,4}|\d{4}\)?\s?(?:\d{5}|\d{3}\s?\d{3})|\d{5}\)?\s?\d{4,5})$/)},"Please specify a valid phone number."),a.validator.addMethod("phoneUS",function(a,b){return a=a.replace(/\s+/g,""),this.optional(b)||a.length>9&&a.match(/^(\+?1-?)?(\([2-9]([02-9]\d|1[02-9])\)|[2-9]([02-9]\d|1[02-9]))-?[2-9]\d{2}-?\d{4}$/)},"Please specify a valid phone number."),a.validator.addMethod("postalcodeBR",function(a,b){return this.optional(b)||/^\d{2}.\d{3}-\d{3}?$|^\d{5}-?\d{3}?$/.test(a)},"Informe um CEP válido."),a.validator.addMethod("postalCodeCA",function(a,b){return this.optional(b)||/^[ABCEGHJKLMNPRSTVXY]\d[ABCEGHJKLMNPRSTVWXYZ] *\d[ABCEGHJKLMNPRSTVWXYZ]\d$/i.test(a)},"Please specify a valid postal code."),a.validator.addMethod("postalcodeIT",function(a,b){return this.optional(b)||/^\d{5}$/.test(a)},"Please specify a valid postal code."),a.validator.addMethod("postalcodeNL",function(a,b){return this.optional(b)||/^[1-9][0-9]{3}\s?[a-zA-Z]{2}$/.test(a)},"Please specify a valid postal code."),a.validator.addMethod("postcodeUK",function(a,b){return this.optional(b)||/^((([A-PR-UWYZ][0-9])|([A-PR-UWYZ][0-9][0-9])|([A-PR-UWYZ][A-HK-Y][0-9])|([A-PR-UWYZ][A-HK-Y][0-9][0-9])|([A-PR-UWYZ][0-9][A-HJKSTUW])|([A-PR-UWYZ][A-HK-Y][0-9][ABEHMNPRVWXY]))\s?([0-9][ABD-HJLNP-UW-Z]{2})|(GIR)\s?(0AA))$/i.test(a)},"Please specify a valid UK postcode."),a.validator.addMethod("require_from_group",function(b,c,d){var e=a(d[1],c.form),f=e.eq(0),g=f.data("valid_req_grp")?f.data("valid_req_grp"):a.extend({},this),h=e.filter(function(){return g.elementValue(this)}).length>=d[0];return f.data("valid_req_grp",g),a(c).data("being_validated")||(e.data("being_validated",!0),e.each(function(){g.element(this)}),e.data("being_validated",!1)),h},a.validator.format("Please fill at least {0} of these fields.")),a.validator.addMethod("skip_or_fill_minimum",function(b,c,d){var e=a(d[1],c.form),f=e.eq(0),g=f.data("valid_skip")?f.data("valid_skip"):a.extend({},this),h=e.filter(function(){return g.elementValue(this)}).length,i=0===h||h>=d[0];return f.data("valid_skip",g),a(c).data("being_validated")||(e.data("being_validated",!0),e.each(function(){g.element(this)}),e.data("being_validated",!1)),i},a.validator.format("Please either skip these fields or fill at least {0} of them.")),a.validator.addMethod("stateUS",function(a,b,c){var d,e="undefined"==typeof c,f=!e&&"undefined"!=typeof c.caseSensitive&&c.caseSensitive,g=!e&&"undefined"!=typeof c.includeTerritories&&c.includeTerritories,h=!e&&"undefined"!=typeof c.includeMilitary&&c.includeMilitary;return d=g||h?g&&h?"^(A[AEKLPRSZ]|C[AOT]|D[CE]|FL|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEINOPST]|N[CDEHJMVY]|O[HKR]|P[AR]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])$":g?"^(A[KLRSZ]|C[AOT]|D[CE]|FL|G[AU]|HI|I[ADLN]|K[SY]|LA|M[ADEINOPST]|N[CDEHJMVY]|O[HKR]|P[AR]|RI|S[CD]|T[NX]|UT|V[AIT]|W[AIVY])$":"^(A[AEKLPRZ]|C[AOT]|D[CE]|FL|GA|HI|I[ADLN]|K[SY]|LA|M[ADEINOST]|N[CDEHJMVY]|O[HKR]|PA|RI|S[CD]|T[NX]|UT|V[AT]|W[AIVY])$":"^(A[KLRZ]|C[AOT]|D[CE]|FL|GA|HI|I[ADLN]|K[SY]|LA|M[ADEINOST]|N[CDEHJMVY]|O[HKR]|PA|RI|S[CD]|T[NX]|UT|V[AT]|W[AIVY])$",d=f?new RegExp(d):new RegExp(d,"i"),this.optional(b)||d.test(a)},"Please specify a valid state."),a.validator.addMethod("strippedminlength",function(b,c,d){return a(b).text().length>=d},a.validator.format("Please enter at least {0} characters.")),a.validator.addMethod("time",function(a,b){return this.optional(b)||/^([01]\d|2[0-3]|[0-9])(:[0-5]\d){1,2}$/.test(a)},"Please enter a valid time, between 00:00 and 23:59."),a.validator.addMethod("time12h",function(a,b){return this.optional(b)||/^((0?[1-9]|1[012])(:[0-5]\d){1,2}(\ ?[AP]M))$/i.test(a)},"Please enter a valid time in 12-hour am/pm format."),a.validator.addMethod("url2",function(a,b){return this.optional(b)||/^(?:(?:(?:https?|ftp):)?\/\/)(?:(?:[^\]\[?\/<~#`!@$^&*()+=}|:";',>{ ]|%[0-9A-Fa-f]{2})+(?::(?:[^\]\[?\/<~#`!@$^&*()+=}|:";',>{ ]|%[0-9A-Fa-f]{2})*)?@)?(?:(?!(?:10|127)(?:\.\d{1,3}){3})(?!(?:169\.254|192\.168)(?:\.\d{1,3}){2})(?!172\.(?:1[6-9]|2\d|3[0-1])(?:\.\d{1,3}){2})(?:[1-9]\d?|1\d\d|2[01]\d|22[0-3])(?:\.(?:1?\d{1,2}|2[0-4]\d|25[0-5])){2}(?:\.(?:[1-9]\d?|1\d\d|2[0-4]\d|25[0-4]))|(?:(?:[a-z0-9\u00a1-\uffff][a-z0-9\u00a1-\uffff_-]{0,62})?[a-z0-9\u00a1-\uffff]\.)+(?:[a-z\u00a1-\uffff]{2,}\.?)|(?:(?:[a-z0-9\u00a1-\uffff][a-z0-9\u00a1-\uffff_-]{0,62})?[a-z0-9\u00a1-\uffff])|(?:(?:[a-z0-9\u00a1-\uffff][a-z0-9\u00a1-\uffff_-]{0,62}\.)))(?::\d{2,5})?(?:[/?#]\S*)?$/i.test(a)},a.validator.messages.url),a.validator.addMethod("vinUS",function(a){if(17!==a.length)return!1;var b,c,d,e,f,g,h=["A","B","C","D","E","F","G","H","J","K","L","M","N","P","R","S","T","U","V","W","X","Y","Z"],i=[1,2,3,4,5,6,7,8,1,2,3,4,5,7,9,2,3,4,5,6,7,8,9],j=[8,7,6,5,4,3,2,10,0,9,8,7,6,5,4,3,2],k=0;for(b=0;b<17;b++)e=j[b],d=a.slice(b,b+1),isNaN(d)?(d=d.toUpperCase(),c=i[h.indexOf(d)]):c=parseInt(d,10),8===b&&(g=c,"X"===d&&(g=10)),k+=c*e;return f=k%11,f===g},"The specified vehicle identification number (VIN) is invalid."),a.validator.addMethod("zipcodeUS",function(a,b){return this.optional(b)||/^\d{5}(-\d{4})?$/.test(a)},"The specified US ZIP Code is invalid."),a.validator.addMethod("ziprange",function(a,b){return this.optional(b)||/^90[2-5]\d\{2\}-\d{4}$/.test(a)},"Your ZIP-code must be in the range 902xx-xxxx to 905xx-xxxx."),a});


--------------------------------------------------------------------------------
