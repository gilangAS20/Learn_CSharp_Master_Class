namespace FirstProgramToDoList;

public class ToDoList
{
    private readonly string _name;
    private readonly string _continue = "press any key to continue";
    private Dictionary<int, ToDoItems> _toDo; // the plan in ToDo using object
    private Dictionary<int, string> _temporaryToDo; // just for temporary, if it works it will change to ToDo with object
    
    public ToDoList(string name)
    {
        _name = name;
        _toDo = new Dictionary<int, ToDoItems>();
        _temporaryToDo = new Dictionary<int, string>();
    }

    public void RunToDoList()
    {
        EUserInput? inputResult = null;
        do
        {
            Console.Clear();
            // show the menu
            PrintMenu();
        
            // give the user to input menu
            inputResult = GetChoosenMenu(Console.ReadLine());
        
            // show the choosen menu
            ShowChoosenMenu(inputResult);
        } while (inputResult != EUserInput.E);

    }
    
    private void PrintMenu()
    {
        Console.WriteLine($"Hi {_name}, welcome to your personal ToDoList\n");
        
        Console.WriteLine("======== TODO LIST ========");
        Console.WriteLine("[S]ee all TODOs");
        Console.WriteLine("[A]dd a TODO");
        Console.WriteLine("[R]emove a TODO");
        Console.WriteLine("[E]xit");

        Console.WriteLine("\nPlease Input Menu:");
    }

    private EUserInput GetChoosenMenu(string inputString)
    {
        if (inputString.Length != 1)
        {
            Console.WriteLine("Please input 1 character, " + _continue);
            Console.ReadKey();
            return EUserInput.None;
        }
        
        char inputChar = Convert.ToChar(inputString);
        switch (inputChar)
        {
            case 'S':
                return EUserInput.S;
            case 's':
                return EUserInput.S;
            case 'A':
                return EUserInput.A;
            case 'a':
                return EUserInput.A;
            case 'R':
                return EUserInput.R;
            case 'r':
                return EUserInput.R;
            case 'E':
                return EUserInput.E;
            case 'e':
                return EUserInput.E;
        }

        return EUserInput.None;
    }

    private void ShowChoosenMenu(EUserInput? userInput)
    {
        switch (userInput)
        {
            case EUserInput.S:
                SeeAllTodo();
                break;
            case EUserInput.A:
                AddTodo();
                break;
            case EUserInput.R:
                RemoveTodo();
                break;
            case EUserInput.E:
                Exit();
                break;
            default:
                Console.WriteLine("Please Chose The Exist Menu");
                break;
        }
    }
    
    private void SeeAllTodo()
    {
        Console.WriteLine("See All Todo");

        if (_temporaryToDo.Count <= 0)
        {
            Console.WriteLine("There is no ToDo, " + _continue);
            Console.ReadKey();
            return;
        }
        
        foreach (var toDo in _temporaryToDo)
        {
            Console.WriteLine($"{toDo.Key}. {toDo.Value}");
        }
        Console.WriteLine(_continue);
        Console.ReadKey();
    }
    
    private void AddTodo()
    {
        Console.WriteLine("Add Todo");
        Console.WriteLine("Input ToDo:");
        string? toDoInput = Console.ReadLine();

        if (toDoInput == null)
        {
            Console.WriteLine("ToDo cannot empty, " + _continue);
            Console.ReadKey();
            AddTodo();
        }

        if (_temporaryToDo.Count == 0)
        {
            _temporaryToDo.Add(1, toDoInput);
            Console.WriteLine("Success add ToDo, " + _continue);
            Console.ReadKey();
        }
        else
        {
            // take the last id of dictionary
            var lastId = _temporaryToDo.Keys.Last();
            _temporaryToDo.Add(lastId+1, toDoInput);
            Console.WriteLine("Success add ToDo, " + _continue);
            Console.ReadKey();
        }
    }
    
    private void RemoveTodo()
    {
        Console.WriteLine("Remove Todo");

        string _userInput = Console.ReadLine();
        
        if (_userInput.Length != 1)
        {
            Console.WriteLine("Please input 1 character, " + _continue);
            Console.ReadKey();
            return;
        }
        
        int id = Int32.Parse(_userInput);

        if (!_temporaryToDo.ContainsKey(id))
        {
            Console.WriteLine("Id is not exist" + _continue);
            Console.ReadKey();
        }
        else
        {
            _temporaryToDo.Remove(id);
            Console.WriteLine($"ToDo with ID {id} deleted, result: \n");
            SeeAllTodo();
        }
        
    }
    
    private void Exit()
    {
        Console.WriteLine("Exit The App");
        Console.WriteLine(_continue);
    }

}