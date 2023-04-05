using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

class Obj
{
    public string Name;
    public string Description;

    public static string Parent;
    public static int DaysInWeek;
    public static int MaxValue;

    static Obj()
    {
        Parent = "System.Object";
        DaysInWeek = 7;
        MaxValue = 2000;
    }
}
class Helper
{
    public static void Swap(ref int a, ref int b)
    {
        int c = a;
        a = b;
        b = c;

    }
}
class Program
{
    static void Main(string[] args)
    {
        int num1 = 7;
        int num2 = -13;
        int num3 = 0;

        Console.WriteLine(num1.GetNegative()); //-7
        Console.WriteLine(num1.GetPositive()); //7
        Console.WriteLine(num2.GetNegative()); //-13
        Console.WriteLine(num2.GetPositive()); //13
        Console.WriteLine(num3.GetNegative()); //0
        Console.WriteLine(num3.GetPositive()); //0
    }
}

static class Int
{
    public static int GetNegative(this int a)
    {
        if (a <= 0) 
        {
            return a;
        }
        else 
        {
            return -a; 
        }
    }
    public static int GetPositive(this int a)
    {
        if (a > 0)
        {
            return a;
        }
        else
        {
            return -a;
        }
    }
}