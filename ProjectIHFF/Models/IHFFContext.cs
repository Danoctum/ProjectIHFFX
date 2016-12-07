using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectIHFF.Models
{
    public class IHFFContext : DbContext
    {
        public IHFFContext()
            : base("IHFFConnection")
        {

        }

        public DbSet<Reservering> Reservings { get; set; }
        public DbSet<Klant> Klants { get; set; }
        public DbSet<Klant_Reservering> klant_reserverings { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Maaltijd> Maaltijds { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Locatie> Locaties { get; set; }
        public DbSet<Special> Specials { get; set; }
        public DbSet<Voorstelling> Voorstellings { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<CultuurItem> CultuurItems { get; set; }
 

    }
}