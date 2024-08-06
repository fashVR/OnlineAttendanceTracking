using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        string fileName = @"C:\VSFileProgram\test.txt";
        Console.WriteLine("Hello student! Insert your name: ");
        string studentName = Console.ReadLine() ?? string.Empty;

        Console.WriteLine(string.Format("hello {0}!", studentName));
        createTextFile(fileName, studentName);
    }


    public static void createTextFile(string fileName, string name)
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
        FileStream fs = File.Create(fileName);
        byte[] title = new UTF8Encoding(true).GetBytes(name);
        fs.Write(title, 0, title.Length);
        fs.Close();
    }
}