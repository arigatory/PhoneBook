using PhoneBook.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PhoneBook.WPF.DataProvider
{
    public interface IContactDataProvider
    {
        Task<IEnumerable<Contact>> LoadContacts();
    }
}