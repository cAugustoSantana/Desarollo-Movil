using System;
using System.Collections.Generic;
using System.Text;
using Practica_1.Models;

namespace Practica_1.Models
{
    public class League
    {
        public int league_id { get; set; }
        public string name { get; set; }

        public string type { get; set; }
        public string country { get; set; }
        public string  country_code {get;set;}

        public int season { get; set; }

        public string season_start { get; set; }

        public string season_end { get; set; }

        public string logo { get; set; }

        public string flag { get; set; }

        public int standings { get; set; }

        public int is_current { get; set; }

        public Coverage coverage { get; set; }







    }
}
