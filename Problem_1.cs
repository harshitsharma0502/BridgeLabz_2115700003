using System;

public class Animal //base class Animal
{
   public string name;
   public int age;

   public Animal(string name, int age)
   {
       this.name = name;
       this.age = age;
   }

   public virtual void MakeSound()
   {
       Console.WriteLine("Animal make a sound");
   }
}
public class Dog : Animal //derived class Dog
{
   public Dog(string name, int age) : base(name, age)
   {
   }
   public override void MakeSound()
   {
       Console.WriteLine("Dog barks");
   }
}
public class Cat : Animal // derived class cat
{
   public Cat(string name, int age) : base(name, age)
   {
   }
   public override void MakeSound()
   {
       Console.WriteLine("Cat meows");
   }
}
public class Bird : Animal // derived class Bird
{
   public Bird(string name, int age) : base(name, age)
   {
   }
   public override void MakeSound()
   {
       Console.WriteLine("Bird chirps");
   }
}
public class Program
{
   public static void Main()
   {
       Animal dog = new Dog("Buddy", 3);
       Animal cat = new Cat("Whiskers", 2);
       Animal bird = new Bird("Tweety", 1);

       dog.MakeSound();
       cat.MakeSound();
       bird.MakeSound();
   }
}
