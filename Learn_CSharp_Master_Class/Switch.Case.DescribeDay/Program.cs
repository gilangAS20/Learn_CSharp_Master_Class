// See https://aka.ms/new-console-template for more information

namespace Switch.Case.DescribeDay
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 8; i++)
            {
                Console.WriteLine(Exercise.DescribeDay(i));
            }
        }
    }

    class Exercise
    {
        /// <summary>
        /// number 1-5 are Working Day, 6 and 7 are Weekend
        /// </summary>
        /// <param name="dayNumber"></param>
        /// <returns></returns>
        public static string DescribeDay(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    return "Working day";
                break;
                case 6:
                case 7:
                    return "Weekend";
                break;
                default:
                    return "Invalid day number";
            }
        }
    }
}

