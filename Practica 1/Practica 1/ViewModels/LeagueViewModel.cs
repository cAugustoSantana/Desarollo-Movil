using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Practica_1.Services;

namespace Practica_1.ViewModels
{
    public class LeagueViewModel 
    {
        public ICommand GetLeagueInfoCommand { get; }
        public int league_id { get; set; }
        public string Name { get; set; }

        IFootballApi GetFootballApi = new ApiService();

        public event PropertyChangedEventHandler PropertyChanged;

        public LeagueViewModel()
        {
            GetLeagueInfoCommand = new Command(async () =>
            {
                if (Connectivity.NetworkAccess == NetworkAccess.Internet)
                {
                    var league = await GetFootballApi.GetLeagueAsync(league_id);
                    Name = league?.name ?? "No encontrada";
                }
                else
                {
                    //Alert
                    //Pantalla
                    //Retry
                }
            }
            );
        }
    }
}
