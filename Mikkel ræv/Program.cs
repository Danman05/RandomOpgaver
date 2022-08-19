using System;

namespace Mikkel_ræv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling the UserInput method to get the value up to the Main method
            string[] text = UserInput();
            // Declaring 2 int variables for calculation in the for loop
            int word = 0, max = 0;
            // loop checks each word in the array, and saves the longest word and the amount of characters in the word
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length > max)
                {
                    max = text[i].Length;
                    word = i;
                }
            }
            // Displays the longest word and total letters
            Console.WriteLine("Longest word: {0} \nAmount of characters in the word: {1}", text[word], max);
            Console.ReadLine();
        }

        // Model layer

        // UserInput method gets user input as a string and lays each word in an array
        // Method return array of word in the text
        static string[] UserInput()
        {
            string input = Console.ReadLine();
            string[] textarr = input.Split(" ");
            return textarr;
        }
    }
}
