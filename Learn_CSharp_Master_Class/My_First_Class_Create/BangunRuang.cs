using System.Threading.Channels;

namespace My_First_Class_Create;

public class BangunRuang
{
    private readonly Rectangle _rectangle;
    
    public BangunRuang(Rectangle rectangle)
    {
        _rectangle = rectangle;
    }

    public void PrintData()
    {
        Console.WriteLine( "width: " + _rectangle.GetWidth() );
        Console.WriteLine( "height: " + _rectangle.GetHeight() );
    }
}