using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GymManagement.Controllers
{
    public class ChatController : Controller
    {

        private static List<ChatMessage> chatMessages = new List<ChatMessage>();

        // GET: /Chat
        public ActionResult Index()
        {
            return View(chatMessages);
        }

        // POST: /Chat/SendMessage
        [HttpPost]
        public ActionResult SendMessage(string sender, string text)
        {
            var message = new ChatMessage
            {
                Sender = sender,
                Text = text,
                Timestamp = DateTime.Now
            };

            chatMessages.Add(message);

            return RedirectToAction("Index");
        }


    }
}

