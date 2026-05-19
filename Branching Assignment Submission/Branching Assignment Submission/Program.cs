namespace Package_express
{
    class Program
    {
        static void Main()
        {
            // Display greeting and initial instructions.
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");

            // Ask for package weight.
            Console.WriteLine("Please enter the package weight: ");
            decimal weight = Convert.ToDecimal(Console.ReadLine());

            // Reject package if it exceeds the weight limit.
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return;
            }

            // Ask for package dimensions.
            Console.WriteLine("Please enter the package width: ");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package height: ");
            decimal height = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the package length: ");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Calculate the total of all dimensions.
            decimal dimension_total = width + height + length;

            // Reject package if combined dimensions exceed the limit.
            if (dimension_total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                return;
            }

            // Calculate shipping quote based on dimensions and weight.
            decimal quote = (width * height * length * weight) / 100;
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote.ToString("F2")}");

            // Print closing message.
            Console.WriteLine("Thank you for using Package Express. Have a good day!");
        }
    }
}