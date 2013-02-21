using System;
using System.IO;
using System.Text;

class FileNameException
{
    static void Main()
    {
        Console.WriteLine("Write a program that enters file name along with its full file path (e.g. C:\\WINDOWS\\win.ini), reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.");
        Console.WriteLine();
        try
        {
            Console.WriteLine("Enter the path of the file:");
            string path = Console.ReadLine();
            string fileRead = File.ReadAllText(path);
            Console.WriteLine(fileRead);
        }
        catch (FileNotFoundException)
        {

            Console.WriteLine("The file is not found.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found.");
        }
        catch (FileLoadException)
        {
            Console.WriteLine("Can't load file.");
        }
        catch (System.ArgumentException)
        {
            Console.WriteLine("Path Not entered.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have a permition to open this file.");
        }

    }
}
