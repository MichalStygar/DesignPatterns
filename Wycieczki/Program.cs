using System;
using Wycieczki.Abstracts;
using Wycieczki.Interfaces;
using Wycieczki.Models;

namespace Wycieczki
{
    class Program
    {
    
        static void Main(string[] args)
        {
            Autobus autobus = new Autobus();
            Console.WriteLine(autobus.Description());
            Wycieczka s1 = new Berlin();
            Wycieczka s2 = new Warszawa();

            Console.WriteLine("\nPodstawowa wycieczka");
            Console.WriteLine(s1.about() + " " + s1.cena());
            Console.WriteLine(s2.about() + " " + s2.cena());

            

            s1 = new Jedzenie(s1);
            s2 = new Jedzenie(s2);
            Console.WriteLine("\n Wycieczka z jedzeniem");
            Console.WriteLine(s1.about() + " " + s1.cena());
            Console.WriteLine(s2.about() + " " + s2.cena());

            

            s1 = new Nocleg(s1);
            s2 = new Nocleg(s2);
            Console.WriteLine("\nWycieczka z jedzeniem i noclegiem");
            Console.WriteLine(s1.about() + " " + s1.cena());
            Console.WriteLine(s2.about() + " " + s2.cena());

            
           // Console.WriteLine("\nWycieczka z jedzeniem i noclegiem");
           // Wycieczka s3 = new Nocleg(new Jedzenie(new Berlin()));
           // Console.WriteLine(s3.about() + " " + s3.cena());
            Console.ReadLine();
        }
    }
}
