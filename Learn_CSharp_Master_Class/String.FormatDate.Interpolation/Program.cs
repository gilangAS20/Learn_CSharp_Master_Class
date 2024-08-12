// See https://aka.ms/new-console-template for more information

namespace String.FormatDate.Interpolation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Exercise.FormatDate(2023, 12, 1));
        }
    }

    public class Exercise
    {
        public static string FormatDate(int year, int month, int day)
        {
            return string.Format("{0}/{1}/{2}", year, month, day);
        }
    }
}

