using System;
using System.Text;

// Step 1: Define the custom attribute
[AttributeUsage(AttributeTargets.Field)]
class JsonField : Attribute
{
    public string Name { get; set; }

    public JsonField(string name)
    {
        Name = name;
    }
}

// Step 2: Apply the attribute to fields
class User
{
    [JsonField("user_name")]
    public string Username;

    [JsonField("user_age")]
    public int Age;

    public User(string username, int age)
    {
        Username = username;
        Age = age;
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Serialize the object to JSON
        var user = new User("Harshit", 25);
        Console.WriteLine(SerializeToJson(user));
    }

    static string SerializeToJson(object obj)
    {
        var type = obj.GetType();
        var fields = type.GetFields();
        var json = new StringBuilder("{");

        foreach (var field in fields)
        {
            var attribute = (JsonField)Attribute.GetCustomAttribute(field, typeof(JsonField));
            if (attribute != null)
            {
                json.Append($"\"{attribute.Name}\":\"{field.GetValue(obj)}\",");
            }
        }

        if (json.Length > 1)
        {
            json.Length--; // Remove the last comma
        }

        json.Append("}");
        return json.ToString();
    }
}