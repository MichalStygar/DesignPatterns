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
            
            Klient k1 = new Klient() { Imie = "Iza", Nazwisko = "Kowalska",Email = "iza@iza.pl" };
            Klient k2 = new Klient() { Imie = "Marta", Nazwisko = "Janik", Email = "marta@marta.pl" };
            Klient k3 = new Klient() { Imie = "Tomasz", Nazwisko = "Kot", Email = "tomasz@tomasz.pl" };


            
            Wycieczka w1 = new Berlin();
            Wycieczka w2 = new Warszawa();
            
            Console.WriteLine("\nPodstawowa wycieczka");
            Console.WriteLine(w1.about() + " " + w1.cena());
            Console.WriteLine(w2.about() + " " + w2.cena());



            Wycieczka j1 = new Jedzenie(w1);
            Wycieczka j2 = new Jedzenie(w2);
            Console.WriteLine("\n Wycieczka z jedzeniem");
            Console.WriteLine(j1.about() + " " + j1.cena());
            Console.WriteLine(j2.about() + " " + j2.cena());



            Wycieczka s1 = new Nocleg(w1);
            Wycieczka s2 = new Nocleg(w2);
            Console.WriteLine("\nWycieczka z jedzeniem i noclegiem");
            Console.WriteLine(s1.about() + " " + s1.cena());
            Console.WriteLine(s2.about() + " " + s2.cena());


            w1.Dodaj(k1);
            w1.Dodaj(k2);
            w2.Dodaj(k3);

            w1.zmienCene(800);
            w2.zmienCene(600);

            w1.Usun(k1);

            w1.zmienCene(200);
            

            Console.ReadLine();
        }
    }
}
