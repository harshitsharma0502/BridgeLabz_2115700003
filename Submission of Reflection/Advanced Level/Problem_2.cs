using System;
using System.Reflection;
using System.Text;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    private string Secret = "Hidden Info";
}

class JsonConverter
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        StringBuilder json = new StringBuilder();
        json.Append("{ ");

        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        PropertyInfo[] properties = type.GetProperties();

        foreach (var field in fields)
        {
            object value = field.GetValue(obj);
            json.Append($"\"{field.Name}\": \"{value}\", ");
        }

        foreach (var prop in properties)
        {
            object value = prop.GetValue(obj);
            json.Append($"\"{prop.Name}\": \"{value}\", ");
        }

        if (json.Length > 2)
            json.Length -= 2; // Remove last comma and space

        json.Append(" }");
        return json.ToString();
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person { Name = "Alice", Age = 25 };
        string json = JsonConverter.ToJson(person);
        Console.WriteLine(json);
    }
}
