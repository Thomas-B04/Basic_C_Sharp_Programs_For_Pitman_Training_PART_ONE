namespace Greater_than_lesser_than
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive number: ");
            int user_num = Convert.ToInt32(Console.ReadLine());

            int comparison_num = 10;

            if (user_num > comparison_num)
            {
                Console.WriteLine($"This number is greater than {comparison_num}.");
            }
            else
            {
                Console.WriteLine($"This number is lesser than {comparison_num}.");
            }



            int age_check = 21;

            Console.WriteLine("Enter your age: ");
            int user_age = Convert.ToInt32(Console.ReadLine());

            if (user_age <= age_check)
            {
                Console.WriteLine($"You are not old enough to vote. You need to be older than {age_check}.");
            }
            else
            {
                Console.WriteLine($"You are old enough to vote. You are older than {age_check}.");
            }
        }
    }
}