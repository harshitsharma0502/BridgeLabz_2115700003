using System;
using System.Collections;

class HideWarnings
{
    static void Main()
    {
        // Disable warning CS0618 for using non-generic ArrayList
#pragma warning disable 0618
        ArrayList list = new ArrayList();
        list.Add("Hello");
        list.Add(123);
#pragma warning restore 0618

        // Iterate through the list and print items
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}