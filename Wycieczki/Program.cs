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
            
            Customer k1 = new Customer() { Name = "Iza", SurName = "Kowalska",Email = "iza@iza.pl" };
            Customer k2 = new Customer() { Name = "Marta", SurName = "Janik", Email = "marta@marta.pl" };
            Customer k3 = new Customer() { Name = "Tomasz", SurName = "Kot", Email = "tomasz@tomasz.pl" };



            ITrip w1 = new Berlin();
            ITrip w2 = new Warsaw();
            Console.WriteLine("\nPodstawowa wycieczka");
            Console.WriteLine(w1.Description() + " " + w1.Price());
            Console.WriteLine(w2.Description() + " " + w2.Price());



            Decorator j1 = new Food(w1);
            Decorator j2 = new Food(w2);
            Console.WriteLine("\n Wycieczka z jedzeniem");
            Console.WriteLine(j1.Description() + " " + j1.Price());
            Console.WriteLine(j2.Description() + " " + j2.Price());



            Decorator s1 = new Accommodation(w1);
            Decorator s2 = new Accommodation(w2);
            Console.WriteLine("\nWycieczka z jedzeniem i noclegiem");
            Console.WriteLine(s1.Description() + " " + s1.Price());
            Console.WriteLine(s2.Description() + " " + s2.Price());


            w1.Subscribe(k1);
            w1.Subscribe(k2);
            w2.Subscribe(k3);

            w1.ChangePrice(800);
            w2.ChangePrice(600);

            w1.Unsubscribe(k1);

            w1.ChangePrice(200);

            IInsuranceStrategy normalInsurance = new NormalInsurance();
            IInsuranceStrategy strongInsurance = new StrongInsurance();
            CustomerInsurance u1 = new CustomerInsurance(normalInsurance, k1);
            CustomerInsurance u2 = new CustomerInsurance(strongInsurance, k2);
            u1.Add(2);
            u1.Add(3);
            u1.Print();

            u2.Add(7);
            u2.Print();



            Console.ReadLine();
        }
    }
}
