using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1:");

            Console.WriteLine("Hourly Rate?");
            double person1HourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            double person1HoursPerWeek = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Person 2:");

            Console.WriteLine("Hourly Rate?");
            double person2HourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hours worked per week?");
            double person2HoursPerWeek = Convert.ToDouble(Console.ReadLine());

            double person1AnnualSalary = person1HourlyRate * person1HoursPerWeek * 52;

            double person2AnnualSalary = person2HourlyRate * person2HoursPerWeek * 52;

            Console.WriteLine("Annual salary of person 1:");
            Console.WriteLine(person1AnnualSalary);

            Console.WriteLine("Annual salary of person 2:");
            Console.WriteLine(person2AnnualSalary);

            bool doesPerson1MakeMore = person1AnnualSalary > person2AnnualSalary;

            Console.WriteLine($"Person one makes more than person two = {doesPerson1MakeMore}");
        }
    }
}