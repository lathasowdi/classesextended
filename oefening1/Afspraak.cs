using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
    class Afspraak
    { 
        public string Datum { get; set; }
        public string UUR { get; set; }
        public string Naam { get; set; }

        public Afspraak(string datum, string uUR, string naam)
        {
            Datum = datum;
            UUR = uUR;
            Naam = naam;
        }
    }
}
