using System;
using System.Collections.Generic;
using System.Data;
using Dapper;

namespace ORM_Dapper
{

    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;
        
        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("select * from Department");
        }

    }
}