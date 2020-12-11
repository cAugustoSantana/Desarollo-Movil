using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica_1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LeaguePage : ContentPage
    {
        public LeaguePage()
        {
            InitializeComponent();
            BindingContext = new LeagueViewModel();
            btnToRequestinfo.Clicked += (sender, e) =>
            {

                Navigation.PushAsync(new LeaguePage());
            };
        }
    }
}