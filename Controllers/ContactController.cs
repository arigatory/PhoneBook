using Microsoft.AspNetCore.Mvc;
using PhoneBook.Models;
using PhoneBook.ViewModels;

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
    }
}
