using System;
using System.Collections.Generic;
using System.Text;

using Wycieczki.Interfaces;

namespace Wycieczki.Models
{
    public class Warsaw : ITrip, Interfaces.IObservable<Customer>
    {
        public string Trip { get; set; }
        private double _price;
        private List<Customer> customerBerlin = new List<Customer>();

        public Warsaw()
        {
            Trip = "Warszawa";
            _price = 300;
        }

        public  double Price()
        {
            return _price;
        }
        public string Description()
        {
            return Trip;
        }
        public  void Subscribe(Customer observer)
        {
            customerBerlin.Add(observer);
            Console.WriteLine("Dodano: " + observer.Name);
        }

        public  void Notify()
        {
            customerBerlin.ForEach(x => x.Update(this));
        }

        public  void Unsubscribe(Customer observer)
        {

            customerBerlin.Remove(observer);
            Console.WriteLine("Usunięto: " + observer.Name);
            


        }

        public  void ChangePrice(double newPrice)
        {
            if (newPrice != _price)
            {
                _price = newPrice;
                Notify();
            }

        }

        
    }
}
