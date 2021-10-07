using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(Repository.Contacts);
        }

        [HttpGet]
        public ViewResult ContactForm(int id)
        {
            var contact = Repository.Contacts.Where(x => x.Id == id).SingleOrDefault();

            return View(contact);
        }

        [HttpPost]
        public ViewResult ContactForm(Contact contact)
        {
            if (ModelState.IsValid)
            {
                var cnt = Repository.Contacts.Where(x => x.Id == contact.Id).SingleOrDefault();
                if (cnt != null)
                    Repository.RemoveContact(cnt);
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