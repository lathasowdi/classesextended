using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
    public class Dansstudent
    { 
        public string Naam { get; set; }
        public string Geslacht { get; set; }
        public int Leeftijd { get; set; }

        public Dansstudent(string naam, string geslacht, int leeftijd)
        {
            Naam = naam;
            Geslacht = geslacht;
            Leeftijd = leeftijd;
        }
    }
}
