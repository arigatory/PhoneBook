using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public interface IContactRepository
    {
        IQueryable<Contact> AllContacts { get; }
        public void UpdateContact(Contact contact);
        public void RemoveContact(Contact contact);
        public Contact GetContactById(int id);
    }
}