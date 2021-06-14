using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Abstracts;
using Wycieczki.Utilities;

namespace Wycieczki.Models
{
    public class Jedzenie : Dekorator
    {
       // private readonly Logger _logger;
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
            Logger _logger = Logger.GetInstance();
            if (_wycieczka is Berlin)
            {
                double cena = _wycieczka.cena() + 100;
                _logger.LogMessage("Wycieczka do : " + _wycieczka.about() + " kosztuje z jedzeniem:"+ cena);
                return cena;
            }
            else if (_wycieczka is Warszawa)
            {
                double cena = _wycieczka.cena() + 50;
                _logger.LogMessage("Wycieczka do : " + _wycieczka.about() + " kosztuje z jedzeniem:" + cena);
                return cena;
            }
            return 0;
        }

        public override void Dodaj(Klient obserwator)
        {
            throw new NotImplementedException();
        }

        public override void Powiadomienie()
        {
            throw new NotImplementedException();
        }

        public override void Usun(Klient obserwator)
        {
            throw new NotImplementedException();
        }

        public override void zmienCene(double nowaCena)
        {
            _wycieczka.zmienCene(nowaCena);
        }
    }
}
