using System;
using System.Data;
using Dapper;

namespace GymManagement.Models
{
    public class GymTraineeAll : IGymTrainee
    {
        private readonly IDbConnection _conn;

        public GymTraineeAll(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<GymTrainee> GetAllProducts()
        {


            return _conn.Query<GymTrainee>("SELECT * FROM employees;");

        }

        public GymTrainee GetProduct(int id)
        {
            return _conn.QuerySingle<GymTrainee>("SELECT * FROM employees WHERE PRODUCTID = @id", new { id = id });
        }
    }
}
