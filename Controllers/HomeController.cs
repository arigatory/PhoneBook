using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Contacts);
        }

        [HttpGet]
        public ViewResult ContactForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult ContactForm(Contact contact)
        {
            if (ModelState.IsValid)
            {
                Repository.AddContact(contact);
                return View("ContactAdded", contact);
            }
            else
            {
                return View();
            }

        }
    }
}