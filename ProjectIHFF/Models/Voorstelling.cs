using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
    public class Voorstelling
    {
        //fields
        public int id;
        public int eventId;
        public Boolean isHighlight;

        //properties
        public Boolean IsHighlight { get { return isHighlight; } set { isHighlight = value; } }
        public Film Film { get; set; }

        public Voorstelling()
        {

        }

        public Voorstelling(int id, int eventId, Boolean isHighlight, Film film)
        {
            this.id = id;
            this.eventId = eventId;
            this.IsHighlight = isHighlight;
            this.Film = film;
        }


        public Voorstelling(int eventId, Boolean isHighlight, Film film)
        {
            this.eventId = eventId;
            this.IsHighlight = isHighlight;
            this.Film = film;
        }

    }
}
