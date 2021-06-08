using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Abstracts;

namespace Wycieczki.Models
{
    public class Jedzenie : Dekorator
    {
        Wycieczka _wycieczka;

        public Jedzenie(Wycieczka wycieczka)
        {
            _wycieczka = wycieczka;
        }

        public override String about()
        {
            return _wycieczka.about() + " + jedzenie";
        }

        public override double cena()
        {
            if (_wycieczka is Berlin)
            {
                return _wycieczka.cena() + 100;
            }
            else if (_wycieczka is Warszawa)
            {
                return _wycieczka.cena() + 50;
            }
            return 0;
        }
    }
}
