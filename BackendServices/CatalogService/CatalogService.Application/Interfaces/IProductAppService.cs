using CatalogService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogService.Application.Interfaces
{
    public interface IProductAppService
    {
        IEnumerable<ProductDTO> GetAll();
        ProductDTO GetById(int id);
        IEnumerable<ProductDTO> GetByIds(int[] ids);
        void Add(ProductDTO productDto);
        void Update(ProductDTO productDto);
        void Delete(int id);
    }
}
