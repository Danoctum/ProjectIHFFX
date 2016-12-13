using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
public    class Restaurant : Event
    {

       [Key]
        public int id_naam { get; set; }

        public string beschrijving { get; set; }
        public string afbeelding_url { get; set; }
        public string locatie_url { get; set; }
        public float cijfer { get; set; }

        public Restaurant(): base()
        {

        }

        public Restaurant(int id, int id_naam, string beschrijving, string afbeelding_url, string locatie_url, float cijfer, float prijs, string naam, DateTime beginDatum, DateTime eindDatum, Locatie locatie ) 
            :base(id, prijs, naam, beginDatum, eindDatum, locatie)
        {
           
            
            this.beschrijving = beschrijving;
            this.afbeelding_url = afbeelding_url;
            this.locatie_url = locatie_url;
            this.cijfer = cijfer;
        }

        public Restaurant( int id_naam, string beschrijving, string afbeelding_url, string locatie_url, float cijfer, float prijs, string naam, DateTime beginDatum, DateTime eindDatum, Locatie locatie)
            : base( prijs, naam, beginDatum, eindDatum, locatie)
        {


            this.beschrijving = beschrijving;
            this.afbeelding_url = afbeelding_url;
            this.locatie_url = locatie_url;
            this.cijfer = cijfer;
        }
    }
}
