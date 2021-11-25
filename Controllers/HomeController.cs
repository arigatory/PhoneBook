using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;
using System.Linq;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        private IContactRepository repository;
        public HomeController(IContactRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.AllContacts);
        }

        [HttpGet]
        public ViewResult ContactForm(int id)
        {
            var contact = repository.AllContacts.Where(x => x.Id == id).SingleOrDefault();

            return View(contact);
        }

        [HttpPost]
        public ViewResult ContactForm(Contact contact)
        {
            if (ModelState.IsValid)
            {
                repository.AddContact(contact);
                return View("ContactAdded", contact);
            }
            else
            {
                return View();
            }

        }

        [HttpPost]
        public ViewResult ContactDeleted(int id)
        {
            var contact = repository.AllContacts.Where(x => x.Id == id).SingleOrDefault();
            if (contact != null)
            {
                repository.RemoveContact(contact);
            }
            return View("ContactDeleted");
        }
    }
}