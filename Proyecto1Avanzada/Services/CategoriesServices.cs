using Proyecto1Avanzada.DTO;
using Proyecto1Avanzada.Models;
using Proyecto1Avanzada.Repositories;
using Proyecto1Avanzada.Repositories.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Avanzada.Services
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly ICategoriesRepository _categoriesRepository;
        public CategoriesServices(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public void Add(CategoriesDTO categories)
        {
            throw new NotImplementedException();
        }

        public void Delete(CategoriesDTO categories)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriesDTO> GetAllCategories()
        {
            return _categoriesRepository.GetAllCategories();
        }

        public CategoriesDTO GetCategoriesById(int CategoriesId)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoriesDTO categories)
        {
            throw new NotImplementedException();
        }
    }
}
