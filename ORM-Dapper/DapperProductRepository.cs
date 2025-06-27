using System;
using System.Data;

namespace ORM_Dapper
{

    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

    }
}