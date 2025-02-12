using System;

public class Item
{
    public string name;
    public int id;
    public double price;
    public double quantity;
    public Item next;

    public Item()
    {
        name = "";
        id = 0;
        price = 0;
        quantity = 0;
        next = null;
    }

    public Item(string name, int id, double price, double quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
        next = null;
    }
}

public class ItemList
{
    private Item head;

    public void AddItemAtBeginning(Item item)
    {
        item.next = head;
        head = item;
        Console.WriteLine("Item added at the beginning of the list");
    }

    public void AddItemAtEnd(Item item)
    {
        if (head == null)
        {
            head = item;
        }
        else
        {
            Item current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = item;
        }
        Console.WriteLine("Item added at the end of the list");
    }

    public void AddItemAtPosition(Item item, int position)
    {
        if (position == 0)
        {
            AddItemAtBeginning(item);
        }
        else
        {
            Item current = head;
            for (int i = 0; i < position - 1; i++)
            {
                current = current.next;
            }
            item.next = current.next;
            current.next = item;
        }

        Console.WriteLine("Item added at position " + position);
    }

    public void DeleteItemWithId(int id)
    {
        if (head == null)
        {
            return;
        }
        if (head.id == id)
        {
            head = head.next;
            return;
        }
        Item current = head;
        while (current.next != null)
        {
            if (current.next.id == id)
            {
                current.next = current.next.next;
                return;
            }
            current = current.next;
        }
    }

    public void UpdateQuantity(int id, double quantity)
    {
        Item current = head;
        while (current != null)
        {
            if (current.id == id)
            {
                current.quantity = quantity;
                return;
            }
            current = current.next;
        }
    }

    public void SearchById(int id)
    {
        Item current = head;
        while (current != null)
        {
            if (current.id == id)
            {
                Console.WriteLine("Item found: " + current.name + " " + current.id + " " + current.price + " " + current.quantity);
                return;
            }
            current = current.next;
        }
        Console.WriteLine("Item with id " + id + " not found");
    }

    public void SearchByName(string name)
    {
        Item current = head;
        while (current != null)
        {
            if (current.name == name)
            {
                Console.WriteLine("Item found: " + current.name + " " + current.id + " " + current.price + " " + current.quantity);
                return;
            }
            current = current.next;
        }
        Console.WriteLine("Item with name " + name + " not found");
    }

    public void TotalValueOfInventory()
    {
        double totalValue = 0;
        Item current = head;
        while (current != null)
        {
            totalValue += current.price * current.quantity;
            current = current.next;
        }
        Console.WriteLine("Total value of inventory: " + totalValue);
    }

    public void SortByNameAscending()
    {
        Item current = head;
        while (current != null)
        {
            Item temp = current.next;
            while (temp != null)
            {
                if (string.Compare(current.name, temp.name) > 0)
                {
                    string name = current.name;
                    current.name = temp.name;
                    temp.name = name;
                    int id = current.id;
                    current.id = temp.id;
                    temp.id = id;
                    double price = current.price;
                    current.price = temp.price;
                    temp.price = price;
                    double quantity = current.quantity;
                    current.quantity = temp.quantity;
                    temp.quantity = quantity;
                }
                temp = temp.next;
            }
            current = current.next;
        }

        Console.WriteLine("Inventory sorted by name in ascending order");
    }

    public void SortByNameDescending()
    {
        Item current = head;
        while (current != null)
        {
            Item temp = current.next;
            while (temp != null)
            {
                if (string.Compare(current.name, temp.name) < 0) // Change comparison for descending order
                {
                    string name = current.name;
                    current.name = temp.name;
                    temp.name = name;
                    int id = current.id;
                    current.id = temp.id;
                    temp.id = id;
                    double price = current.price;
                    current.price = temp.price;
                    temp.price = price;
                    double quantity = current.quantity;
                    current.quantity = temp.quantity;
                    temp.quantity = quantity;
                }
                temp = temp.next;
            }
            current = current.next;
        }

        Console.WriteLine("Inventory sorted by name in descending order");
    }

    public void SortByIdAscending()
    {
        Item current = head;
        while (current != null)
        {
            Item temp = current.next;
            while (temp != null)
            {
                if (current.id > temp.id) // Change comparison for ID sorting in ascending order
                {
                    string name = current.name;
                    current.name = temp.name;
                    temp.name = name;
                    int id = current.id;
                    current.id = temp.id;
                    temp.id = id;
                    double price = current.price;
                    current.price = temp.price;
                    temp.price = price;
                    double quantity = current.quantity;
                    current.quantity = temp.quantity;
                    temp.quantity = quantity;
                }
                temp = temp.next;
            }
            current = current.next;
        }

        Console.WriteLine("Inventory sorted by ID in ascending order");
    }

    public void SortByIdDescending()
    {
        Item current = head;
        while (current != null)
        {
            Item temp = current.next;
            while (temp != null)
            {
                if (current.id < temp.id) // Change comparison for ID sorting in descending order
                {
                    string name = current.name;
                    current.name = temp.name;
                    temp.name = name;
                    int id = current.id;
                    current.id = temp.id;
                    temp.id = id;
                    double price = current.price;
                    current.price = temp.price;
                    temp.price = price;
                    double quantity = current.quantity;
                    current.quantity = temp.quantity;
                    temp.quantity = quantity;
                }
                temp = temp.next;
            }
            current = current.next;
        }

        Console.WriteLine("Inventory sorted by ID in descending order");
    }

    public void DisplayInventory()
    {
        Item current = head;
        while (current != null)
        {
            Console.WriteLine(current.name + " " + current.id + " " + current.price + " " + current.quantity);
            current = current.next;
        }
    }
}
class Program
{
    static void Main()
    {
        ItemList itemlist = new ItemList();

        Item item1 = new Item("Laptop", 101, 50000, 5);
        Item item2 = new Item("Mouse", 102, 500, 10);
        Item item3 = new Item("Keyboard", 103, 1000, 8);
        Item item4 = new Item("Monitor", 104, 15000, 4);
        Item item5 = new Item("Speaker", 105, 2000, 6);

        itemlist.AddItemAtEnd(item1);
        itemlist.AddItemAtEnd(item2);
        itemlist.AddItemAtEnd(item3);
        itemlist.AddItemAtBeginning(item4);
        itemlist.AddItemAtPosition(item5, 2);

        Console.WriteLine("Initial Inventory:");
        itemlist.DisplayInventory();

        Console.WriteLine("\nDeleting item with ID 102 (Mouse)");
        itemlist.DeleteItemWithId(102);
        itemlist.DisplayInventory();

        Console.WriteLine("\nUpdating quantity of item ID 103 (Keyboard) to 15");
        itemlist.UpdateQuantity(103, 15);
        itemlist.DisplayInventory();

        Console.WriteLine("\nSearching for item with ID 101:");
        itemlist.SearchById(101);

        Console.WriteLine("\nSearching for item with Name 'Speaker':");
        itemlist.SearchByName("Speaker");

        itemlist.TotalValueOfInventory();

        Console.WriteLine("\nSorting inventory by Name in ascending order:");
        itemlist.SortByNameAscending();
        itemlist.DisplayInventory();

        Console.WriteLine("\nSorting inventory by Name in descending order:");
        itemlist.SortByNameDescending();
        itemlist.DisplayInventory();

        Console.WriteLine("\nSorting inventory by ID in ascending order:");
        itemlist.SortByIdAscending();
        itemlist.DisplayInventory();

        Console.WriteLine("\nSorting inventory by ID in descending order:");
        itemlist.SortByIdDescending();
        itemlist.DisplayInventory();
    }
}
