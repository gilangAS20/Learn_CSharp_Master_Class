namespace Learn_Classes;

public class MedicalAppointment
{
    private string _patientname;
    private DateTime _date;
    
    public MedicalAppointment( string patientName, DateTime date)
    {
        _date = date;
        _patientname = patientName;
    }

    public DateTime GetDate() => _date;

    public void Reschedule(DateTime scheduleTime)
    {
        _date = scheduleTime;
        AppointmentPrinter printer = new AppointmentPrinter();
        printer.Print(this);
    }
}

public class AppointmentPrinter
{
    public void Print( MedicalAppointment appointment )
    {
        Console.WriteLine($"appointment date is changed to: " + appointment.GetDate());
    }
}