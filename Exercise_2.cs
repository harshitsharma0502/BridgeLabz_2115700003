using System;

class LegacyAPI
{
    [Obsolete("This method is deprecated. Use NewFeature instead.")]
    public void OldFeature()
    {
        Console.WriteLine("Old feature is running");
    }

    public void NewFeature()
    {
        Console.WriteLine("New feature is running");
    }
}

class UseObsolete
{
    static void Main()
    {
        LegacyAPI api = new LegacyAPI();
        api.OldFeature(); // Warning: 'LegacyAPI.OldFeature()' is obsolete
        api.NewFeature(); // Output: New feature is running
    }
}