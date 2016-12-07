using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
    class Special : Event
    {
        public string Beschrijving { get; set; }
        public Event Gebeurtenis { get; set; }
        public string Naam { get; set; }
        public string Spreker { get; set; }


        public Special()
            : base()
        {

        }

        public Special(string beschrijving, Locatie locatie,Event gebeurtenis, string naam, string spreker,float prijs, DateTime beginDatum, DateTime eindDatum)
            :base(prijs,naam,beginDatum,eindDatum,locatie)
        {
            this.Beschrijving = beschrijving;
            this.Gebeurtenis  = gebeurtenis;
            this.Naam = naam;
            this.Spreker = spreker;
        }

        public Special(int id, string beschrijving, Locatie locatie, Event gebeurtenis, string naam, string spreker, float prijs, DateTime beginDatum, DateTime eindDatum)
            : base(id,prijs, naam, beginDatum, eindDatum, locatie)
        {
            this.Beschrijving = beschrijving;
            this.Gebeurtenis = gebeurtenis;
            this.Naam = naam;
            this.Spreker = spreker;
        }
    }
}
