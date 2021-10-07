using System.Collections.Generic;

namespace PhoneBook.Models
{
    public static class Repository
    {
        private static List<Contact> _contacts = new List<Contact>();
        
        public static IEnumerable<Contact> Contacts => _contacts;

        public static void AddContact(Contact contact)
        {
            _contacts.Add(contact);
        }
    }
}
