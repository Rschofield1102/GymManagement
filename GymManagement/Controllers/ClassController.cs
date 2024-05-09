using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymManagement.Controllers
{


    public class ClassController : Controller
    {
        private readonly IClass repo;

        public ClassController(IClass repo)
        {
            this.repo = repo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Class> classes = repo.GetAllProducts();


            return View(classes);
        }


        public IActionResult ViewProduct(int id)
        {
            var classs = repo.GetProduct(id);
            return View(classs);
        }




    }
}