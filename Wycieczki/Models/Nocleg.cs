using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Abstracts;
using Wycieczki.Utilities;

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
            Logger _logger = Logger.GetInstance();
            double cena = _wycieczka.cena() + 150;
            _logger.LogMessage("Wycieczka do : " + _wycieczka.about() + " kosztuje z noclegiem:" + cena);
            return cena;
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
