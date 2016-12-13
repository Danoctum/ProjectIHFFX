using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIHFF.Models
{
  public  class MaaltijdRepository
    {
        private IHFFContext ctx = new IHFFContext();


        public IEnumerable<Restaurant> GetAllRestaurants()
        {

         /*   IEnumerable<Maaltijd> maaltijden = ctx.Maaltijds;

            List<Restaurant> rs = new List<Restaurant>();

            foreach (Maaltijd m in maaltijden)
                rs.Add(m.restaurant);
                */
            IEnumerable<Restaurant> list = ctx.Restaurant;
            return list;
          
        }
    }
}
