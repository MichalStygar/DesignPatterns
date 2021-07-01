using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Models;

namespace Wycieczki.Interfaces
{
    public interface ITrip
    {
        public string Description();
        public double Price();

        public void Subscribe(Customer observer);


        public void Notify();


        public void Unsubscribe(Customer observer);


        public void ChangePrice(double newPrice);
        
        
    }
}
