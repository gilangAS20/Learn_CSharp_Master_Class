namespace DogClassQuiz;

public class Dog
{
    private readonly string _name;
    private readonly string _breed;
    private readonly int _weight;
    
    public Dog( string name, string breed, int weight )
    {
        _name = name;
        _breed = breed;
        _weight = weight;
    }

    public Dog( string name, int weight)
    {
        _name = name;
        _breed = "mixed-breed";
        _weight = weight;
    }

    public string Describe()
    {
        return $"This dog is named {_name}, " +
                         $"it's a {_breed}, " +
                         $"and it weighs {_weight} kilograms, " +
                         $"so it's a {Size(_weight)} dog.";
    }

    private string Size( int weight)
    {
        switch (weight)
        {
            case < 5:
                return "tiny";
            case < 30:
                return "medium";
            default:
                return "large";
        }
    }
}