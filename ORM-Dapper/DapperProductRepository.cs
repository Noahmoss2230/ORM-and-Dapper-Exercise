using System;
using System.Data;
using Dapper;

namespace ORM_Dapper
{

    public class DapperProductRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;
        
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("select * from departments");
        }

        public void InsertDepartment(string name)
        {
            _connection.Execute("insert into departments (name) values (@name)" ,new {name = name});
        }

        public void CreateProduct(string name, double price, int categoryID)
        {
            _connection.Execute("insert into products (Name, Price, CategoryID) values (@name, @price, @categoryId);",
                new {name = name, price = price, categoryID = categoryID});
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _connection.Query<Product>("SELECT * FROM PRODUCTS;");
        }
    }
}