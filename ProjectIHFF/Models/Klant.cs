﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectIHFF.Models
{
    public class Klant
    {
        int id;

        string emailadres;
        string voornaam;
        string achternaam;
        string telefoonnummer;

        public Klant()
        {

        }

        public Klant(int id, string emailadres, string voornaam, string achternaam, string telefoonnummer)
        {
            this.id = id;
            this.emailadres = emailadres;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.telefoonnummer = telefoonnummer;
        }

        public Klant(string emailadres, string voornaam, string achternaam, string telefoonnummer)
        {

            this.emailadres = emailadres;
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.telefoonnummer = telefoonnummer;
        }
    }
}
