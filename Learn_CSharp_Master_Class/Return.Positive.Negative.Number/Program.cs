// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        FindNumber findNumber = new FindNumber();
        var numberArray = new[] { -10, 9, 8, -7 };
        
        var numberList = new List<int>();
        var result = findNumber.FindPositiveNegative(numberArray, out numberList);

        Console.WriteLine("positive: ");
        foreach (var number in result)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("negative: ");
        foreach (var negativeNumber in numberList)
        {
            Console.WriteLine(negativeNumber);
        }
    }
}

class FindNumber
{
    public List<int> FindPositiveNegative(IEnumerable<int> numbers, out List<int> negative)
    {
        negative = new List<int>();
        List<int> positiveResult = new List<int>();
        // find negative number
        foreach (var number in numbers)
        {
            if (number < 0)
            {
                negative.Add(number);
            }
            else if (number > 0)
            {
             positiveResult.Add(number);   
            }
        }

        return positiveResult;
    }

    public void Print(string word)
    {
        Console.WriteLine(word);
    }
}