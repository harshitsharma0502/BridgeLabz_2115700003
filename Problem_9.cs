using System;
using System.Collections.Generic;

class CustomHashMap<K, V>
{
    private const int Size = 1000;
    private LinkedList<KeyValuePair<K, V>>[] map;

    public CustomHashMap()
    {
        map = new LinkedList<KeyValuePair<K, V>>[Size];
        for (int i = 0; i < Size; i++)
        {
            map[i] = new LinkedList<KeyValuePair<K, V>>();
        }
    }

    private int GetIndex(K key)
    {
        return Math.Abs(key.GetHashCode()) % Size;
    }

    public void Insert(K key, V value)
    {
        int index = GetIndex(key);
        foreach (var pair in map[index])
        {
            if (pair.Key.Equals(key))
            {
                map[index].Remove(pair);
                break;
            }
        }
        map[index].AddLast(new KeyValuePair<K, V>(key, value));
    }

    public bool Remove(K key)
    {
        int index = GetIndex(key);
        foreach (var pair in map[index])
        {
            if (pair.Key.Equals(key))
            {
                map[index].Remove(pair);
                return true;
            }
        }
        return false;
    }

    public V Get(K key)
    {
        int index = GetIndex(key);
        foreach (var pair in map[index])
        {
            if (pair.Key.Equals(key))
            {
                return pair.Value;
            }
        }
        throw new KeyNotFoundException("Key not found");
    }
}

class Program
{
    static void Main()
    {
        CustomHashMap<int, string> hashMap = new CustomHashMap<int, string>();
        hashMap.Insert(1, "One");
        hashMap.Insert(2, "Two");
        hashMap.Insert(3, "Three");

        Console.WriteLine("Value for key 2: " + hashMap.Get(2));
        hashMap.Remove(2);
        Console.WriteLine("Key 2 removed.");
    }
}
