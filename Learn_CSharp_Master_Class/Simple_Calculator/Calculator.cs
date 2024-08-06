using System.Text;
using Simple_Calculator.Enum;

namespace Simple_Calculator;

public class Calculator
{
    private readonly string _greetings = "Hello!";
    private readonly string _inputFirstNumber = "Input the first number:";
    private readonly string _inputSecondNumber = "input the second number: ";
    private readonly string _chooseOperator;
    private Operator _operator;
    
    public Calculator()
    {
        StringBuilder menu = new StringBuilder();
        menu.AppendLine("What do you want to do with those numbers?");
        menu.AppendLine("[A]dd");
        menu.AppendLine("[S]ubtract");
        menu.AppendLine("[M]ultiply");
        menu.AppendLine("[D]ivide");
        _chooseOperator = menu.ToString();

        _operator = new Operator();
    }

    public void Run()
    {
        Console.WriteLine(_greetings);
        
        Console.WriteLine("Input first number:");
        double firstInput = double.Parse(Console.ReadLine());

        Console.WriteLine("Input second number:");
        double secondInput = double.Parse(Console.ReadLine());
        
        Console.WriteLine(_chooseOperator);
        char inputOperator = Char.Parse(Console.ReadLine());

        EOperator inputToEnum = Operator(inputOperator);
        
        Console.WriteLine(PrintResult(firstInput, secondInput, inputToEnum));

        Console.ReadKey();

// ToDo: add looping to make user able to user calculator again after show the last result
// ToDo: add error checking when user input non number when input first and second number
// ToDo: add error checking when user input operator except in the menu
// ToDo: add method to quit the calculator if user choose [E]xit
// ToDo: add unit test to test operator function, wrong input, etc.
    }

    public string PrintResult(double firstNum, double secondNum, EOperator choosenOperator)
    {
        double? operatorResult = GetResult( firstNum, secondNum, choosenOperator );
        
        switch (choosenOperator)
        {
            case EOperator.Add:
                return $"Hasil dari {firstNum} + {secondNum} adalah: {operatorResult}";
            case EOperator.Substract:
                return $"Hasil dari {firstNum} - {secondNum} adalah: {operatorResult}";
            case EOperator.Multiply:
                return $"Hasil dari {firstNum} * {secondNum} adalah: {operatorResult}";
            case EOperator.Divide:
                return $"Hasil dari {firstNum} : {secondNum} adalah: {operatorResult}";
            default:
                return "result invalid";
        }
    }
    public double? GetResult(double firstNum, double secondNum, EOperator choosenOperator)
    {
        switch (choosenOperator)
        {
            case EOperator.Add:
                return _operator.Add(firstNum, secondNum);
            case EOperator.Divide:
                return _operator.Divide(firstNum, secondNum);
            case EOperator.Multiply:
                return _operator.Multiply(firstNum, secondNum);
            case EOperator.Substract:
                return _operator.Substract(firstNum, secondNum);
        }
        
        return null;
    }

    private EOperator Operator(char operatorInput)
    {
        switch (operatorInput)
        {
            case 'A':
            case 'a':
                return EOperator.Add;

            case 'S':
            case 's':
                return EOperator.Substract;
            
            case 'M':
            case 'm':
                return EOperator.Multiply;
            
            case 'D':
            case 'd':
                return EOperator.Divide;
            
            default:
                return EOperator.None;
        }
    }
}