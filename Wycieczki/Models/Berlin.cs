using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Abstracts;

namespace Wycieczki.Models
{
    public class Berlin : Wycieczka
    {

        public Berlin()
        {
            wycieczka = "Berlin";
        }

        public override double cena()
        {
            return 500;
        }
    }
}
