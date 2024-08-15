// See https://aka.ms/new-console-template for more information

using System.Text;

namespace Print.Array
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(Exercise.BuildHelloString());
            ;
        }
    }
    
    public class Exercise
    {
        public static string BuildHelloString()
        {
            char[] letters = new char[] { 'h', 'e', 'l', 'l', 'o' };
                var result = "";
            StringBuilder builder = new StringBuilder();
            for(int i = 0; i < letters.Length; ++i)
            {
                builder.Append(letters[i].ToString());
            }

            result = builder.ToString();
            return result;
        }
    }
}

