	using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Overriding
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.MakeSound(); // Output: Dog barks
    }
}