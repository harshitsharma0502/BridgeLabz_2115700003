using System;
using System.Collections.Generic;
using System.Reflection;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class ObjectMapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties) where T : new()
    {
        T obj = (T)Activator.CreateInstance(clazz);

        foreach (var prop in properties)
        {
            PropertyInfo propertyInfo = clazz.GetProperty(prop.Key);
            if (propertyInfo != null && propertyInfo.CanWrite)
            {
                propertyInfo.SetValue(obj, Convert.ChangeType(prop.Value, propertyInfo.PropertyType));
            }
        }

        return obj;
    }
}

class Program
{
    static void Main()
    {
        Dictionary<string, object> data = new Dictionary<string, object>
        {
            { "Name", "Alice" },
            { "Age", 25 }
        };

        Person person = ObjectMapper.ToObject<Person>(typeof(Person), data);
        person.Display();
    }
}
