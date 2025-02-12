using System;
class Circle
{
    public double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public Circle()
    {
        this.radius = 0;
    }
    public static void Main(string[] args)
    {
        Circle c1 = new Circle(5);
        Circle c2 = new Circle();
        Console.WriteLine("Radius of c1: " + c1.radius);
        Console.WriteLine("Radius of c2: " + c2.radius);
    }
}