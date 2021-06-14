using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Abstracts;
using Wycieczki.Interfaces;

namespace Wycieczki.Models
{
    public class Warszawa : Wycieczka, IObserwowany<Klient>
    {
        private double _cena;
        private List<Klient> klienciBerlin = new List<Klient>();

        public Warszawa()
        {
            wycieczka = "Warszawa";
            _cena = 300;
        }

        public override double cena()
        {
            return _cena;
        }

        public override void Dodaj(Klient obserwator)
        {
            klienciBerlin.Add(obserwator);
            Console.WriteLine("Dodano: " + obserwator.Imie);
        }

        public override void Powiadomienie()
        {
            klienciBerlin.ForEach(x => x.Aktualizuj(this));
        }

        public override void Usun(Klient obserwator)
        {
            
                klienciBerlin.Remove(obserwator);
                Console.WriteLine("Usunięto: " + obserwator.Imie);
            


        }

        public override void zmienCene(double nowaCena)
        {
            if (nowaCena != _cena)
            {
                _cena = nowaCena;
                Powiadomienie();
            }

        }
    }
}
