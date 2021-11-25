using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class EFContactRepository : IContactRepository
    {
        private PhoneBookDbContext context;
        public EFContactRepository(PhoneBookDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Contact> AllContacts => context.Contacts;

        public void AddContact(Contact contact)
        {
            context.Update(contact);
            context.SaveChanges();
        }

        public Contact GetContactById(int id)
        {
            return context.Contacts.SingleOrDefault(c => c.Id == id);
        }

        public void RemoveContact(Contact contact)
        {
            context.Remove(context.Contacts.Single(c => c.Id == contact.Id));
            //context.Remove(contact); Так тоже не удаляет..
            context.SaveChanges();
        }

    }
}
