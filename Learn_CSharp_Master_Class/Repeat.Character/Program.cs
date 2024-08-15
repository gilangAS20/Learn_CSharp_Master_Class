using System;
using System.Text;

namespace Coding.Exercise
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine(Exercise.RepeatCharacter('a', 4));
            Console.WriteLine(Exercise.RepeatCharacter('!', 0));
            Console.WriteLine(Exercise.RepeatCharacter('b', 1));
            Console.WriteLine(Exercise.RepeatCharacter('c', -1));
        }
    }
    
    public class Exercise
    {
        public static string RepeatCharacter(char character, int targetLength)
        {
            StringBuilder result = new StringBuilder();
            int counter = 0;
            do
            {
                if (targetLength <= 0)
                {
                    return character.ToString();
                }

                result.Append(character.ToString());

                counter++;
            } while (counter < targetLength);

            return result.ToString();
        }
    }
}