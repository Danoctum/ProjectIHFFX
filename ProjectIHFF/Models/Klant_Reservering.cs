using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
   public class Klant_Reservering
    {
     public int id;
        public int reservering_id;
        public int event_id;
        public float prijs { get; set; }

        public int aantal_personen { get; set; } 


        public Klant_Reservering()
        {

        }

        public Klant_Reservering(int id, int reservering_id, int event_id, float prijs, int aantal_personen)
        {
            this.id = id;
            this.reservering_id = reservering_id;
            this.event_id = event_id;
            this.prijs = prijs;
            this.aantal_personen = aantal_personen; 
        }

        public Klant_Reservering( int reservering_id, int event_id, float prijs, int aantal_personen)
        {
           
            this.reservering_id = reservering_id;
            this.event_id = event_id;
            this.prijs = prijs;
            this.aantal_personen = aantal_personen;
        }


    }
}
