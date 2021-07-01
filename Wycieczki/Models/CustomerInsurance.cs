using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wycieczki.Interfaces;

namespace Wycieczki.Models
{
    public class CustomerInsurance
    {
        private IList<double> insurances;
        public IInsuranceStrategy Strategy { get; set; }
        public Customer customer { get; set; }
        public CustomerInsurance(IInsuranceStrategy strategy, Customer customer)
        {
            this.insurances = new List<double>();
            this.Strategy = strategy;
            this.customer = customer;
        }

        public void Add(int price)
        {
            this.insurances.Add(this.Strategy.GetInsurance(price));
        }

        public void Print()
        {
            double sum = 0;
            foreach(var insuranceCost in this.insurances)
            {
                sum += insuranceCost;
            }
            Console.WriteLine($"Koszt ubezpieczenia dla {this.customer.Name} {this.customer.SurName} wynosi: {sum} zł");
            this.insurances.Clear();
        }

    }
}
