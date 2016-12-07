using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
  public  class Event
    {
        public int id;
        public float prijs;

        public string Naam { get; set; }
        public DateTime beginDatumTijd { get; set; }
        public DateTime eindDatumTijd { get; set; }
        public Locatie Locatie { get; set; }

        public Event()
        {

        }

        public Event(int id, float prijs, string naam, DateTime beginDatum, DateTime eindDatum, Locatie locatie)
        {
            this.id = id;
            this.prijs = prijs;
            this.Naam = naam;
            this.beginDatumTijd = beginDatum;
            this.eindDatumTijd = eindDatum;
            this.Locatie = locatie;
        }

        public Event(float prijs, string naam, DateTime beginDatum, DateTime eindDatum, Locatie locatie)
        {
            this.prijs = prijs;
            this.Naam = naam;
            this.beginDatumTijd = beginDatum;
            this.eindDatumTijd = eindDatum;
            this.Locatie = locatie;
        }
    }
}
