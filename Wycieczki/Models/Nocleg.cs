using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Abstracts;

namespace Wycieczki.Models
{
    public class Nocleg : Dekorator
    {
        Wycieczka _wycieczka;

        public Nocleg(Wycieczka wycieczka)
        {
            _wycieczka = wycieczka;
        }

        public override String about()
        {
            return _wycieczka.about() + " + nocleg";
        }


        public override double cena()
        {
            return _wycieczka.cena() + 150;
        }
    }
}
