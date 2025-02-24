using System;
using System.Collections.Generic;
using System.Reflection;

// Step 1: Define the custom attribute
[AttributeUsage(AttributeTargets.Method)]
class CacheResult : Attribute
{
}

// Step 2: Create a cache mechanism
class Cache
{
    private static Dictionary<string, object> _cache = new Dictionary<string, object>();

    public static bool TryGet(string key, out object result)
    {
        return _cache.TryGetValue(key, out result);
    }

    public static void Add(string key, object value)
    {
        _cache[key] = value;
    }
}

// Step 3: Apply the attribute to a computationally expensive method
class MathOperations
{
    [CacheResult]
    public int ComputeFactorial(int n)
    {
        Console.WriteLine($"Computing factorial of {n}...");
        if (n == 0 || n == 1)
            return 1;
        return n * ComputeFactorial(n - 1);
    }
}

// Step 4: Intercept method calls and implement caching
class CachedMathOperations : MathOperations
{
    public new int ComputeFactorial(int n)
    {
        // Generate a unique cache key for the method and input
        string cacheKey = $"{nameof(ComputeFactorial)}_{n}";

        // Check if the result is already cached
        if (Cache.TryGet(cacheKey, out object cachedResult))
        {
            Console.WriteLine($"Returning cached result for {n}...");
            return (int)cachedResult;
        }

        // If not cached, compute the result and cache it
        int result = base.ComputeFactorial(n);
        Cache.Add(cacheKey, result);
        return result;
    }
}

class Program
{
    static void Main()
    {
        var mathOps = new CachedMathOperations();

        // First call (not cached)
        Console.WriteLine(mathOps.ComputeFactorial(5)); // Computes and caches

        // Second call (cached)
        Console.WriteLine(mathOps.ComputeFactorial(5)); // Returns cached result

        // Third call (not cached)
        Console.WriteLine(mathOps.ComputeFactorial(6)); // Computes and caches
    }
}