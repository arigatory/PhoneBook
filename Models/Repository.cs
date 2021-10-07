using System;
using System.Collections.Generic;

namespace PhoneBook.Models
{
    public static class Repository
    {
        static int id = 0;
        private static List<Contact> _contacts = new List<Contact>();
        
        public static IEnumerable<Contact> Contacts => _contacts;

        public static void AddContact(Contact contact)
        {
            if (contact.Id == 0)
            {
                id++;
                contact.Id = id;
            }
            _contacts.Add(contact);
        }

        public static void RemoveContact(Contact cnt)
        {
            if (_contacts.Contains(cnt))
            {
                _contacts.Remove(cnt);
            }
        }
    }
}
