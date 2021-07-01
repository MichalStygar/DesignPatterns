using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wycieczki.Interfaces;

namespace Wycieczki.Models
{
    class StrongInsurance : IInsuranceStrategy
    {
        public double GetInsurance(int day)
        {
            double price = Math.Round(100.5 * day, 2);
            return price;
        }
    }
}
