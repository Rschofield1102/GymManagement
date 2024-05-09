using System;
namespace GymManagement.Models
{
    public interface IClass
    {
        public IEnumerable<Class> GetAllProducts();

        public Class GetProduct(int id);
    }
}
