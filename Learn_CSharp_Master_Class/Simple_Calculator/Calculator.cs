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

    private bool _isExit;
    
    public Calculator()
    {
        StringBuilder menu = new StringBuilder();
        menu.AppendLine("What do you want to do with those numbers?");
        menu.AppendLine("[A]dd");
        menu.AppendLine("[S]ubtract");
        menu.AppendLine("[M]ultiply");
        menu.AppendLine("[D]ivide");
        menu.AppendLine("[E]xit");
        _chooseOperator = menu.ToString();

        _operator = new Operator();
    }

    public void Run()
    {
        EOperator inputToEnum = EOperator.None;
        do
        {
            Console.Clear();
            
            Console.WriteLine(_greetings);
        
            // input first number
            Console.WriteLine("Input first number:");
            double firstInput = double.Parse(Console.ReadLine());

            // input second number
            Console.WriteLine("Input second number:");
            double secondInput = double.Parse(Console.ReadLine());
        
            // choose operator want to use
            Console.WriteLine(_chooseOperator);
            char inputOperator = Char.Parse(Console.ReadLine());

            // return operator to enum
            inputToEnum = Operator(inputOperator);

            if (inputToEnum == EOperator.Exit)
            {
                DoExit(true);
            }
            else
            {
                var result = PrintResult(firstInput, secondInput, inputToEnum);
                if (result != "Exit")
                {
                    Console.WriteLine(result);
                    DoExit();
                }
                else
                {
                    DoExit(true);
                }
            }
            

        } while (_isExit == false);
        
// ToDo: add error checking when user input non number when input first and second number
// ToDo: add unit test to test operator function, wrong input, etc.
    }

    public void DoExit(bool isForceExit = false)
    {
        if (isForceExit)
        {
            Console.WriteLine("Program closed, thank you!");
            _isExit = true;
            System.Environment.Exit(1);
        }
        
        Console.WriteLine("Do you want to exit ? (Y/N)");
        char isExit = char.Parse(Console.ReadLine());

        if (isExit == 'Y' || isExit == 'y')
        {
            Console.WriteLine("Program closed, thank you!");
            _isExit = true;
            System.Environment.Exit(1);
        }
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
            case EOperator.Exit:
                return "Exit";
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
            case EOperator.Exit:
                return null;
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
            
            case 'E':
            case 'e':
                return EOperator.Exit;
            default:
                return EOperator.None;
        }
    }
}