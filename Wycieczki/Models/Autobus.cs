using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Abstracts;
using Wycieczki.Interfaces;

namespace Wycieczki.Models
{
   public class Autobus : Pojazd
    {
        public override string Description()
        {
            return "Transport autobus";
        }
    }
}
