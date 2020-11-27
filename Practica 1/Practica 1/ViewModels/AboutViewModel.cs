using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Practica_1.Views;

namespace Practica_1.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "1073758";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            RegisterCommand = new Command(OnRegisterCommand);
            LoginCommand = new Command(OnLoginCommand);


        }

        private async void OnLoginCommand(object obj)
        {

            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
        private async void OnRegisterCommand(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync("//Registration");
        }

        
        public Command LoginCommand { get; }
        public Command RegisterCommand { get; }
        public ICommand OpenWebCommand { get; }
    }
}


