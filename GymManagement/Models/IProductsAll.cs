using System;
using System.Collections.Generic;
namespace GymManagement.Models
{
	public interface IProductsAll
	{

		public IEnumerable<Product> GetAllProducts();
	}
}

