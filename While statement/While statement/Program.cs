using System;

namespace While_statement
{
    /// <summary>
    /// Demonstrates the behavior of <c>do...while</c> and <c>while</c> loops.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Application entry point.
        /// First runs a <c>do...while</c> loop that executes at least once, then
        /// runs a <c>while</c> loop that checks its condition before each iteration.
        /// </summary>
        /// <param name="args">Command-line arguments (not used).</param>
        static void Main(string[] args)
        {
            // Counter used by the do...while loop.
            int count = 0;

            // Executes the body, then checks the condition.
            do
            {
                Console.WriteLine($"Inside the loop number: {count}");
                count++;
            }
            while (count < 5);

            // Counter used by the while loop.
            int counting = 0;

            // Checks the condition before each iteration.
            while (counting < 5)
            {
                Console.WriteLine($"Counting number: {counting}");
                counting++;
            }
        }
    }
}