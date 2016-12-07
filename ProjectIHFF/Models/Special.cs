using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
public    class Special : Event
    {
        public string Beschrijving { get; set; }
       
        public string Spreker { get; set; }


        public Special()
            : base()
        {

        }

        public Special(string beschrijving, Locatie locatie, string naam, string spreker,float prijs, DateTime beginDatum, DateTime eindDatum)
            :base(prijs,naam,beginDatum,eindDatum,locatie)
        {
            this.Beschrijving = beschrijving;
           
            this.Spreker = spreker;
        }

        public Special(int id, string beschrijving, Locatie locatie, string naam, string spreker, float prijs, DateTime beginDatum, DateTime eindDatum)
            : base(id,prijs, naam, beginDatum, eindDatum, locatie)
        {
            this.Beschrijving = beschrijving;
        
            this.Spreker = spreker;
        }
    }
}
