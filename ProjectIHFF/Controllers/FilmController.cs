using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectIHFF.Models;

namespace ProjectIHFF.Controllers
{
    public class FilmController : Controller
    {
        //
        // GET: /Film/
        private PresentationViews presentation = new PresentationViews();

        public ActionResult Index()
        {
            IEnumerable<Voorstelling> filmsWoensdag = presentation.GetFilmsByDay(new DateTime(2017, 1, 11,00,00,00));
            //IEnumerable<Event> filmsWoensdag = presentation.GetAll();
            return View(filmsWoensdag);
        }
	}
}