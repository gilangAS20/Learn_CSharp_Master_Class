// See https://aka.ms/new-console-template for more information

using Learn_Classes;

class Program
{
    static void Main()
    {
        MedicalAppointment appointment1 = new MedicalAppointment("Gilang", new DateTime(2025, 1, 29));
        appointment1.Reschedule(DateTime.Now);
        
        
        // rectangle with default value more than negative number
        Rectangle rectangleNegative = new Rectangle(-10, -21);
        Rectangle rectangleZero = new Rectangle(0, 0);

        Cube cubeOne = new Cube();
        Console.WriteLine(cubeOne.Width);

        Rectangle rectangle1 = new Rectangle(-10, -21);
        Console.WriteLine(Rectangle.FirstUsed());
        Console.WriteLine(Rectangle.FirstUsed());
        Console.WriteLine(Rectangle.FirstUsed());
        Console.WriteLine(Rectangle.FirstUsed());
        
    }
}