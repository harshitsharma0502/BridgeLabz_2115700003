using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipedStreamCommunication
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle))
        {
            Thread writerThread = new Thread(() => WriteData(pipeServer));
            Thread readerThread = new Thread(() => ReadData(pipeClient));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
    }

    static void WriteData(PipeStream pipe)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipe, Encoding.UTF8, leaveOpen: true))
            {
                writer.AutoFlush = true;
                for (int i = 1; i <= 5; i++)
                {
                    string message = $"Message {i}";
                    Console.WriteLine($"Writing: {message}");
                    writer.WriteLine(message);
                    Thread.Sleep(500); // Simulate work
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Write Error: {ex.Message}");
        }
    }

    static void ReadData(PipeStream pipe)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipe, Encoding.UTF8))
            {
                string message;
                while ((message = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"Read: {message}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Read Error: {ex.Message}");
        }
    }
}
