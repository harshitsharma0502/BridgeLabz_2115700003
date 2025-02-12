using System;
using System.Collections.Generic;

class UserNode
{
    public int UserId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> FriendIds { get; set; }
    public UserNode Next { get; set; }

    public UserNode(int userId, string name, int age)
    {
        UserId = userId;
        Name = name;
        Age = age;
        FriendIds = new List<int>();
        Next = null;
    }
}

class FriendManager
{
    private UserNode head;

    // Add a new user to the list
    public void AddUser(int userId, string name, int age)
    {
        UserNode newUser = new UserNode(userId, name, age);
        if (head == null)
        {
            head = newUser;
        }
        else
        {
            UserNode temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newUser;
        }
        Console.WriteLine($"User {name} added successfully.");
    }

    // Find a user node by userId
    private UserNode FindUser(int userId)
    {
        UserNode current = head;
        while (current != null)
        {
            if (current.UserId == userId)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    // Add a friend connection between two users
    public void AddFriendConnection(int userId1, int userId2)
    {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        if (!user1.FriendIds.Contains(userId2)) user1.FriendIds.Add(userId2);
        if (!user2.FriendIds.Contains(userId1)) user2.FriendIds.Add(userId1);

        Console.WriteLine($"Friend connection added between {user1.Name} and {user2.Name}.");
    }

    // Remove a friend connection
    public void RemoveFriendConnection(int userId1, int userId2)
    {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        user1.FriendIds.Remove(userId2);
        user2.FriendIds.Remove(userId1);

        Console.WriteLine($"Friend connection removed between {user1.Name} and {user2.Name}.");
    }

    // Find mutual friends between two users
    public void FindMutualFriends(int userId1, int userId2)
    {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        List<int> mutualFriends = new List<int>(user1.FriendIds);
        mutualFriends.IntersectWith(user2.FriendIds);

        Console.WriteLine("Mutual Friends:");
        foreach (int id in mutualFriends)
        {
            UserNode friend = FindUser(id);
            if (friend != null) Console.WriteLine(friend.Name);
        }
    }

    // Display all friends of a specific user
    public void DisplayAllFriends(int userId)
    {
        UserNode user = FindUser(userId);
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine($"Friends of {user.Name}:");
        foreach (int id in user.FriendIds)
        {
            UserNode friend = FindUser(id);
            if (friend != null) Console.WriteLine(friend.Name);
        }
    }

    // Search for a user by Name or User ID
    public void SearchUser(string name)
    {
        UserNode current = head;
        bool found = false;

        while (current != null)
        {
            if (current.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"User Found: {current.UserId}, Name: {current.Name}, Age: {current.Age}");
                found = true;
            }
            current = current.Next;
        }

        if (!found) Console.WriteLine("User not found.");
    }

    public void SearchUser(int userId)
    {
        UserNode user = FindUser(userId);
        if (user != null)
        {
            Console.WriteLine($"User Found: {user.UserId}, Name: {user.Name}, Age: {user.Age}");
        }
        else
        {
            Console.WriteLine("User not found.");
        }
    }

    // Count the number of friends for each user
    public void CountFriends()
    {
        UserNode current = head;
        while (current != null)
        {
            Console.WriteLine($"{current.Name} has {current.FriendIds.Count} friends.");
            current = current.Next;
        }
    }

    // Main function to demonstrate functionality
    public static void Main(string[] args)
    {
        FriendManager manager = new FriendManager();

        manager.AddUser(1, "Alice", 25);
        manager.AddUser(2, "Bob", 30);
        manager.AddUser(3, "Charlie", 28);

        manager.AddFriendConnection(1, 2);
        manager.AddFriendConnection(1, 3);
        manager.DisplayAllFriends(1);

        manager.FindMutualFriends(1, 2);

        manager.RemoveFriendConnection(1, 2);
        manager.DisplayAllFriends(1);

        manager.SearchUser("Bob");
        manager.SearchUser(3);

        manager.CountFriends();
    }
}