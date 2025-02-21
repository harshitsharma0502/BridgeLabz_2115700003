using System;
using System.IO;

class Program
{
    static void Main()
    {
        string imagePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment28\\source.jpg";
        string outputImagePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment28\\output.jpg";

        try
        {

            byte[] imageBytes;
            using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
            using (MemoryStream ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                imageBytes = ms.ToArray();
            }
            Console.WriteLine("Image converted to byte array successfully.");

            using (MemoryStream ms = new MemoryStream(imageBytes))
            using (FileStream fs = new FileStream(outputImagePath, FileMode.Create, FileAccess.Write))
            {
                ms.CopyTo(fs);
            }
            Console.WriteLine("Byte array written back to image file successfully.");

            if (FileEquals(imagePath, outputImagePath))
            {
                Console.WriteLine("Verification successful: The new file is identical to the original.");
            }
            else
            {
                Console.WriteLine("Verification failed: The files are different.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }

    static bool FileEquals(string path1, string path2)
    {
        byte[] file1 = File.ReadAllBytes(path1);
        byte[] file2 = File.ReadAllBytes(path2);

        if (file1.Length != file2.Length)
            return false;

        for (int i = 0; i < file1.Length; i++)
        {
            if (file1[i] != file2[i])
                return false;
        }
        return true;
    }
}
