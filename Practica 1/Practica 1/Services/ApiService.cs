using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Practica_1.Models;
using System.Net.Http.Headers;

namespace Practica_1.Services
{
    public class ApiService : IFootballApi
    {

        public async Task<League> GetLeagueAsync(int league_id)
        {
            League league = null;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "e60b69b4f2mshf51fd45766a05c6p1ab873jsn255c64137f49");
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "api-football-v1.p.rapidapi.com");
            var response = await client.GetAsync("https://api-football-v1.p.rapidapi.com/v2/leagues" + league_id) ;

            if (response.IsSuccessStatusCode)
            {
                league = JsonConvert.DeserializeObject<League>(await response.Content.ReadAsStringAsync());
            }
            else if(response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                throw new Exception("Server error");
            }
            return league;
        }
    }
}
