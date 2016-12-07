using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
    public class Reservering
    {
       public int id;
       public int klantid;
        public bool is_betaald { get; set;}
        public bool is_geannuleerd { get; set; }
        public DateTime besteldatum { get; set; }
        public string ophaalcode { get; set; }

        public Reservering()
        {

        }

        public Reservering(int id, int klantid, bool is_betaald, bool is_geannuleerd, DateTime besteldatum, string ophaalcode)
        {
            this.id = id;
            this.klantid = klantid;
            this.is_betaald = is_betaald;
            this.is_geannuleerd = is_geannuleerd;
            this.besteldatum = besteldatum;
            this.ophaalcode = ophaalcode; 
        }

        public Reservering( bool is_betaald, bool is_geannuleerd, DateTime besteldatum, string ophaalcode)
        {
            
            this.is_betaald = is_betaald;
            this.is_geannuleerd = is_geannuleerd;
            this.besteldatum = besteldatum;
            this.ophaalcode = ophaalcode;
        }
    }
}
