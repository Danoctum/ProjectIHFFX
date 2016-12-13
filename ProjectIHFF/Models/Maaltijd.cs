using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
    public class Maaltijd
    {
        [Key]
        public int Id { get; set; }

        private string maaltijdCategorie;
        private Restaurant restaurant;
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
