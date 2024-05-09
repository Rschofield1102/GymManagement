using System;
using System.Data;
using Dapper;

namespace GymManagement.Models
{
    public class ProductAll : IProductsAll
    {
        private readonly IDbConnection _conn;

        public ProductAll(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {


            return _conn.Query<Product>("SELECT * FROM products;");

        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id", new { id = id });
        }
    }
}
