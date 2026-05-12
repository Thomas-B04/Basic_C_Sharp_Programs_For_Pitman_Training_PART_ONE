namespace Conditional_Statements_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number (or 'exit' to quit): ");
                string input = Console.ReadLine();

                if (input?.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                if (int.TryParse(input, out int number))        
                {
                    if (number > 0)
                    {
                        Console.WriteLine("The number is positive.");
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine("The number is negative.");
                    }
                    else
                    {
                        Console.WriteLine("The number is zero.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
    }
}