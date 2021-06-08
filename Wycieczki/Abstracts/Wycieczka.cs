using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Interfaces;

namespace Wycieczki.Abstracts
{
    public abstract class Wycieczka :IWycieczka
    {
        protected string wycieczka = "Wycieczka podstawowa";

        virtual public String about()
        {
            return wycieczka;
        }

        public abstract double cena();
    }
}
