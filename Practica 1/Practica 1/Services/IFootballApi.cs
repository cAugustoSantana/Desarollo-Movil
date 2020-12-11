using System;
using System.Collections.Generic;
using System.Text;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Practica_1.Models;
namespace Practica_1.Services
{
    public interface IFootballApi
    {
        
        Task<League> GetLeagueAsync(int league_id);
    }
}
