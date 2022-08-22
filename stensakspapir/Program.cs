using System;
using System.Threading;

namespace stensakspapir
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string[] options = new string[] { "Sten", "Saks", "Papir" }; // string array of valid options
                Console.WriteLine("Sten");
                Thread.Sleep(1000); // Makes an writeline and waits 1 second
                Console.WriteLine("Saks");
                Thread.Sleep(1000); // Writeline and waits 1 second
                Console.WriteLine("Papir");
                Thread.Sleep(500); // Writeline and waits 0,5 second
                Console.WriteLine("Nu: Skriv Sten, Saks eller Papir"); // Guiding text
                string choice = Console.ReadLine(); // User input saved as string

                // Bot player
                Random rnd = new Random(); // chooses random number between 0-2
                int game = rnd.Next(0, 3); // The random number is used for the array
                Console.WriteLine("Du har valgt: "+choice);
                Console.WriteLine("Modstanderen har valgt: "+options[game]);
                Thread.Sleep(7500);
            }
        }
    }
}
