using System;
using System.Data;
using Dapper;

namespace ORM_Dapper
{

    public class DapperProductRepository : IProductRepository
    {
        private readonly IDbConnection _connection;
        
        public DapperProductRepository(IDbConnection connection)
        {
            _connection = connection;
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