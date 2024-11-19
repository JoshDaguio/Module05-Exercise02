using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module05Exercise01.Services
{
    public class DatabaseConnectionService
    {
        private readonly string _connectionString;

        public DatabaseConnectionService()
        {
            _connectionString = "Server=localhost; Database=CompanyDB; User ID=testuser; Password=testuser";
        }
        public string GetConnectionString()
        {
            return
                _connectionString;
        }
    }
}
