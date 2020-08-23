using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening1
{
    class Ziekenhuis
    {
        public List<Dokter> DokterList { get; set; }

        private  List<string> naamlijst = new List<string>() { "Dr Vishnu", "Dr Atchaya", "Dr Latha", "Dr Bhavana" };

        public Ziekenhuis()
        {
            DokterList = new List<Dokter>();
            for (int i = 0; i < naamlijst.Count; i++)
            {
                DokterList.Add(new Dokter(naamlijst[i]));
            }
        }
        //public List<Dokter> DokterAfsprakenLijst = new List<Dokter>();

        //public void DrAfsprakenToevoegen(string naam)
        //{
        //    Dokter newDokter = new Dokter(naam);
        //    DokterAfsprakenLijst.Add(newDokter);
        //}

    }

}

