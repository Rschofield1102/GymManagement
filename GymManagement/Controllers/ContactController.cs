using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymManagement.Controllers
{
    public class ContactController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Contact contact)
        {
            // Handle the submitted contact information (e.g., save to database, send email, etc.)
            // For simplicity, we'll just return a success message
            ViewBag.Message = "Thank you for your message, " + contact.Name + "!";
            return View();
        }

    }
}

