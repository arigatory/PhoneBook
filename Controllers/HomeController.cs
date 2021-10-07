using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ContactForm(Contact contact)
        {
            //TODO store responce 
            return View();
        }
    }
}