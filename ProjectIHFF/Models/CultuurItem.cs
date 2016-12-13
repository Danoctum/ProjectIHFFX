using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ProjectIHFF.Models
{
    public class CultuurItem
    {
        [Key]
        public int Id { get; set; }

        public string naam { get; set; }
        public Locatie locatie { get; set; }
        public DateTime openingsstarttijd { get; set; }
        public DateTime openingseindtijd { get; set; }

        public CultuurItem()
        {

        }

        public CultuurItem(int id, string naam, Locatie locatie, DateTime openingsstarttijd, DateTime openingseindtijd)
        {
            this.Id = id;
            this.naam = naam;
            this.locatie = locatie;
            this.openingsstarttijd = openingsstarttijd;
            this.openingseindtijd = openingseindtijd; 
        }

        public CultuurItem(string naam, Locatie locatie, DateTime openingsstarttijd, DateTime openingseindtijd)
        {
            
            this.naam = naam;
            this.locatie = locatie;
            this.openingsstarttijd = openingsstarttijd;
            this.openingseindtijd = openingseindtijd;
        }
    }
}
