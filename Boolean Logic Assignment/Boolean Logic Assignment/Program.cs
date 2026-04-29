using System;

namespace boolean_logic
{
    /// <summary>
    /// Runs a simple console-based eligibility check for car insurance.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Application entry point.
        /// Collects applicant details and evaluates qualification rules:
        /// age must be greater than 15, DUI history must be false, and
        /// speeding tickets must be 3 or fewer.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Car insurance application verification Portal");

            // Ask for applicant age and convert the input to an integer.
            Console.WriteLine("What age are you?");
            int age = Convert.ToInt32(Console.ReadLine());

            // Ask whether the applicant has a DUI and convert to a boolean.
            Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
            string duiInput = Console.ReadLine().ToLower();
            bool hasDUI = duiInput == "true";

            // Ask for the number of speeding tickets and convert to an integer.
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qualified?");

            // Applicant qualifies only if all conditions are true.
            bool isQualified = (age > 15) && (hasDUI == false) && (speedingTickets <= 3);

            // Display final eligibility result.
            if (isQualified == true)
            {
                Console.WriteLine("You are qualified for car insurance.");
            }
            else
            {
                Console.WriteLine("You are not qualified for car insurance.");
            }
        }
    }
}