using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
    public class Locatie
    {

        private int id;
        //properties
        public int Capaciteit { get; set; }
        public string Naam { get; set; }
        public string Zaal { get; set; }
        public string Straat { get; set; }
        public int HuisNummer { get; set; }
        public char Toevoeging { get; set; }
        public string Postcode { get; set; }
        public string Plaats { get; set; }

        public Locatie()
        {

        }

        public Locatie(int id, int capaciteit, string naam, string zaal, string straat, int nummer, char toevoeging, string postcode, string plaats)
        {
            this.id = id;
            this.Capaciteit = capaciteit;
            this.Naam = naam;
            this.Zaal = zaal;
            this.Straat = straat;
            this.HuisNummer = nummer;
            this.Toevoeging = toevoeging;
            this.Postcode = postcode;
            this.Plaats = plaats;
        }

        public Locatie(int capaciteit, string naam, string zaal, string straat, int nummer, char toevoeging, string postcode, string plaats)
        {
            this.Capaciteit = capaciteit;
            this.Naam = naam;
            this.Zaal = zaal;
            this.Straat = straat;
            this.HuisNummer = nummer;
            this.Toevoeging = toevoeging;
            this.Postcode = postcode;
            this.Plaats = plaats;
        }




    }
}
