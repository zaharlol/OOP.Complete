using System.Security.Cryptography.X509Certificates;

abstract class Delivery
{
    public string Address;
}

class ASK : Delivery
{
    public string DOST() 
    { 
    Console.WriteLine("Выберите способ доставки:");
        Console.WriteLine("1: Доставка на дом");
        Console.WriteLine("2: Доставка в точку выдачи");
        Console.WriteLine("3: Доставка в магазин");
        HomeDelivery homeDelivery = new HomeDelivery();
        PickPointDelivery pickPointDelivery = new PickPointDelivery();
        ShopDelivery shopDelivery = new ShopDelivery();
        string address = Console.ReadLine();
        switch (address)
        {
            case "1" : homeDelivery.Home();
                break;
            case "2" : pickPointDelivery.PP();
                break;
            case "3" : shopDelivery.Shop();
                break;
        }
        return address;
    }
}


class HomeDelivery : Delivery
{
    public void Home()
    {
        Console.WriteLine("Доставка на дом");
    }
}

class PickPointDelivery : Delivery
{
    public void PP()
    {
        Console.WriteLine("Доставка в точку выдачи");
    }
}

class ShopDelivery : Delivery
{
    public void Shop()
    {
        Console.WriteLine("Доставка в магазин");
    }
}

class Order<TDelivery,
TStruct> : MyOrders<string> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }
}

class MyOrders<T> 
{
    public T[] Number;
}
class Product<T> : Order<Delivery, T>
{
    public string Name;
    public double Price;
}
abstract class Characteristics : Product<string>
{
    private string Color;

    private double Weight;

    private string[] Peculiarities;

}
class Reviews : Product<string>
{
    public string[] Reviews1;
}
class Program
{
    static void Main(string[] args)
    {
        ASK ask = new ASK();
        ask.DOST();
    }
}