class Employee
{
    public string Name;
    public int Age;
    public int Salary;
}

class ProjectManager : Employee
{
    public string ProjectName;
}

class Developer : Employee
{
    private string ProgrammingLanguage;
}

class Food { }

class Fruit : Food { }

class Veget : Food { }

class Apple : Fruit { }

class Banana : Fruit { }

class Pear : Fruit { }

class Potato : Veget { }

class Carrot : Veget { }


class Obj
{
    private string name;
    private string owner;
    private int length;
    private int count;

    public Obj(string name, string ownerName, int objLength, int count)
    {
        this.name = name;
        owner = ownerName;
        length = objLength;
        this.count = count;
    }
}

class SmartHelper
{
    private string name;

    public SmartHelper(string name)
    {
        this.name = name;
    }

    public void Greetings(string name)
    {
        Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}", name, this.name);
    }
}
class Program
{
    static void Main(string[] args)
    {
        SmartHelper helper = new SmartHelper("Олег");
        helper.Greetings("Грег");

        Console.ReadKey();
    }

}

class BaseClass
{
    protected string Name;

    public BaseClass(string name)
    {
        Name = name;
    }
}

class DerivedClass : BaseClass
{
    public string Description;

    public int Counter;

    public DerivedClass(string name, string Description) : base(name) 
    {
        this.Description = Description;
    }

    public DerivedClass(string name, string Description, int Counter) : base(name) 
    {
        this.Description = Description;
        this.Counter = Counter;
    }
}