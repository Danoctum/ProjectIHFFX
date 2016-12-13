using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectIHFF.Models
{
    [Table("Maaltijd")]
    public class Maaltijd : Event
    {
       
       

        private string maaltijd_categorie { get; set; } 
            

        public int event_id { get; set; }

        public int restaurant_id { get; set; }

        [ForeignKey("restaurant_id")]
        public virtual Restaurant restaurant { get; set; }

        [Key]
        [ForeignKey("event_id")]
        public virtual Event gebeurtenis { get; set; }

        public Maaltijd()
        {

        }

        public Maaltijd(int id, string categorie, Restaurant restaurant, Event gebeuren)
        {
            this.id = id;
            this.maaltijd_categorie = categorie;
            this.restaurant = restaurant;
            this.gebeurtenis = gebeuren;
        }

        public Maaltijd(string categorie, Restaurant restaurant, Event gebeuren)
        {
            this.maaltijd_categorie = categorie;
            this.restaurant = restaurant;
            this.gebeurtenis = gebeuren;
        }
    }
}
