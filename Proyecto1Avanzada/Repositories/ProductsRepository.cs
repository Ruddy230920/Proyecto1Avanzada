using Dapper;
using Proyecto1Avanzada.DTO;
using Proyecto1Avanzada.DTO.Mapping;
using Proyecto1Avanzada.Models;
using Proyecto1Avanzada.Repositories.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Avanzada.Repositories
{

    public class ProductsRepository : IProductsRepository
    {
        private readonly IConnection _connection;
        public ProductsRepository(IConnection Connection)
        {
            _connection = Connection;
        }

        public void Add(ProductsDTO products)
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();
                string ADD = @"INSERT INTO Products (ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, CategoryID, SupplierID, Discontinued)
                          VALUES (@ProductName, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @CategoryID, @SupplierID, @Discontinued)";
                connection.Execute(ADD, products);
            }

        }

        public void Delete(ProductsDTO products)
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();

                string DELETE = @"Delete from Products Where ProductId = ProductId";

                connection.Execute(DELETE, new {ProductId= products.ProductID});
            }
        }

        public IEnumerable<ProductsDTO> GetAllProducts()
        {
            using (var connection = _connection.GetConnection())
            {
                connection.Open();

                return connection.Query<ProductsDTO>(MapperProducts.GetProducts()).ToList();

            }
        }

        public ProductsDTO? GetProductsById(int ProductId)
        {

            using (var connection = _connection.GetConnection())
            {

                connection.Open();

                return connection.QuerySingleOrDefault<ProductsDTO>(MapperProducts.QueryProductsById(), new { ProductId});
            }
        }

        public void Update(ProductsDTO products)
        {
            using (var connection = _connection.GetConnection())
            {
                {
                    connection.Open();

                    string UPDATE = @"UPDATE Products SET 
                              ProductName = @ProductName, 
                              QuantityPerUnit = @QuantityPerUnit, 
                              UnitPrice = @UnitPrice, 
                              UnitsInStock = @UnitsInStock, 
                              CategoryID = @CategoryID, 
                              SupplierID = @SupplierID, 
                              Discontinued = @Discontinued 
                              WHERE ProductID = @ProductID";

                    connection.Execute(UPDATE, products);
                }
            }
        }
    }
}
