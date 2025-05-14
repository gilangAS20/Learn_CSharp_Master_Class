// See https://aka.ms/new-console-template for more information

var names = new Names();
var path = names.BuildFilePath();

if(File.Exists(path))
{
    Console.WriteLine("Names file already exists. Loading names.");
    names.ReadFromTextFile();
}
else
{
    Console.WriteLine("Names file does not yet exist.");

    //let's imagine they are given by the user
    names.AddName("John");
    names.AddName("not a valid name");
    names.AddName("Claire");
    names.AddName("123 definitely not a valid name");

    Console.WriteLine("Saving names to the file.");
    names.WriteToTextFile();
}
Console.WriteLine(names.Format());

Console.ReadLine();

public class Names
{
    private readonly List<string> _names = new(); // ToDo: change to HashSet

    public void AddName(string name)
    {
        if (IsValidName(name))
        {
            _names.Add(name);
        }
    }

    public bool IsValidName(string name)
    {
        return name.Length > 2 &&
               char.IsUpper(name[0]) &&
               name.All(char.IsLetter);
    }

    public void ReadFromTextFile()
    {
        var fileContents = File.ReadAllText(BuildFilePath());
        var namesFromFile = fileContents.Split(Environment.NewLine).ToList(); // ToDo; change to HashSet
        foreach (var name in namesFromFile)
        {
            AddName(name);
        }
    }

    public string BuildFilePath()
    {
        //we could imagine this is much more complicated
        //for example that path is provided by the user and validated
        return "names.txt"; // ToDo: add parameter so it can custom file name
    }

    public string Format() => string.Join(Environment.NewLine, _names);
    public void WriteToTextFile() => File.WriteAllText(BuildFilePath(), Format());
}