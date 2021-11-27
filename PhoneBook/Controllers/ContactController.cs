using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;
using PhoneBook.ViewModels;
using System.Linq;

namespace PhoneBook.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public ViewResult List()
        {
            ContactsListViewModel contactsListViewModel = new ContactsListViewModel();
            contactsListViewModel.Contacts = _contactRepository.AllContacts;
            return View(contactsListViewModel);
        }

        public IActionResult Details(int id)
        {
            var contact = _contactRepository.GetContactById(id);
            if (contact == null)
            {
                return NotFound();
            }
            return View(contact);
        }

        [HttpPost]
        public IActionResult ContactSaved(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View("ContactForm");
            }
            if (contact.Id == 0)
            {
                _contactRepository.AddContact(contact);
            }
            else
            {
                _contactRepository.UpdateContact(contact);
            }
            return View("ContactSaved", contact);

        }

        [HttpPost]
        public ViewResult ContactDeleted(int id)
        {
            var contact = _contactRepository.AllContacts.Where(x => x.Id == id).SingleOrDefault();
            if (contact != null)
            {
                _contactRepository.RemoveContact(contact);
            }
            return View();
        }

        [Authorize]
        [HttpGet]
        public IActionResult ContactForm(int id)
        {

            var contact = _contactRepository.GetContactById(id);
           
            return View(contact);

        }

    }
}
