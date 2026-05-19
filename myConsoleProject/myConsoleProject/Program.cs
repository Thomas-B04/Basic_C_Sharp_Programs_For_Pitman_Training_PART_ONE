using System;

namespace myConsoleProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What's your name?");
            string User_Name = Console.ReadLine() ?? "Guest";
            Console.WriteLine($"Hello, {User_Name}! Welcome to C# programming.");
            //Console.Read();
        }
    }
}