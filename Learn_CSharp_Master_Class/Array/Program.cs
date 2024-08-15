// See https://aka.ms/new-console-template for more information

namespace Array
{
    class Program
    {
        static void Main()
        {
            
        }
    }
    
    public class Exercise
    {
        public static int FindMax(int[,] numbers)
        {
            if (numbers.GetLength(0) == 0 || numbers.GetLength(1) == 0)
            {
                return -1;
            }

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    result.Add(numbers[i,j]);
                }
            }

            return result.Max();
        }
    }
}

