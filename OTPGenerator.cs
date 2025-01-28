using System;

class OTPGenerator
{
    public static void Main()
    {
        int[] otpArray = new int[10]; // Generate 10 OTPs and store them in an array
        for (int i = 0; i < 10; i++)
        {
            otpArray[i] = GenerateOTP();
        }
        Console.WriteLine("Generated OTPs:"); // Display the OTPs
        foreach (int otp in otpArray)
        {
            Console.WriteLine(otp);
        }
        bool areUnique = AreOTPsUnique(otpArray); // Check if all OTPs are unique
        Console.WriteLine($"Are all OTPs unique? {areUnique}");
    }
    public static int GenerateOTP() // Method to generate a 6-digit OTP number
    {
        Random random = new Random();
        int otp = random.Next(100000, 1000000); // Generates a number between 100000 and 999999 (6 digits)
        return otp;
    }
    public static bool AreOTPsUnique(int[] otpArray)
    {
        for (int i = 0; i < otpArray.Length; i++) // Check if all OTPs in the array are unique
        {
            for (int j = i + 1; j < otpArray.Length; j++)
            {
                if (otpArray[i] == otpArray[j]) // If any OTP is repeated
                {
                    return false; // Return false if duplicates found
                }
            }
        }
        return true; // Return true if no duplicates found
    }
}
