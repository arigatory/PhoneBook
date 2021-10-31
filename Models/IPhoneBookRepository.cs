using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public interface IPhoneBookRepository
    {
        IQueryable<Contact> Contacts { get; }
        public void AddContact(Contact contact);
        public void RemoveContact(Contact cnt);
    }
}
