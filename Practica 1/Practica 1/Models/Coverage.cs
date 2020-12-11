using System;
using System.Collections.Generic;
using System.Text;
using Practica_1.Models;

namespace Practica_1.Models
{
    public class Coverage
    {
        public bool standings { get; set; }
        public Fixture fixture { get; set; }

        public bool players { get; set; }
        public bool topScorers { get; set; }

        public bool predictions { get; set; }

        public bool odds { get; set; }
    }
}
