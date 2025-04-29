// See https://aka.ms/new-console-template for more information

using Learn_Classes;

class Program
{
    static void Main()
    {
        MedicalAppointment appointment1 = new MedicalAppointment("Gilang", new DateTime(2025, 1, 29));
        appointment1.Reschedule(DateTime.Now);
    }
}