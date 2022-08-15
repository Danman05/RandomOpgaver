using System;

namespace sokkeskuffen
{
    class Program
    {
        static void Main(string[] args)
        {
            // gets the data from another method
            double[] countryData =  CalculatePassengers();
            // uses the data from the array in the other method, to give output into the console
            Console.WriteLine("Danmark har 5.581.503 inbyggere, om 3 årtier har Danmark: " + countryData[0]+" inbyggere");
            Console.WriteLine("Australien har 22.751.014 inbyggere, om 3 årtier har Australien: " + countryData[1] + " inbyggere");
            Console.WriteLine("LetLand har 1.986.705 inbyggere, om 3 årtier har LetLand: " + countryData[2] + " inbyggere");
            Console.WriteLine("Monaco har 37.731 inbyggere, om 3 årtier har Monaco: " + countryData[3] + " inbyggere");
            Console.WriteLine("Syd Sudan har 12.042.910 inbyggere, om 3 årtier har Syd Sudan: " + countryData[4] + " inbyggere");
            Console.WriteLine("Angola har 19.625.353 inbyggere, om 3 årtier har Angola: " + countryData[5] + " inbyggere");
            Console.ReadLine();


        }
        // Method for calculating each countries population in 30 years
        static double[] CalculatePassengers()
        {
            double denmark =(int)Math.Round( 5581503 * 0.0022 * 30 + 5581503); // output 5949882
            double australia = (int)Math.Round(22751014 * 0.0107 * 30 + 22751014); // output 30054089
            double latvia = (int)Math.Round(1986705 * -0.0106 * 30 + 1986705); // output 1354933
            double monaco = (int)Math.Round(37731 * 0.0012 * 30 + 37731); // output 39089
            double southsydan = (int)Math.Round(12042910 * 0.0402 * 30 + 12042910); // output 26566659
            double angola = (int)Math.Round(19625353 * 0.0278 * 30 + 19625353); // output 35992897
            double[] countries = new double[] { denmark, australia, latvia, monaco, southsydan, angola };
            // returns the array with the countries
            return countries;
        }
    }
}