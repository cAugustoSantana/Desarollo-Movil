using Practica_1.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica_1.ViewModels
{
    [QueryProperty(nameof(ContactId),nameof(ContactId))]
   public  class ContactDetailViewModel : BaseViewModel
    {
        private string contactId;
        private string name;
        private string phoneNumber;

        public string Id { get; set; }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set => SetProperty(ref phoneNumber, value);
        }
        public string ContactId 
        {
            get 
            {
                return contactId;
            }
            set
            {
                contactId = value;
                LoadContactId(value);
            }
        }

        public async void LoadContactId(string contactId)
        {
            try
            {
                var contact = await DataStoreContacts.GetContactAsync(contactId);
                Id = contact.Id;
                Name = contact.Name;
                PhoneNumber = contact.PhoneNumber;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Contact");
            }
        }


    }
}
