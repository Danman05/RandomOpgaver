using System;

namespace DNA
{
    class Program
    {
        // GUI
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv to lige lange parametre"); // Guiding text
            int hammingDistance = Compare(); // starts the method Compare and saves the return value in an int
            Console.WriteLine("Hamming distance = "+hammingDistance); // Outputs the hammingDistance value
            Console.ReadLine(); // ReadLine to keep program running
        }
        // Calculation
        static int Compare()
        {
            int hammingDistance = 0; // Declaring variable for later use
            char[] firstCharacters = FirstInput().ToCharArray(); // Calls FirstInput method and saves value to char array
            char[] secondCharacters = SecondInput().ToCharArray(); // Calls SecondInput method and saves value to char array

            for (int i = 0; i < firstCharacters.Length; i++) // for-loop, loops the amount of chars in firstCharacters
            {
                if (firstCharacters[i] != secondCharacters[i]) // if statement to check if the char is not the same
                {
                    ++hammingDistance; // if condition is met, it will add 1 value
                }
            }
            return hammingDistance; // Returns int value
        }
        // Model
        static string FirstInput() // When called, program will await user input and return it
        {
            string input = Console.ReadLine();
            return input;
        }
        static string SecondInput() // When called, program will await user input and return it
        {
            string input = Console.ReadLine();
            return input;
        }
    }
}
