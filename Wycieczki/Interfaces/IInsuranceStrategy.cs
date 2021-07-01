using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wycieczki.Models;

namespace Wycieczki.Interfaces
{
    public interface IInsuranceStrategy
    {
        public double GetInsurance(int day);
    }
}
