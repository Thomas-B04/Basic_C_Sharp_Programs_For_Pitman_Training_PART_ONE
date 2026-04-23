namespace Math_Challenge
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Math Challenge!");

            int add_num1 = 2;
            int add_num2 = 3;

            int result = add_num1 + add_num2;
            Console.WriteLine($"The result of {add_num1} plus {add_num2} is {result}");

            int sub_num1 = 5;
            int sub_num2 = 6;
            
            int sub_result = sub_num1 - sub_num2;
            Console.WriteLine($"The result of {sub_num1} minus {sub_num2} is {sub_result}");

            int mul_num1 = 4;
            int mul_num2 = 3;

            int mul_result = mul_num1 * mul_num2;
            Console.WriteLine($"The result of {mul_num1} multiplied by {mul_num2} is {mul_result}");

            int div_num1 = 10;
            int div_num2 = 2;

            int div_result = div_num1 / div_num2;
            Console.WriteLine($"The result of {div_num1} divided by {div_num2} is {div_result}");
        }
    }
}