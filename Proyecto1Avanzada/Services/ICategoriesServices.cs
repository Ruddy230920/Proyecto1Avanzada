using Proyecto1Avanzada.DTO;
using Proyecto1Avanzada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Avanzada.Services
{
   public interface ICategoriesServices
    {
        IEnumerable<CategoriesDTO> GetAllCategories();
        CategoriesDTO GetCategoriesById(int CategoriesId);
        void Add(CategoriesDTO categories);
        void Update(CategoriesDTO categories);
        void Delete(CategoriesDTO categories);
    }
}
