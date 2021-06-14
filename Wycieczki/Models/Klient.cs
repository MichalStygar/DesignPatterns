using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wycieczki.Abstracts;
using Wycieczki.Interfaces;
using Wycieczki.Utilities;

namespace Wycieczki.Models
{
    public class Klient :IObserwator<Wycieczka>
    {

        private readonly Logger _logger;
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }

        public Klient() { _logger = Logger.GetInstance(); }

       
        public void Aktualizuj(Wycieczka obserwator)
        {
            _logger.LogMessage("Wysłano wiadomość Email do: " + Imie + " " + Nazwisko + " na adres:" + Email);
            Console.WriteLine("Wycieczka do: " + obserwator.about() + ". Zmieniła się cena wycieczki, którą obserwujesz. Nowa cena: " + obserwator.cena() + " zł");
        }
    }
}
