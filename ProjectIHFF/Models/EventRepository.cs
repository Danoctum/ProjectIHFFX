using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectIHFF.Models
{
    public class EventRepository
    {
        private IHFFContext ctx = new IHFFContext();

        public IEnumerable<Event> GetAllEvents()
        {
            IEnumerable<Event> events = ctx.Events;
            return events;
        } 

        
    }
}