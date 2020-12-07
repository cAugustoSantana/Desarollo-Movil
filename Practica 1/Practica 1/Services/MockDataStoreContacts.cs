using System;
using System.Collections.Generic;
using System.Text;
using Practica_1.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_1.Services
{
   
   public  class MockDataStoreContacts: IDataStoreContacts<Contact>
    {
        readonly List<Contact> contacts;

        public MockDataStoreContacts()
        {
            contacts = new List<Contact>()
            {

            };
        }
        public async Task<bool> AddContactAsync(Contact contact)
        {
            contacts.Add(contact);

            return await Task.FromResult(true);
        
        }
        public async Task<bool> UpdateContactAsync(Contact contact) 
        {
            var oldContact = contacts.Where((Contact arg) => arg.Id == contact.Id).FirstOrDefault();
            contacts.Remove(oldContact);
            contacts.Add(contact);

            return await Task.FromResult(true);
        
        }
        public async Task<bool> DeleteContactAsync(string id)
        {
            var oldContact = contacts.Where((Contact arg) => arg.Id == id).FirstOrDefault();
            contacts.Remove(oldContact);

            return await Task.FromResult(true);
        }

        public async Task<Contact> GetContactAsync(string id)
        {
            return await Task.FromResult(contacts.FirstOrDefault(s => s.Id == id));
        }
        public async Task<IEnumerable<Contact>> GetContactsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(contacts);
        }

        
    }
}
