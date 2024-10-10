using Proyecto1Avanzada.DTO;
using Proyecto1Avanzada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Avanzada.Repositories
{
public interface IProductsRepository
    {
        IEnumerable<ProductsDTO> GetAllProducts();
        ProductsDTO GetProductsById(int ProductsId);
        void Add(ProductsDTO products);
        void Update(ProductsDTO products);
        void Delete(ProductsDTO products);
    }
}
