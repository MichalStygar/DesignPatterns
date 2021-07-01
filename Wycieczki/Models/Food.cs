using System;
using System.Collections.Generic;
using System.Text;
using Wycieczki.Abstracts;
using Wycieczki.Interfaces;
using Wycieczki.Utilities;

namespace Wycieczki.Models
{
    public class Food : Decorator
    {
        ITrip _trip;

        public Food(ITrip trip):base(trip)
        {
            _trip = trip;
        }

        public override String Description()
        {
            return _trip.Description() + " + jedzenie";
        }

        public override double Price()
        {
            Logger _logger = Logger.GetInstance();
            if (_trip is Berlin)
            {
                double cena = _trip.Price() + 100;
                _logger.LogMessage("Wycieczka do : " + _trip.Description() + " kosztuje z jedzeniem:"+ cena);
                return cena;
            }
            else if (_trip is Warsaw)
            {
                double cena = _trip.Price() + 50;
                _logger.LogMessage("Wycieczka do : " + _trip.Description() + " kosztuje z jedzeniem:" + cena);
                return cena;
            }
            return 0;
        }

        
    }
}
