using System;

namespace Friday13th
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop runs 12 times, because there is 12 months in a year
            for (int i = 1; i <= 12; i++)
            {      
                // writes to console if, the friday is the 13th 
                DateTime date = new DateTime(DateTime.Today.Year + 1, i, 13);

                Console.WriteLine( date);
                // if condition is met, it writes to console if, the friday is the 13th 
                if (date.DayOfWeek == DayOfWeek.Friday)
                {
                    Console.WriteLine(date.ToString("dd\\t\\h MMMM yyyy") + " er en fredag");
                }
            }
           
        }
    }
}
