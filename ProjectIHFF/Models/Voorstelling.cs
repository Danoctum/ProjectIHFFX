using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
    [Table("Voorstelling")]
    public class Voorstelling : Event
    {
        //fields


        public int event_id { get; set; }

        [Key]
        [ForeignKey("EventId")]
        public virtual Event Event { get; set; }

      
        public int film_id { get; set; }

        [ForeignKey("film_id")]
        public virtual Film Film { get; set; }

        public Boolean is_highlight { get; set; }

        //properties
      
 

        public Voorstelling()
        {

        }

        public Voorstelling(int id, Event gebeurtenis,Film film, Boolean isHighlight)
        {
            this.id = id;
            this.Event = gebeurtenis;
            this.Film = film;
            this.is_highlight = isHighlight;
            this.Film = film;
        }


        public Voorstelling(Event gebeurtenis, Film film, Boolean isHighlight)
        {
            this.Event = gebeurtenis;
            this.Film = film;
            this.is_highlight = isHighlight;
            this.Film = film;
        }

    }
}
