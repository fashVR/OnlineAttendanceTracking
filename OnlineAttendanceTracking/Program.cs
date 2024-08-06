using System;
using System.Text;

public class Program
{
    public delegate void Act();
    public static event Act OnAlarm;


    public static void EmailAdministration()
    {
        Console.WriteLine("Administration beware: nonwanted visitor incomming :(");
    }

    public static void ActiviateAlarm()
    {
        Console.WriteLine("WIIIWOOOWIIIWOOOWIIIWOOO");
    }
    public static void Main(string[] args)
    {

        OnAlarm += new Act(EmailAdministration);
        OnAlarm += new Act(ActiviateAlarm);
        Console.WriteLine("Hello student! Insert your name: ");
        string studentName = Console.ReadLine() ?? string.Empty;

        if (studentName == "Jack" || studentName == "Mathew" || studentName == "Steven")
        {
            Action();

        }
        else
        {
            Console.WriteLine(string.Format("hello {0}!", studentName));
            string fileName = string.Format(@"C:\VSFileProgram\{0}.txt", studentName);

            createTextFile(fileName, studentName);
        }

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

    public static void Action()
    {
        if (OnAlarm != null)
        {
            OnAlarm();
        }
    }

}