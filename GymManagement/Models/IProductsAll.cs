using System;
using System.Collections.Generic;
namespace GymManagement.Models
{
    public interface IProductsAll
    {

        public IEnumerable<Product> GetAllProducts();

        public Product GetProduct(int id);
    }
}