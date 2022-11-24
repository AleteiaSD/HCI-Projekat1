using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    [Serializable]
    public class Clan
    {
        public String SlikaClana { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public int Starost { get; set; }
        public String Cin { get; set; }
        public String Datum { get; set; }

        public String Detalji { get; set; }
        
        public Clan()
        {
            Ime = "";
            Prezime = "";
            Starost = 0;
            Cin = "";
            Datum = "";
            SlikaClana = "";
            Detalji = "";
        }
        public Clan(string slikaClana="", string ime="", string prezime = "", int starost=0, string cin = "", string datum = "", string detalji = "")
        {
            SlikaClana = slikaClana;
            Ime = ime;
            Prezime = prezime;
            Starost = starost;
            Cin = cin;
            Datum = datum;
            Detalji = detalji;
        }

    }
}
