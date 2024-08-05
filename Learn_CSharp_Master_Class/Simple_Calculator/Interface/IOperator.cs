namespace Simple_Calculator.Interface;

public interface IOperator
{
    double Add(int firstNum, int secondNum);

    double Substract(int firstNum, int secondNum);

    double Multiply(int firstNum, int secondNum);

    double Divide(int firstNum, int secondNum);
}