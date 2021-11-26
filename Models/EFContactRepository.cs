using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class EFContactRepository : IContactRepository
    {
        private PhoneBookDbContext _context;
        public EFContactRepository(PhoneBookDbContext ctx)
        {
            _context = ctx;
        }

        public IQueryable<Contact> AllContacts => _context.Contacts;

        public void UpdateContact(Contact contact)
        {
            _context.Update(contact);
            _context.SaveChanges();
        }

        public Contact GetContactById(int id)
        {
            return _context.Contacts.SingleOrDefault(c => c.Id == id);
        }

        public void RemoveContact(Contact contact)
        {
            _context.Remove(_context.Contacts.Single(c => c.Id == contact.Id));
            //context.Remove(contact); Так тоже не удаляет..
            _context.SaveChanges();
        }

    }
}
