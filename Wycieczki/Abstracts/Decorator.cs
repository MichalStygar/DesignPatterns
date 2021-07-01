using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Interfaces;
using Wycieczki.Models;

namespace Wycieczki.Abstracts
{
    public abstract class Decorator : ITrip
    {
        ITrip trip;

        public Decorator(ITrip trip) { this.trip = trip; }
        public virtual String Description() { return trip.Description(); }

        public virtual double Price() { return trip.Price(); }

        public void Subscribe(Customer observer) { }
        
        public void Notify() { }
        
        public void Unsubscribe(Customer observer) { }   

        public void ChangePrice(double newPrice) { }
        

        
        
    }
}
