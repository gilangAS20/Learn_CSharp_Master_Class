// See https://aka.ms/new-console-template for more information

namespace Sum.Of.Number
{
    class Program
    {
        static void Main()
        {
            // first number = 5 and lastNumber = 10 ---> should be 45 (5+6+7+8+9+10)
            Console.WriteLine(Exercise.CalculateSumOfNumbersBetween(5, 10));
            
            // first number = - 5 and lastNumber = 5 --> should be 0 (-5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5)
            Console.WriteLine(Exercise.CalculateSumOfNumbersBetween(-5, 5));
            
            // first number same as lastNumber ---> if 10 will retun 10
            Console.WriteLine(Exercise.CalculateSumOfNumbersBetween(10,10));
            
            // first number = 5 and lastNumber = 4 ---> 0 because first number smaller than lastNumber
            Console.WriteLine(Exercise.CalculateSumOfNumbersBetween(5,4));
        }
    }
    
    public class Exercise
    {
        public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
        {
            int result = 0;
            //your code goes here
            if(lastNumber < firstNumber)
            {
                return 0;
            }
            else if(firstNumber == lastNumber)
            {
                return firstNumber;
            }

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                result += i;
            }

            return result;
        }
    }
}

