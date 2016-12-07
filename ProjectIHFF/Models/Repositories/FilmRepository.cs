using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectIHFF.Models
{
    public class FilmRepository
    {
        private IHFFContext ctx = new IHFFContext();

        public IEnumerable<Film> GetAllFilmsByDay(DateTime date)
        {
            IEnumerable<Event> events = ctx.Events.Where(e => e.beginDatumTijd == date);
            List<Film> films = new List<Film>();

            foreach (Event e in events)
            {
                Voorstelling voorstelling = ctx.Voorstellings.FirstOrDefault(v => v.id == e.id);
                Film film = ctx.Films.FirstOrDefault();

            }

            return films;
        }
        
    }
}