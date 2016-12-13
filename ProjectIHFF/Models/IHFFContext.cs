using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProjectIHFF.Models
{
    public class IHFFContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
          /*  modelBuilder.Entity<Voorstelling>()
               .HasRequired<Event>(v => v.Event)
               .WithOptional(e => e.VoorstellingItem)
               .WillCascadeOnDelete(); */

           modelBuilder.Entity<Voorstelling>()
                .HasRequired<Film>(v => v.Film)
                .WithMany(f => f.Voorstellingen)
                .HasForeignKey(v => v.film_id); 

            modelBuilder.Entity<Voorstelling>()
               .HasRequired<Event>(v => v.Event)
               .WithMany()
               .HasForeignKey(v => v.event_id);


            /*  modelBuilder.Entity<Voorstelling>()
                  .HasOptional<Film>(v => v.Film)
                  .WithMany()
                  .HasForeignKey(v => v.FilmId); */
            modelBuilder.Entity<Maaltijd>()
               .HasRequired<Restaurant>(m => m.restaurant)
               .WithMany(r => r.Maaltijden)
               .HasForeignKey(m => m.restaurant_id);

            modelBuilder.Entity<Maaltijd>()
                .HasRequired<Event>(m => m.gebeurtenis)
                .WithMany()
                .HasForeignKey(m => m.event_id);

        }

        public IHFFContext()
            : base("IHFFConnection")
        {

        }

        public DbSet<Reservering> Reserverings { get; set; }
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