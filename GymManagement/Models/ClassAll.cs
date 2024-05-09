using System;
using System.Data;
using Dapper;

namespace GymManagement.Models
{
    public class ClassAll : IClass
    {
        private readonly IDbConnection _conn;

        public ClassAll(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Class> GetAllProducts()
        {


            return _conn.Query<Class>("SELECT * FROM Classes;");

        }

        public Class GetProduct(int id)
        {
            return _conn.QuerySingle<Class>("SELECT * FROM classes WHERE PRODUCTID = @id", new { id = id });
        }
    }
}
