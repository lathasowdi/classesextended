using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
    class Afspraak
    { 
        public DateTime Datum { get; set; }
        public int UUR { get; set; }
        public string Naam { get; set; }

        public Afspraak(DateTime datum, int uUR, string naam)
        {
            Datum = datum;
            UUR = uUR;
            Naam = naam;
        }
        public string Afspraakbekijken()
        {
            return $"Datum:{Datum}" + "\n"
                + $"UUR:{UUR}" + "\n"
                + $"Naam:{Naam}" + "\n";
        }
        
    }
}
