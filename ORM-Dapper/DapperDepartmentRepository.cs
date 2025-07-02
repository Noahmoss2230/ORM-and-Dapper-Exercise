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
            return _connection.Query<Department>("select * from departments");
        }

        public void InsertDepartment(string name)
        {
            _connection.Execute("Insert into departments (name) values (@name)",new {name = name});
        }
    }
}