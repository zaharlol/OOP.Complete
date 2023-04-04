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
        int num1 = 3;
        int num2 = 58;

        Helper.Swap(ref num1, ref num2);

        Console.WriteLine(num1); 
        Console.WriteLine(num2); 
    }
}