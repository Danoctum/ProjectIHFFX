using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
    class Film : Event
    {
        public string Beschrijving { get; set; }
        public string TrailerURL { get; set; }
        public string PosterURL { get; set; }
        public float Rating { get; set; }

        public Film():base()
        {

        }

        public Film(int id, string beschrijving, string trailer, string poster, float rating, float prijs, string naam, DateTime beginDatum, DateTime eindDatum, Locatie locatie)
            : base(id,prijs, naam, beginDatum, eindDatum, locatie)
        {
            this.Beschrijving = beschrijving;
            this.TrailerURL = trailer;
            this.PosterURL = poster;
            this.Rating = rating;
        }

        public Film(string beschrijving, string trailer, string poster, float rating, float prijs, string naam, DateTime beginDatum, DateTime eindDatum, Locatie locatie)
            : base(prijs, naam, beginDatum, eindDatum, locatie)
        {
            this.Beschrijving = beschrijving;
            this.TrailerURL = trailer;
            this.PosterURL = poster;
            this.Rating = rating;
        }
    }
}