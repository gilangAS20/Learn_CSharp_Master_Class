using Simple_Calculator.Interface;

namespace Simple_Calculator;

public class Operator : IOperator
{
    #region Operator
    public double Add(double firstNum, double secondNum)
    {
        return firstNum + secondNum;
    }

    public double Substract(double firstNum, double secondNum)
    {
        return firstNum - secondNum;
    }

    public double Multiply(double firstNum, double secondNum)
    {
        return firstNum * secondNum;
    }

    public double Divide(double firstNum, double secondNum)
    {
        return firstNum / secondNum;
    }
    #endregion
}
