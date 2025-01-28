using System;

public class BMICalculator
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your weight in kg: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height in cm: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Convert height to meters and calculate BMI
        double heightInMeters = height / 100;
        double bmi = weight / (heightInMeters * heightInMeters);

        // Print the BMI
        Console.WriteLine("Your BMI is: " + bmi.ToString("F2"));

        // Determine and print the weight status
        if (bmi < 18.5)
            Console.WriteLine("You are Underweight");
        else if (bmi < 25)
            Console.WriteLine("You have Normal weight");
        else if (bmi < 40)
            Console.WriteLine("You are Overweight");
        else
            Console.WriteLine("You are Obese");
    }
}