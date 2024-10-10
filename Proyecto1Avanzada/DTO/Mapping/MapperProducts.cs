using Proyecto1Avanzada.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Avanzada.DTO.Mapping
{
    public class MapperProducts
    {
       public static string QueryProductsById() 
        {
            
            var query = @"
            SELECT 
                p.ProductID, p.ProductName, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, 
                p.UnitsOnOrder, p.CategoryID, p.SupplierID, p.Discontinued, 
                c.CategoryName, s.CompanyName
            FROM 
                Products p
            JOIN 
                Categories c ON p.CategoryID = c.CategoryID
            JOIN 
                Suppliers s ON p.SupplierID = s.SupplierID
            WHERE
                p.ProductID =ProductID";
            return query;
        }
        public static string GetProducts() 
        {
            string query = @"
                SELECT 
                    p.ProductID, p.ProductName, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, 
                    p.UnitsOnOrder, p.CategoryID, p.SupplierID, p.Discontinued, 
                    c.CategoryName, s.CompanyName
                FROM 
                    Products p
                JOIN 
                    Categories c ON p.CategoryID = c.CategoryID
                JOIN 
                    Suppliers s ON p.SupplierID = s.SupplierID";
            return query;


        }
    }
}
