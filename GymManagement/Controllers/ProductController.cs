using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymManagement.Controllers
{


    public class ProductController : Controller
    {
        private readonly IProductsAll repo;

        public ProductController(IProductsAll repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();

            // sends products to view file.
            return View(products);
        }







    }
}

