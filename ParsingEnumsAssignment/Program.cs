using System;

namespace DaysOfWeekEnumApp
{
    // Define an enum for the days of the week
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            // Read the user input
            string userInput = Console.ReadLine();

            try
            {
                // Try to parse the user input to the DaysOfWeek enum
                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true);

                // Display the current day
                Console.WriteLine("You have entered: " + currentDay);
            }
            catch (Exception)
            {
                // Handle any errors that occur during parsing
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
