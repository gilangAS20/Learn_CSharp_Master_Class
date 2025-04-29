namespace Learn_Classes;

public class Rectangle
{
    private readonly int _width;
    private readonly int _height;
    
    public Rectangle( int width, int height )
    {
        _width = CheckForNegativeAndDefault(width, nameof(_width));
        _height = CheckForNegativeAndDefault(height, nameof(_height));
    }

    private int CheckForNegativeAndDefault(int number, string paramName)
    {
        if ( number < 0 )
        {
            Console.WriteLine($"{paramName} must be 0 or greater, assign default to 0 (zero)");
            return 0;
        }

        return number;
    }
}