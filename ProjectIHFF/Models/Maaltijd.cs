using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
    public class Maaltijd
    {
        private int id;
        private string maaltijdCategorie;
        private Restaurant restaurant;
        private Event gebeurtenis;

        public Maaltijd()
        {

        }

        public Maaltijd(int id, string categorie, Restaurant restaurant, Event gebeuren)
        {
            this.id = id;
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
