using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Abstracts;

namespace Wycieczki.Models
{
    public class Warszawa : Wycieczka
    {

        public Warszawa()
        {
            wycieczka = "Warszawa";
        }

        public override double cena()
        {
            return 300;
        }
    }
}
