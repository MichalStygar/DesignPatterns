using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Wycieczki.Interfaces;
using Wycieczki.Utilities;

namespace Wycieczki.Models
{
    public class Customer : Interfaces.IObserver<ITrip>
    {

        private readonly Logger _logger;
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }

        public Customer() { _logger = Logger.GetInstance(); }

       
        public void Update(ITrip observer)
        {
            _logger.LogMessage("Wysłano wiadomość Email do: " + Name + " " + SurName + " na adres:" + Email);
            Console.WriteLine("Wycieczka do: " + observer.Description() + ". Zmieniła się cena wycieczki, którą obserwujesz. Nowa cena: " + observer.Price() + " zł");
        }
    }
}
