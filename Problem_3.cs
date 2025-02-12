using System;
class Person
{
	public string name;
	public int age;
	public Person(string name, int age)
	{
		this.name = name;
		this.age = age;
	}
	public Person(Person p1)
	{
		this.name = p1.name;
		this.age = p1.age;
	}
	public static void Main(string[] args)
	{
		Person p1 = new Person("John", 30);
		// copy constructor
		Person p2 = new Person(p1);
		Console.WriteLine("Name: " + p2.name);
		Console.WriteLine("Age: " + p2.age);
	}
}