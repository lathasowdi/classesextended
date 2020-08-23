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
      public List<Afspraak> AfspraakLijst { get; set; }

        public Dokter(string naam)
        {
            Naam = naam;
            AfspraakLijst = new List<Afspraak>();
        }
        public override string ToString()
        {
            return Naam;
        }
        //public string Kijk()
        //{
        //    foreach(var item in AfspraakLijst)
        //    {
        //        item.Afspraakbekijken();
        //    }
        //}

    }
}
