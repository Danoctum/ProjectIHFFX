using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectIHFF.Models
{
    public class PresentationViews
    {
        private MaaltijdRepository maaltijdrepository = new MaaltijdRepository(); 
        private FilmRepository filmrepository = new FilmRepository();
        private IHFFContext ctx = new IHFFContext();

        public PresentationViews()
        {

        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return maaltijdrepository.GetAllRestaurants(); 
        }

        public IEnumerable<Voorstelling> GetFilmsByDay(DateTime date)
        {
            return filmrepository.GetAllFilmsByDay(date);
        }

        public IEnumerable<Event> GetAll()
        {
            return ctx.Events;
        }
        
    }
}