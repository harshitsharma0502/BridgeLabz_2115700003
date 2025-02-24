using System;

// Step 1: Define the custom attribute
[AttributeUsage(AttributeTargets.Method)]
class RoleAllowed : Attribute
{
    public string Role { get; set; }

    public RoleAllowed(string role)
    {
        Role = role;
    }
}

// Step 2: Apply the attribute to a method
class AdminPanel
{
    [RoleAllowed("ADMIN")]
    public void AdminOnlyMethod()
    {
        Console.WriteLine("Admin-only method executed");
    }
}

class Program
{
    static void Main()
    {
        // Step 3: Simulate user roles and validate access
        string currentUserRole = "USER"; // Simulate a non-admin user

        var method = typeof(AdminPanel).GetMethod("AdminOnlyMethod");
        var attribute = (RoleAllowed)Attribute.GetCustomAttribute(method, typeof(RoleAllowed));

        if (attribute != null && attribute.Role == currentUserRole)
        {
            var adminPanel = new AdminPanel();
            adminPanel.AdminOnlyMethod();
        }
        else
        {
            Console.WriteLine("Access Denied!");
        }
    }
}