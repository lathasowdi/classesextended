using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
    class Attracties
    {
        public string Naam { get; set; }
        public string Kleur { get; set; }
        public int MinimumLeeftijd { get; set; }
        public int MaximumAantalPersonen { get; set; }

        public Attracties(string naam, string kleur, int minimumLeeftijd, int maximumAantalPersonen)
        {
            Naam = naam;
            Kleur = kleur;
            MinimumLeeftijd = minimumLeeftijd;
            MaximumAantalPersonen = maximumAantalPersonen;
        }
    }
}
