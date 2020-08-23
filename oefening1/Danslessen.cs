using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
   public class Danslessen
    {
        public List<Dansstudent> dansstudentslijst { get; set; }
        public Danslessen()
        {
            dansstudentslijst = new List<Dansstudent>();
        }

        public void Studenttoevoegen(string naam,string geslacht,int Leeftijd)
        {
            Dansstudent student = new Dansstudent( naam, geslacht, Leeftijd);
            dansstudentslijst.Add(student);

        }
        public List<string> Finalestudenten()
        {
            List<string> studenten = new List<string>();
            Random rnd = new Random();
            if (dansstudentslijst.Count > 6)
            {
                List<string> leerlingen = dansstudentslijst.Select(x => x.Naam).ToList();
                for (int i = 0; i < 6; i++)
                {
                    int selected = rnd.Next(0, leerlingen.Count);
                    studenten.Add(leerlingen[selected]);
                    leerlingen.RemoveAt(selected);

                }
            }
            return studenten;
        }
        
    }
}
