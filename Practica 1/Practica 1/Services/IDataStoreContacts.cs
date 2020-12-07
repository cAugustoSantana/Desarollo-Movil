using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Practica_1.Services
{
    public interface IDataStoreContacts<T>
    {
        Task<bool> AddContactAsync(T item);

        Task<bool> UpdateContactAsync(T item);

        Task<bool> DeleteContactAsync(string id);

        Task<T> GetContactAsync(string id);

        Task<IEnumerable<T>> GetContactsAsync(bool forceRefresh = false);
    }
}
