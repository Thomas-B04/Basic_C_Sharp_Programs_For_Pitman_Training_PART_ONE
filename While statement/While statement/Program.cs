using System;

namespace While_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                Console.WriteLine($"Inside the loop number: {count}");
                count++;
            } 
            while (count < 5);

            int counting = 0;
            while (counting < 5)
            {
                Console.WriteLine($"Counting number: {counting}");
                counting++;
            }
        }
    }
}