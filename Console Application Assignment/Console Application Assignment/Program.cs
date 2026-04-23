using System;

class Program
{
    /// <summary>
    /// Prompts the user for a numeric input, validates it, and displays
    /// the results of several arithmetic and comparison operations.
    /// </summary>
    /// <remarks>
    /// Operations performed:
    /// 1. Multiply by 50
    /// 2. Add 25
    /// 3. Divide by 12.5
    /// 4. Check whether the number is greater than 50
    /// 5. Calculate the remainder when divided by 7
    /// </remarks>
    static void Main()
    {
        // Request a number from the user.
        Console.WriteLine("Enter a number:");

        // Read the raw input from the console.
        string userInput = Console.ReadLine();

        // Validate that the input can be parsed as a double.
        // Exit early if parsing fails.
        if (!double.TryParse(userInput, out double number))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        // Multiply the input by 50 and display the result.
        double multipliedValue = number * 50;
        Console.WriteLine($"The result of multiplying {number} by 50 is {multipliedValue}.");

        // Add 25 to the input and display the result.
        double addedValue = number + 25;
        Console.WriteLine($"The result of adding 25 to {number} is {addedValue}.");

        // Divide the input by 12.5 and display the result.
        double dividedValue = number / 12.5;
        Console.WriteLine($"The result of dividing {number} by 12.5 is {dividedValue}.");

        // Evaluate whether the input is greater than 50.
        bool isGreaterThan50 = number > 50;
        Console.WriteLine($"Is {number} greater than 50? {isGreaterThan50}");

        // Compute the remainder after division by 7.
        // Also cast the remainder to an integer for display comparison.
        double remainder = number % 7;
        int roundedRemainder = (int)remainder;

        Console.WriteLine($"The remainder of {number} divided by 7 is {remainder} or {roundedRemainder}.");
    }
}