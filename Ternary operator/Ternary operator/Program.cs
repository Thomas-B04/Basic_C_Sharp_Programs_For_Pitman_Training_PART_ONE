namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int inputNumber = int.Parse(Console.ReadLine() ?? "0");
            string result = inputNumber > 5 ? "Your number is greater than 5" : "Your number is less than or equal to 5";
            Console.WriteLine(result);
        }
    }
}