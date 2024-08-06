namespace Simple_Calculator.Interface;

public interface IOperator
{
    double Add(double firstNum, double secondNum);

    double Substract(double firstNum, double secondNum);

    double Multiply(double firstNum, double secondNum);

    double Divide(double firstNum, double secondNum);
}