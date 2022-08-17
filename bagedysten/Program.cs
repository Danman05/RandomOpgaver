using System;
using System.Threading;

namespace bagedysten
{
    class Program
    {
        // GUI Part
        static void Main(string[] args)
        {
            // string array of the available cakes that the user can choose between
            string[] cake = new string[] { "KartoffelKage", "Mocca Eclair", "Fragilité", "Harmonie", "Margrethekage", "Lyonsnitte", "Marzarin", "Sarah Bernhardt", "Carl Nielsen", "Prinsesse Thyra" };
            // Displays the different cake options, and shows the number the user has to press to select that specific cake
            Console.WriteLine("Hvilke 3 kager vil du træne");
            Console.WriteLine("[1] "+cake[1]+"\n" + "[2] " + cake[2] + "\n" + "[3] " + cake[3] + "\n" + "[4] "+ cake[4] + "\n" + "[5] " + cake[5] + "\n" + "[6] " + cake[6] + "\n" + "[7] " + cake[7] + "\n" + "[8] " + cake[8] + "\n" + "[9] " + cake[9] + "\n"+"[0] " + cake[0] + "\n");
            // gets 3 inputs from user, cake 1,2 and 3
            Console.Write("1. kage er: ");
            int cakeOne = UserInput1();
            Console.Write("2. kage er: ");
            int cakeTwo = UserInput2();
            Console.Write("3. kage er: ");
            int cakeThree = UserInput3();
            int cakenum = CakeCalc();
            // Verifies the chosen cakes, for loop makes program to sleep for around 2 seconds. for each 0,5 second an dot will appear
            Console.WriteLine("Du har valgt at træne disse kager: "+cake[cakeOne]+", "+cake[cakeTwo]+", "+cake[cakeThree]);
            Console.WriteLine("\nNu bliver der trukket en tilfældig kage");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(500);
                Console.Write(".");
            }
            // writeline for display of the chosen cake from the random cake number generator
            Console.WriteLine("\nDen trukkede kage er: " + cake[cakenum]);

            // if user cake choice is the same as the random cake generated number, user won
            if (cakeOne == cakenum)
            {
                Console.WriteLine("Du har trænet den trukket kage, du kommer helt klart til at bestå din svendeprøve");
            }
            if (cakeTwo == cakenum )
            {
                Console.WriteLine("Du har trænet den trukket kage, du kommer helt klart til at bestå din svendeprøve");
            }
            if (cakeThree == cakenum )
            {
                Console.WriteLine("Du har trænet den trukket kage, du kommer helt klart til at bestå din svendeprøve");
            }
            // if user cake choice is not the same as the random cake generated number, user lost
            else
            {
                Console.WriteLine("Din kage er ikke trukket, du kommer nok til at dumpe");
            }
            Console.ReadLine(); 
        }
        // Calculation part
        static int CakeCalc()
        {
            // Random number for the array 
            Random rnd = new Random();
            int rndCake = rnd.Next(0, 10);
            return rndCake;
        }
        // Gets users first cake choice and converts it from string to int
        static int UserInput1()
        {
            string userChoice1 = Console.ReadLine();
            int choice1 = Int32.Parse(userChoice1);
            return choice1;       
        }
        // Gets users first cake choice and converts it from string to int
        static int UserInput2()
        {
            string userChoice2 = Console.ReadLine();
            int choice2 = Int32.Parse(userChoice2);
            return choice2;
        }
        // Gets users first cake choice and converts it from string to int
        static int UserInput3()
        {
            string userChoice3 = Console.ReadLine();
            int choice3 = Int32.Parse(userChoice3);
            return choice3;
        }
    }
}
