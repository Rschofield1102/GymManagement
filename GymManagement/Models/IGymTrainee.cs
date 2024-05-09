using System;
namespace GymManagement.Models
{
	public interface IGymTrainee
	{
        public IEnumerable<GymTrainee> GetAllProducts();

        public GymTrainee GetProduct(int id);
    }
}

