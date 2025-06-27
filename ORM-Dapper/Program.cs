using System;
using System.Data;
using System.IO;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace ORM_Dapper
{ class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            
            string connString = config.GetConnectionString("DefaultConnection");
            
            IDbConnection connection = new MySqlConnection(connString);

            var repo = new DapperProductRepository(connection);
            
            repo.CreateProduct("newStuff", 20, 1 );

            var products = repo.GetAllProducts();

            foreach (var prod in products)
            {
                Console.WriteLine($"{prod.ProductId} {prod.Name}");
            }
        }
    }
}
