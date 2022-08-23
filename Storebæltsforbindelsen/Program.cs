using System;

namespace Storebæltsforbindelsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hvor mange motorcykler er der på broen: ");
            int motorcycleTire = CalculationMotorcycle();
            Console.WriteLine("Hvor mange biler er der på broen: ");
            int carTire = CalculationCar();
            Console.WriteLine("Hvor mange lastbiler / busser er der på broen: ");
            int busTire = CalculationBus();
            int tires = motorcycleTire + carTire + busTire;
            Console.WriteLine("Der er i alt: "+tires+" dæk på broen");
            Console.ReadLine();
            
        }
        static int CalculationMotorcycle()
        {
            int motorcycle = FirstUserInput();
            int motorcycleTire = motorcycle * 2;

            return motorcycleTire;
        }
        static int CalculationCar()
        {
            int cars = SecondUserInput();
            int carsTire = cars * 4;
            return carsTire;
        }
        static int CalculationBus()
        {
            int bus = ThirdUserInput();
            int busTire = bus * 6;
            return busTire;
        }
        static int FirstUserInput()
        {
            string input = Console.ReadLine();
            int answer = Int32.Parse(input);
            return answer;
        }
        static int SecondUserInput()
        {
            string input = Console.ReadLine();
            int answer = Int32.Parse(input);
            return answer;
        }
        static int ThirdUserInput()
        {
            string input = Console.ReadLine();
            int answer = Int32.Parse(input);
            return answer;
        }
    }
}
