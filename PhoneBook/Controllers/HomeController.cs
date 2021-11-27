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

    }
}