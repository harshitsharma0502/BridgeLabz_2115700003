using System;

class RocketLaunchCountdown
{
    static void Main()
    {
        Console.Write("Enter the countdown start value: ");
        int counter = int.Parse(Console.ReadLine()); 
        while (counter >= 1)
        {
            Console.WriteLine(counter);
			counter--;
        }

        Console.WriteLine("Rocket Launched!");
    }
}
