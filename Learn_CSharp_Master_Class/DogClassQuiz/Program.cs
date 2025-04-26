// See https://aka.ms/new-console-template for more information

using DogClassQuiz;

class Program
{
    static void Main()
    {
        Dog Lucky = new Dog("Lucky", "german shepherd", 40);
        Dog Tina = new Dog("Tina", "shar pei", 25);
        Dog Bobo = new Dog("Bobo", 3);

        Console.WriteLine(Lucky.Describe());
        Console.WriteLine(Tina.Describe());
        Console.WriteLine(Bobo.Describe());
    }
}