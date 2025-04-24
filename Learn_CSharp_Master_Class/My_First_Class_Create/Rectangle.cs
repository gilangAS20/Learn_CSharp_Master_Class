namespace My_First_Class_Create;

public class Rectangle
{
    private double _width;
    private double _height;

    public Rectangle( double width, double height)
    {
        _width = width;
        _height = height;
    }

    public void ChangeSpec(double width = 0, double height = 0)
    {
        if ( width != 0 )
        {
            _width = width;
        }

        if ( height != 0 )
        {
            _height = height;
        }
    }
    
    public double GetWidth()
    {
        return _width;
    }

    public double GetHeight()
    {
        return _height;
    }
}