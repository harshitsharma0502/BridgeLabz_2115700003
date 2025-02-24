using System;
using System.IO;

public class FileProcessor
{
    public void WriteToFile(string filename, string content)
    {
        if (string.IsNullOrEmpty(filename)) throw new ArgumentException("Filename cannot be empty.");
        File.WriteAllText(filename, content);
    }

    public string ReadFromFile(string filename)
    {
        if (!File.Exists(filename))
            throw new IOException("File not found.");

        return File.ReadAllText(filename);
    }
}


using NUnit.Framework;
using System;
using System.IO;

[TestFixture]
public class FileProcessorTests
{
    private FileProcessor fileProcessor;
    private string testFilePath;

    [SetUp]
    public void Setup()
    {
        fileProcessor = new FileProcessor();
        testFilePath = "testfile.txt";
    }

    [TearDown]
    public void Cleanup()
    {
        if (File.Exists(testFilePath))
            File.Delete(testFilePath); // Remove test file after each test
    }

    [Test]
    public void WriteToFile_ShouldCreateFileAndWriteContent()
    {
        string content = "Hello, NUnit!";
        fileProcessor.WriteToFile(testFilePath, content);

        Assert.IsTrue(File.Exists(testFilePath));
        string readContent = File.ReadAllText(testFilePath);
        Assert.AreEqual(content, readContent);
    }

    [Test]
    public void ReadFromFile_ShouldReturnCorrectContent()
    {
        string content = "Test content";
        File.WriteAllText(testFilePath, content); // Manually creating the file
        string readContent = fileProcessor.ReadFromFile(testFilePath);

        Assert.AreEqual(content, readContent);
    }

    [Test]
    public void ReadFromFile_ShouldThrowException_WhenFileDoesNotExist()
    {
        Assert.Throws<IOException>(() => fileProcessor.ReadFromFile("nonexistent.txt"));
    }

    [Test]
    public void WriteToFile_ShouldThrowException_WhenFilenameIsEmpty()
    {
        Assert.Throws<ArgumentException>(() => fileProcessor.WriteToFile("", "Some content"));
    }
}

