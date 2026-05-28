namespace Switch_Statements
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine()!);
            Console.WriteLine(number);
            switch (number)
            {
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                default:
                    Console.WriteLine($"Number is not 1 or 2, it is {number}");
                    break;
            }
        }
    }
}