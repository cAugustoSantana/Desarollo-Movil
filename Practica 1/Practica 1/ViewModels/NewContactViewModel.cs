using Practica_1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;


namespace Practica_1.ViewModels
{
    
    public class NewContactViewModel : BaseViewModel
    {
        private string name;
        private string phoneNumber;

       public NewContactViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }
        private bool ValidateSave() 
        {
            return !String.IsNullOrWhiteSpace(name)
                && !String.IsNullOrWhiteSpace(phoneNumber);
        }
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

        public Command SaveCommand { get; }
        
        public Command CancelCommand { get; }

        private async void OnSave()
        {
            Contact newContact = new Contact()
            {
                Id = Guid.NewGuid().ToString(),
                Name = Name,
                PhoneNumber = PhoneNumber
            };

            await DataStoreContacts.AddContactAsync(newContact);

            await Shell.Current.GoToAsync("..");
        }
        private async void OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
    

    


}
