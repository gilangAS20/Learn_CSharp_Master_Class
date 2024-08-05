using System.Text;

namespace Simple_Calculator;

public class Menu
{
    private readonly string _greetings = "Hello!";
    private readonly string _inputFirstNumber = "Input the first number:";
    private readonly string _inputSecondNumber = "input the second number: ";
    private readonly string _chooseOperator;
    
    public Menu()
    {
        StringBuilder menu = new StringBuilder();
        menu.AppendLine("What do you want to do with those numbers?");
        menu.AppendLine("[A]dd");
        menu.AppendLine("[S]ubtract");
        menu.AppendLine("[M]ultiply");
        menu.AppendLine("[D]ivide");
        _chooseOperator = menu.ToString();
    }

    public void Show()
    {
        Console.WriteLine(_chooseOperator);
    }
}