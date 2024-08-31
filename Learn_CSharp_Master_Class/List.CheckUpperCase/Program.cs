// See https://aka.ms/new-console-template for more information

namespace List.CheckUppercase
{
    class Program
    {
        static void Main()
        {
            // create list --> {"one", "TWO", "THREE", "four"}
            List<string> listOne = new List<string>();
            listOne.Add("one");
            listOne.Add("TWO");
            listOne.Add("THREE");
            listOne.Add("four");
            // create list --> {"one", "TWO", "THREE", "four", "TWO"}
            List<string> listTwo = new List<string>();
            listTwo.Add("one");
            listTwo.Add("TWO");
            listTwo.Add("THREE");
            listTwo.Add("four");
            listTwo.Add("TWO");
            // create list --> {"one", "TWO123", "THREE!&^", "four"}
            List<string> listthree = new List<string>();
            //listthree.Add("one");
            listthree.Add("TWO123");
            listthree.Add("THREE!&^");
            //listthree.Add("four");
            
            // run check uppercase method
            var testOne = CheckIsUpperCase(listOne);
            var testTwo = CheckIsUpperCase(listTwo);
            var testThree = CheckIsUpperCase(listthree);
        }

        public static List<string> CheckIsUpperCase(List<string> list)
        {
            List<string> result = new List<string>();
            // loop item in list
            foreach (var item in list)
            {
                List<bool> isUpperCase = new List<bool>();
                // loop character in item
                foreach (var character in item)
                {
                    Console.WriteLine(character);
                    if (char.IsUpper(character) && char.IsLetter(character))
                    {
                        isUpperCase.Add(true);
                    }
                    else
                    {
                        isUpperCase.Add(false);
                    }
                }

                if (!isUpperCase.Contains(false) && !result.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}