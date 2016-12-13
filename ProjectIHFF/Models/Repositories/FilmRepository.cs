using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectIHFF.Models
{
    public class FilmRepository
    {
        private IHFFContext ctx = new IHFFContext();

        public IEnumerable<Voorstelling> GetAllFilmsByDay(DateTime date)
        {
            List<Film> films = new List<Film>();
           /* IEnumerable<Event> events = ctx.Events.Where(e => e.beginDatumTijd == date);
            List<Film> films = new List<Film>();

            foreach (Event e in events)
            {
                Voorstelling voorstelling = ctx.Voorstellings.FirstOrDefault(v => v.id == e.id);
                Film film = ctx.Films.FirstOrDefault(f => f.id == voorstelling.id);
                films.Add(film);
            }

            return films; */
  
            
            /* var queryfilms = from v in ctx.Voorstellings
                        join e in ctx.Events on v.eventId equals e.id
                        join f in ctx.Films on v.Film.id equals f.id
                        join l in ctx.Locaties on e.Locatie.Id equals l.Id
                        where e.beginDatumTijd == date &&
                              v.eventId == e.id &&
                              v.Film.id == f.id &&
                              e.Locatie.Id == l.Id
                        select new { filmId = f.id , naam = f.Naam, beschrijving = f.Beschrijving , 
                        trailer = f.TrailerURL , poster = f.PosterURL , rating = f.Rating , begindatum = e.beginDatumTijd ,
                        einddatum = e.eindDatumTijd, prijs = e.prijs, locatie = l 
                        }; */
            DateTime dag = Convert.ToDateTime(date);

            /*var queryfilms = from v in ctx.Voorstellings
                             join e in ctx.Events on v.Event.id equals e.id
                             join f in ctx.Films on v.Film.Id equals f.Id
                             join l in ctx.Locaties on e.Locatie.Id equals l.Id
                             where e.beginDatumTijd == dag
                             && e.eindDatumTijd == dag
                             orderby e.beginDatumTijd
                             select new
                             {
                                 filmId = f.Id,
                                 naam = f.Naam,
                                 beschrijving = f.beschrijving,
                                 trailer = f.trailer_url,
                                 poster = f.poster_url,
                                 rating = f.rating,
                                 begindatum = e.beginDatumTijd,
                                 einddatum = e.eindDatumTijd,
                                 prijs = e.Prijs,
                                 locatieId = l.Id,
                                 locatieNaam = l.Naam,
                                 locatieCapaciteit = l.Capaciteit,
                                 locatieZaal = l.Zaal,
                                 locatieStraat = l.Straat,
                                 locatieHuisnr = l.HuisNummer,
                                 locatieToevoeging = l.Toevoeging,
                                 locatiePostcode = l.Postcode,
                                 locatiePlaats = l.Plaats
                             };

            foreach (var film in queryfilms)
            {
                Locatie locatie = new Locatie(film.locatieId, film.locatieCapaciteit, film.locatieNaam, film.locatieZaal, film.locatieStraat, film.locatieHuisnr, film.locatieStraat, film.locatiePostcode, film.locatiePlaats);
                Film ofilm = new Film((int)film.filmId, (string)film.beschrijving, (string)film.trailer, (string)film.poster, (float)film.rating, (float)film.prijs, (string)film.naam, (DateTime)film.begindatum, (DateTime)film.einddatum, locatie);
                films.Add(ofilm);
            }*/

            IEnumerable<Voorstelling> voorstellingen = ctx.Voorstellings;


            return voorstellingen.AsEnumerable();
            

                
        }
        
    }
}