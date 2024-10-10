using Proyecto1Avanzada.DTO;
using Proyecto1Avanzada.Models;
using Proyecto1Avanzada.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Avanzada.Services
{
    public class ProductsServices : IProductsServices
    {
        private readonly IProductsRepository   _productsRepository;
       public ProductsServices(IProductsRepository productsRepository) 
        {
         
            _productsRepository = productsRepository;
        }

        public void Add(ProductsDTO products)
        {
           _productsRepository.Add(products);
        }

        public void Delete(ProductsDTO products)
        {
         _productsRepository.Delete(products);
        }

        public IEnumerable<ProductsDTO> GetAllProducts()
        {
  
            return _productsRepository.GetAllProducts();
        }

        public ProductsDTO GetProductsById(int ProductsId)
        {
            return _productsRepository.GetProductsById(ProductsId);
        }

        public void Update(ProductsDTO products)
        {
            _productsRepository.Update(products);
        }
    }
}
