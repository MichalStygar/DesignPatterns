using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Abstracts;
using Wycieczki.Interfaces;

namespace Wycieczki.Models
{
    public class Berlin : Wycieczka,IObserwowany<Klient>
    {
        private double _cena;
        private  List<Klient> klienciBerlin = new List<Klient>();

        public Berlin()
        {
            wycieczka = "Berlin";
            _cena = 500;
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
