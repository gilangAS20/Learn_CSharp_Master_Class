// See https://aka.ms/new-console-template for more information

namespace Factorial
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Exercise.Factorial(5));
            Console.WriteLine(Exercise.Factorial(4));
            Console.WriteLine(Exercise.Factorial(1));
            Console.WriteLine(Exercise.Factorial(0));
            
        }
    }
    
    public class Exercise
    {
        public static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            
            int result = number;
            for (int i = number-1; i > 1; i--)
            {
                result *= i;
            }

            return result;
        }
    }
}