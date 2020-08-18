using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
    class Dokter
    {
        public string Naam { get; set; }
        List<Afspraak> AfspraakLijst = new List<Afspraak>();

        public Dokter(string naam)
        {
            Naam = naam;
        }
    }
}
