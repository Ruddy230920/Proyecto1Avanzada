using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1Avanzada.Repositories.Configuration
{
  public class DatabaseConnection: IConnection
    {
        private readonly IConfiguration _configuration;
        public DatabaseConnection(IConfiguration configuration) 
        {
            _configuration = configuration;
        }
        public IDbConnection GetConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("NorthwindConnection"));
        }   
        
    }
}
