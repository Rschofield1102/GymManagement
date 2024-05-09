using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymManagement.Controllers
{


    public class GymController : Controller
    {
        private readonly IGymTrainee repo;

        public GymController(IGymTrainee repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<GymTrainee> gymTrainees = repo.GetAllProducts();

           
            return View(gymTrainees);
        }


        public IActionResult ViewProduct(int id)
        {
            var gymTrainee = repo.GetProduct(id);
            return View(gymTrainee);
        }




    }
}