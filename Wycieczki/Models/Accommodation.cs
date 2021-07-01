using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Abstracts;
using Wycieczki.Interfaces;
using Wycieczki.Utilities;

namespace Wycieczki.Models
{
    public class Accommodation : Decorator
    {

        ITrip _trip;

        public Accommodation(ITrip trip) :base(trip)
        {
            _trip = trip;
        }

        public override String Description()
        {
            return _trip.Description() + " + nocleg";
        }


        public override double Price()
        {
            Logger _logger = Logger.GetInstance();
            double cena = _trip.Price() + 150;
            _logger.LogMessage("Wycieczka do : " + _trip.Description() + " kosztuje z noclegiem:" + cena);
            return cena;
        }

        
    }
}
