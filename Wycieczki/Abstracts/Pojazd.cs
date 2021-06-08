using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Interfaces;

namespace Wycieczki.Abstracts
{
    public abstract class Pojazd : IPojazd
    {
        public abstract String Description();
    }
}
