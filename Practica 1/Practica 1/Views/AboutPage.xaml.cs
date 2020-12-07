using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_1.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            btnToLoginPage.Clicked += (sender, e) =>
            {

                Navigation.PushAsync(new ItemsPage());
            };
            btnToRegisterPage.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new Registration());
            };  
        }
    }
}