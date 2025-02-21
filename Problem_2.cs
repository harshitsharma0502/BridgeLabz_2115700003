using System;
using System.IO;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        string sourceFilePath = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment28\\largefile.bin";
        string destinationFilePathBuffered = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment28\\destination_buffered.bin";
        string destinationFilePathUnbuffered = "C:\\Users\\DELL\\Desktop\\BL_Assgn\\Assignment28\\destination_unbuffered.bin";

        try
        {
            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("Error: Source file does not exist.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationFilePathUnbuffered, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[4096]; // 4 KB buffer
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destinationStream.Write(buffer, 0, bytesRead);
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Unbuffered Copy Time: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (FileStream destinationStream = new FileStream(destinationFilePathBuffered, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedSource = new BufferedStream(sourceStream, 4096))
            using (BufferedStream bufferedDestination = new BufferedStream(destinationStream, 4096))
            {
                byte[] buffer = new byte[4096]; // 4 KB buffer
                int bytesRead;
                while ((bytesRead = bufferedSource.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bufferedDestination.Write(buffer, 0, bytesRead);
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Buffered Copy Time: {stopwatch.ElapsedMilliseconds} ms");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
