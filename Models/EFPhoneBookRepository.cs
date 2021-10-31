using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models
{
    public class EFPhoneBookRepository : IPhoneBookRepository
    {
        private PhoneBookDbContext context;
        public EFPhoneBookRepository(PhoneBookDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Contact> Contacts => context.Contacts;

        public void AddContact(Contact contact)
        {
            context.Update(contact);
            context.SaveChanges();
        }

        public void RemoveContact(Contact contact)
        {
            context.Remove(contact);
            context.SaveChanges();
        }

    }
}
