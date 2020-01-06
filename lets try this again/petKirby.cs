using System;

namespace lets_try_this_again
{
    class Program
    {
        static void Main(string[] args)
        {  
            Pet Kirby = new Pet("Kirby", 69);
            Petowner Kyle = new Petowner("Kyle", 17);
            Console.WriteLine("Hello, my name is " + Kyle.Name + " what is your name?");
            Console.WriteLine(" ");
            Console.WriteLine("My name is " + Kirby.Name + " I am an " + Kirby.Species + " from the Galapagos Islands.");
            Console.WriteLine(" ");
            Console.WriteLine("If you would like to pet " + Kirby.Name + " press Spacebar.");
            Console.ReadKey();

            Console.WriteLine(" ");
            Console.WriteLine("*Kirby sucks " + Kyle.Name + " in like a vacuum*");



        }
    }
}
