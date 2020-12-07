using Practica_1.Models;
using Practica_1.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Practica_1.ViewModels
{
   public  class ContactsViewModel : BaseViewModel
    {
        private Contact _selectedContact;

        public ObservableCollection<Contact> Contacts { get; }

        public Command LoadContactsCommand { get; }

        public Command AddContactCommand { get; }

        public Command<Contact> ContactTapped { get; }

        public ContactsViewModel()
        {
            Title = "Agenda";
            Contacts = new ObservableCollection<Contact>();
            LoadContactsCommand = new Command(async () => await ExecuteLoadContactsCommand());

            ContactTapped = new Command<Contact>(OnContactSelected);

            AddContactCommand = new Command(OnAddContact);
        }
        async Task ExecuteLoadContactsCommand()
        {
            IsBusy = true;

            try 
            {
                Contacts.Clear();
                var contacts = await DataStoreContacts.GetContactsAsync(true);
                foreach(var contact in contacts)
                {
                    Contacts.Add(contact);
                }
                
            }
            catch( Exception ex)
            {
                Debug.WriteLine(ex);

            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedContact = null;
        }
        public Contact SelectedContact 
        {
            get => _selectedContact;
            set
            {
                SetProperty(ref _selectedContact, value);
                OnContactSelected(value);
            
            }
        }

        private async void OnAddContact(object obj) 
        {
            await Shell.Current.GoToAsync(nameof(NewContactPage));
        }

        async void OnContactSelected(Contact contact) 
        {
            if (contact == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(ContactDetailPage)}?{nameof(ContactDetailViewModel.ContactId)}={contact.Id}");
        }
    }
}
