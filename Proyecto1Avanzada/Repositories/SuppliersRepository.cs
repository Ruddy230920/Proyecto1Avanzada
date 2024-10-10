using Dapper;
using Proyecto1Avanzada.DTO;
using Proyecto1Avanzada.Models;
using Proyecto1Avanzada.Repositories.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Avanzada.Repositories
{
    public class SuppliersRepository : ISuppliersRepository
    {
        private readonly IConnection _connection;
        public SuppliersRepository(IConnection connection) 
        {
            {
                _connection = connection;
            }
        }
        public void Add(SupplierDTO supplier)
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();
                string query = @"INSERT INTO Suppliers(CompanyName,ContactName,ContactTitle,City,Address,Country,Phone)
                values (@CompanyName,@ContactName,@ContactTitle,@City,@Address,@Country,@Phone)";
                connection.Execute(query,supplier);
            }
        }

        public void Delete(SupplierDTO supplier)
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();
                string query = @"DELETE FROM Suppliers where SupplierId = SupplierId";
                connection.Execute(query, new {supplier=supplier.SupplierID});
            }
        }

        public IEnumerable<SupplierDTO> GetAllSuppliers()
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();
                string query = @"SELECT * FROM Suppliers";
                return connection.Query<SupplierDTO>(query).ToList();
            }
        }

        public SupplierDTO GetSuppliersById(int supplierId)
        {
            throw new NotImplementedException();
        }

        public void Update(SupplierDTO supplier)
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();
                string query = @"UPDATE Suppliers set CompanyName=@CompanyName,ContactName=@ContactName,ContactTitle=@ContactTitle,City=@City,Address=@Address,Country=@Country,Phone=@Phone";
                connection.Execute(query, supplier);
            }
        }
    }
}
