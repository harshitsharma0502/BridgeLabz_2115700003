using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "DEFAULT_KEY";

    public static void ShowApiKey()
    {
        Console.WriteLine($"API_KEY: {API_KEY}");
    }
}

class Program
{
    static void Main()
    {
        Type type = typeof(Configuration);

        // Get the private static field using Reflection
        FieldInfo fieldInfo = type.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if (fieldInfo != null)
        {
            // Display original value
            Configuration.ShowApiKey();

            // Modify the private static field value
            fieldInfo.SetValue(null, "NEW_SECRET_KEY");

            // Display modified value
            Configuration.ShowApiKey();
        }
        else
        {
            Console.WriteLine("Field not found!");
        }
    }
}
