using System.Numerics;

class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}
class DerivedClass : BaseClass
{
    public override void Display()
    {
        base.Display();
        Console.WriteLine("Метод класса DerivedClass");
    }
}

class BaseClass1
{
    public virtual int Counter
    {
        get;
        set;
    }
}
class DerivedClass1 : BaseClass1
{
    private int counter;
    public override int Counter
    {
        get
        {
            return counter;
        }
        set
        {
            if (value >= 0)
            {
                counter = value;
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        DerivedClass obj = new DerivedClass();
        obj.Display();

        A a = new A();
        B b = new B();
        C c = new C();
        D d = new D();
        E e = new E();

        d.Display();
        ((A)e).Display();
        ((B)d).Display();
        ((A)d).Display();
    }
}
class A
{
    public virtual void Display()
    {
        Console.WriteLine("Вызван метод класса A");
    }
}
class B : A
{
    public new void Display()
    {
        Console.WriteLine("Вызван метод класса B");
    }
}
class C : A
{
    public override void Display()
    {
        Console.WriteLine("Вызван метод класса C");
    }
}
class D : B
{
    public new void Display()
    {
        Console.WriteLine("Вызван метод класса D");
    }
}
class E : C
{
    public new void Display()
    {
        Console.WriteLine("Вызван метод класса E");
    }
}

class Obj
{
    public int Value;
    public static Obj operator + (Obj a, Obj b)
    {
        return new Obj
        {
            Value = a.Value + b.Value
        };
    }
    public static Obj operator - (Obj a, Obj b)
    {
        return new Obj
        {
            Value = a.Value - b.Value
        };
    }
}
class IndexingClass
{
    private int[] array;

    public IndexingClass(int[] array)
    {
        this.array = array;
    }
    public int this[int index]
    {
        get
        {
            return array[index];
        }

        set
        {
            array[index] = value;
        }
    }
}