//Factory Method is a creational design pattern that provides an interface for creating objects in a superclass,
//but allows subclasses to alter the type of objects that will be created.

class Program
{
    public static void Main(string[] args)
    {
        Truck firstShipment = new Truck();
        firstShipment.Start();
        firstShipment.Deliver();

        Ship secondsShipment = new Ship();
        firstShipment.Start();
        firstShipment.Deliver();
    }
}

interface Transport
{
    void Start();
    void Deliver();
}

public class BasicTransport : Transport
{
    public void Start()
    {
        Console.Write("Start shipment");
    }

    public void Deliver()
    {
        Console.Write("Deliver shipment");
    }
}

public class Truck : BasicTransport
{
    public void Start()
    {
        base.Start();
        //code to start logistics over land
        Console.WriteLine(" over land");
    }

    public void Deliver()
    {
        base.Deliver();
        //code to deliver truck
        Console.WriteLine(" headed to the address");
    }
}

public class Ship : BasicTransport
{
    public void Start()
    {
        base.Start();
        //code to start logistics over sea
        Console.WriteLine(" over sea");
    }

    public void Deliver()
    {
        base.Deliver();
        //code to deliver ship
        Console.WriteLine(" headed to the address");
    }
}