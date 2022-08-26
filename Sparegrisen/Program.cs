using System;


namespace Sparegrisen
{
    class Program
    {
        // GUI
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White; // Sets console background color to white
            Console.ForegroundColor = ConsoleColor.Black; // Sets console foreground color to black
            Console.Clear(); // Clears console to make the background color to work better

            Console.Write("Hvor mange penge vil du indbetale: "); // Guiding text
            double money = MoneyInput(); // Runs MoneyInput method and saves return value as double

            Console.Write("Hvor meget er renten i %: "); // Guiding text
            double interest = InterestRateInput(); // Runs InterestRateInput method and saves return value as double

            Console.Write("Hvor mange år ønsker du at lade pengene stå: "); // Guiding text
            double years = YearsInput(); // Runs YearsInput method and saves return value as double

            int year = 2022; // For-loop that repeats the amount of years the user has given,
                             // and gives +1 each time it repeats to int year, so the user knows what year the output is from
                             // the writelines outputs the end capital of the users start capital
            for (int i = 1; i <= years; i++)
            {
                year++;
                Console.Write("Year "+year+": ");
                Console.WriteLine(money * Math.Pow(interest,i));
            }
            Console.ReadLine();            
        }
        // Model
        // Gets user input and converts to double
        static double YearsInput()
        {
            string yearsInput = Console.ReadLine();
            double years = Convert.ToDouble(yearsInput);

            return years; // Returns double years
        }
        // Model & Calculation
        // Gets user input and converts to double
        static double InterestRateInput()
        {
            string interest = Console.ReadLine();     
            double interestUndone = Convert.ToDouble(interest);
            double interestRate = (interestUndone / 100);    // take user input and divide by 100, so the number will be a decimal
            double fullInterest = interestRate + 1;     // plusses with 1, etc. if interestRate is 0,05, then fullInterest is 1,05

            return fullInterest;     // Returns double fullInterest 
        }
        // Model
        // Gets user input and converts to double
        static double MoneyInput()
        {
            string moneyInput = Console.ReadLine();
            double money = Convert.ToDouble(moneyInput);

            return money;   // Returns double money
        }
    }
}
