using CatalogService.Application.DTOs;
using CatalogService.Application.Interfaces;
using CatalogService.Domain.Entities;
using CatalogService.Domain.Interfaces;
using MapsterMapper;
using Microsoft.Extensions.Configuration;

namespace CatalogService.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly string _baseUrl;
        public ProductAppService(IProductRepository productRepository, IMapper mapper, IConfiguration configuration)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _configuration = configuration;
            _baseUrl = _configuration["ImageServer"] ?? string.Empty;
        }
        public void Add(ProductDTO productDto)
        {
            var entity = _mapper.Map<CatalogService.Domain.Entities.Product>(productDto);
            _productRepository.Add(entity);
            _productRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
            _productRepository.SaveChanges();
        }

        public IEnumerable<ProductDTO> GetAll()
        {
            var products = _productRepository.GetAll();
            if (products == null || !products.Any())
            {
                return null;
            }
            foreach (var product in products)
            {
                product.ImageUrl = _baseUrl+ product.ImageUrl;
            }
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public ProductDTO GetById(int id)
        {
            var product = _productRepository.GetById(id);
            if (product == null)
            {
                return null;
            }
            product.ImageUrl = _baseUrl + product.ImageUrl;
            return _mapper.Map<ProductDTO>(product);
        }

        public IEnumerable<ProductDTO> GetByIds(int[] ids)
        {
            var products = _productRepository.GetByIds(ids);
            if (products == null || !products.Any())
            {
                return null;
            }
            foreach (var product in products)
            {
                product.ImageUrl = _baseUrl + product.ImageUrl;
            }
            return _mapper.Map<IEnumerable<ProductDTO>>(products);
        }

        public void Update(ProductDTO productDto)
        {
            var entity = _mapper.Map<Product>(productDto);
            _productRepository.Update(entity);
            _productRepository.SaveChanges();   
        }
    }
}
