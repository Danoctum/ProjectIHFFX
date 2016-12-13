using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectIHFF.Models
{
    public class Maaltijd
    {
        [Key]
        public int Id { get; set; }

        private string maaltijdCategorie;

        [ForeignKey("restaurant_id")]
        public Restaurant restaurant;

        [ForeignKey("EventId")]
        private Event gebeurtenis;

        public Maaltijd()
        {

        }

        public Maaltijd(int id, string categorie, Restaurant restaurant, Event gebeuren)
        {
            this.Id = id;
            this.maaltijdCategorie = categorie;
            this.restaurant = restaurant;
            this.gebeurtenis = gebeuren;
        }

        public Maaltijd(string categorie, Restaurant restaurant, Event gebeuren)
        {
            this.maaltijdCategorie = categorie;
            this.restaurant = restaurant;
            this.gebeurtenis = gebeuren;
        }
    }
}
