using ProjectIHFF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectIHFF.Controllers
{
    public class RestaurantController : Controller
    {
        private PresentationViews presentation = new PresentationViews();
        //
        // GET: /Restaurant/
        public ActionResult Index()
        {
            IEnumerable<Restaurant> restaurants = presentation.GetAllRestaurants(); 
            return View(restaurants);
        }
	}
}