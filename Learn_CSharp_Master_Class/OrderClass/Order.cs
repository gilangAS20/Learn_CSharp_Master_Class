namespace OrderClass;

public class Order
{
    public string Item { get;}

    public DateTime Date
    {
        get => _date;
        set
        {
            if ( value.Year == DateTime.Now.Year )
            {
                _date = value;
            }
        }
    }

    private DateTime _date;
    
    public Order( string item, DateTime date )
    {
        Item = item;
        Date = date;
    }
}