using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Interfaces;
using Wycieczki.Models;

namespace Wycieczki.Abstracts
{
    public abstract class Wycieczka :IWycieczka, IObserwowany<Klient>
    {
        protected string wycieczka = "Wycieczka podstawowa";

        virtual public String about()
        {
            return wycieczka;
        }

        public abstract double cena();

        public abstract void Dodaj(Klient obserwator);


        public abstract void Powiadomienie();



        public abstract void Usun(Klient obserwator);


        public abstract void zmienCene(double nowaCena);
    }
}
