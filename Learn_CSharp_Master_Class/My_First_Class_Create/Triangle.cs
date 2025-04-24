namespace My_First_Class_Create;

public class Triangle
{
    private int @base;
    private int height;
    public Triangle( int @base, int height)
    {
        this.@base = @base;
        this.height = height;
    }

    public double CalculateArea()
    {
        return ((@base * height) / 2);
    }

    public string AsString()
    {
        return $"Base is {@base}, height is {height}";
    }
}