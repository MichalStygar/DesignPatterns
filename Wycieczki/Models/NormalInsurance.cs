using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wycieczki.Interfaces;

namespace Wycieczki.Models
{
    public class NormalInsurance : IInsuranceStrategy
    {
        public double GetInsurance(int day)
        {
            double price = Math.Round(50.3 * day, 2);
            return price;
        }
    }
}
