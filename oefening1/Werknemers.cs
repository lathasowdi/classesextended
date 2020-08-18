using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
    class Werknemers
    {
        public string Naam { get; set; }
        public string GeboorteDatum { get; set; }
        public  string Geslacht { get; set; }

        public Werknemers(string naam, string geboorteDatum, string geslacht)
        {
            Naam = naam;
            GeboorteDatum = geboorteDatum;
            Geslacht = geslacht;
        }
    }
}
