using System;
using System.Collections.Generic;

namespace PhoneBook.Models
{
    public static class Repository
    {
        static int id = 0;
        private static List<Contact> _contacts = new List<Contact>
        {
            new Contact
            {
                Id = NextId(),
                LastName =  "Иванов",
                FirstName = "Иван",
                MiddleName = "Иванович",
                Description = "мой самый первый контакт",
                Address = "Москва, ул. Центральная, д. 5, кв. 37",
                Phone = "+7(900)100-20-30" 
            },
            new Contact
            {
                Id = NextId(),
                LastName =  "Петров",
                FirstName = "Андрй",
                MiddleName = "Петрович",
                Description = "хороший друг",
                Address = "Москва, ул. Ленина, д. 6, кв. 37",
                Phone = "+7(900)100-20-30"
            },
            new Contact
            {
                Id = NextId(),
                LastName =  "Сидоров",
                FirstName = "Илья",
                MiddleName = "Олегович",
                Description = "бывший коллега",
                Address = "Москва, Мичуринский пр-т, д. 5, кв. 100",
                Phone = "+7(900)100-20-30"
            }
        };
        
        public static IEnumerable<Contact> Contacts => _contacts;

        public static void AddContact(Contact contact)
        {
            if (contact.Id == 0)
            {
                contact.Id = NextId();
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

        private static int NextId()
        {
            id++;
            return id;
        }
    }
}
