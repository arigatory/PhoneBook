using PhoneBook.Models;
using System.Collections.Generic;

namespace PhoneBook.ViewModels
{
    public class ContactsListViewModel
    {
        public IEnumerable<Contact> Contacts{ get; set; }
    }
}
