using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
    class Pretpark
    {
        public string Naam { get; set; }
        public List<Werknemers> WerknemersLijst = new List<Werknemers>();
        public List<Attracties> AttractiesLijst = new List<Attracties>();
        public void Attractiesadd(string naam, string kleur, int minimumLeeftijd, int maximumAantalPersonen)
        {
            Attracties nieuweattractie = new Attracties(naam, kleur, minimumLeeftijd, maximumAantalPersonen);
            AttractiesLijst.Add(nieuweattractie);
        }
        public void Werknemersadd(string naam, string geboorteDatum, string geslacht)
        {
            Werknemers nieuwewerknemers = new Werknemers(naam, geboorteDatum, geslacht);
           WerknemersLijst.Add(nieuwewerknemers);
        }
        public void Attractiesdelete(int index)
        {
            AttractiesLijst.RemoveAt(index);
        }
        public void Werknemersdelete(int index)
        {
            WerknemersLijst.RemoveAt(index);
        }
        public string Attractiesbekijken(int index)
        {
            return  AttractiesLijst[index].Kleur + "\n" + AttractiesLijst[index].MinimumLeeftijd + "\n" + AttractiesLijst[index].MaximumAantalPersonen;
        }
        public string Werknemersbekijken(int index)
        {
            return WerknemersLijst[index].Naam + "\n" + WerknemersLijst[index].GeboorteDatum + "\n" + WerknemersLijst[index].Geslacht;
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
    
}
