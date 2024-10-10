using Dapper;
using Proyecto1Avanzada.DTO;
using Proyecto1Avanzada.DTO.Mapping;
using Proyecto1Avanzada.Models;
using Proyecto1Avanzada.Repositories.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Avanzada.Repositories
{

    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly IConnection _connection;
        public CategoriesRepository(IConnection connection) 
        { 
            _connection = connection;
        }
        public void Add(CategoriesDTO categories)
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();
                string query = @"INSERT INTO Categories(CategoryName, Description, Picture )
                Values (@CategoryName, @Description, @Picture)";
                connection.Execute(query, categories);


            }
        }

        public void Delete(CategoriesDTO categories)
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();
                string query = @"DELETE From Categories where CategoryId= CategoryId";
                connection.Execute(query, new { categories=categories.CategoryID} );
            }
        }

        public IEnumerable<CategoriesDTO> GetAllCategories()
        {
            using (var Connection = _connection.GetConnection()) 
            {
               Connection.Open();
                string query = "select * from categories";

                return Connection.Query<CategoriesDTO>(query).ToList();

            }
        }

        public CategoriesDTO GetCategoriesById(int CategoriesId)
        {
            throw new NotImplementedException();
        }

        public void Update(CategoriesDTO categories)
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();
                string query = @" UPDATE Categories SET CategoyName=@CategotyName,Description=@Descrition,Picture=@Picture";
                connection.Execute(query, categories);
            }
        }
    }
}
