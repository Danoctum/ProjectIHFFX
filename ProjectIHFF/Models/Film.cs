using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
   
    public class Film : Event
    {
        [Key]
        public int? Id { get; set; }

        public string naam { get; set; }
        public string beschrijving { get; set; }
        public string trailer_url { get; set; }
        public string poster_url { get; set; }
        public float rating { get; set; }

        public virtual ICollection<Voorstelling> Voorstellingen { get; set; }

        public Film()
            : base()
        {

        }

        public Film(int id, string beschrijving, string trailer, string poster, float rating, double prijs, string naam, DateTime beginDatum, DateTime eindDatum, Locatie locatie)
            : base(id, prijs, naam, beginDatum, eindDatum, locatie)
        {
            this.beschrijving = beschrijving;
            this.trailer_url = trailer;
            this.poster_url = poster;
            this.rating = rating;
        }

        public Film(string beschrijving, string trailer, string poster, float rating, double prijs, string naam, DateTime beginDatum, DateTime eindDatum, Locatie locatie)
            : base(prijs, naam, beginDatum, eindDatum, locatie)
        {
            this.beschrijving = beschrijving;
            this.trailer_url = trailer;
            this.poster_url = poster;
            this.rating = rating;
        }
    }
}