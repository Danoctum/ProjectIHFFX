using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
  public  class Event
    {
        [Key]
        public int id { get; set; }

        public double prijs { get; set; }

        public string naam { get; set; }
        public DateTime begin_datumtijd { get; set; }
        public DateTime eind_datumtijd { get; set; }
        public int locatie_id { get; set; }
        public Locatie Locatie { get; set; }

        [NotMapped]
        public virtual Voorstelling VoorstellingItem { get; set; }

        public Event()
        {

        }

        public Event(int id, double prijs, string naam, DateTime beginDatum, DateTime eindDatum, Locatie locatie)
        {
            this.id = id;
            this.prijs = prijs;
            this.naam = naam;
            this.begin_datumtijd = beginDatum;
            this.eind_datumtijd = eindDatum;
            this.Locatie = locatie;
        }

        public Event(double prijs, string naam, DateTime beginDatum, DateTime eindDatum, Locatie locatie)
        {
            this.prijs = prijs;
            this.naam = naam;
            this.begin_datumtijd = beginDatum;
            this.eind_datumtijd = eindDatum;
            this.Locatie = locatie;
        }
    }
}
