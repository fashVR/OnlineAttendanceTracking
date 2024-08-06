using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello student! Insert your name: ");
        string studentName = Console.ReadLine() ?? string.Empty;

        Console.WriteLine(string.Format("hello {0}!", studentName));
    }


    public void createTextFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
        using (FileStream fs = File.Create(fileName))
        {

        }
    }
}