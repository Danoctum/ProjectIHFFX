using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
    public class CultuurItem
    {
        public int id;
        public string naam { get; set; }
        public Locatie locatie { get; set; }
        public DateTime openingsstarttijd { get; set; }
        public DateTime openingseindtijd { get; set; }

        public CultuurItem()
        {

        }

        public CultuurItem(int id, string naam, Locatie locatie, DateTime openingsstarttijd, DateTime openingseindtijd)
        {
            this.id = id;
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
