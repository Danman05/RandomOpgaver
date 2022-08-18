using System;

namespace sokkeskuffen
{
    class Program
    {
        // GUI
        static void Main(string[] args)
        {
            // Writelines to guide the user
            Console.WriteLine("Skriv dine sokker som bogstaver");
            Console.WriteLine("Du har {0} par sokker",Socks());
            Console.ReadLine();         
        }
        // Calculation 
        static int Socks()
        {   // Gets user input and converts to uppercase
            string userSocks = Console.ReadLine().ToUpper();
            // char array to get each char from the string above
            char[] charArr = userSocks.ToCharArray();
            // sorts the char array
            Array.Sort(charArr);
            // making variables to use select diffrent items in the char array with the for loop
            int sockPairs = 0;
            int sock1 = -2;
            int sock2 = -1;
            for (int i = 0; i < charArr.Length; i+=2)
            {
                if (charArr[sock1+=2].Equals(charArr[sock2+=2]))
                {
                    // adds the value 1, each time their is an pair
                    sockPairs += 1;
                }
            }
            // returns the number of sockPairs
            return sockPairs;
        }
    }
}
