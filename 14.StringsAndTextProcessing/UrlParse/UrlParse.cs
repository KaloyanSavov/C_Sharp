using System;
using System.Text;

class UrlParse
{
    static void Main()
    {
        Console.WriteLine("Write a program that parses an URL address given in the format:");
        Console.WriteLine("[protocol]://[server]/[resource]");
        Console.WriteLine("and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:");
        Console.WriteLine("[protocol] = \"http\"");
        Console.WriteLine("[server] = \"www.devbg.org\"");
        Console.WriteLine("[resource] = \"/forum/index.php\"");
        Console.WriteLine();
        Uri url = new Uri("http://www.devbg.org/forum/index.php");
        Console.WriteLine("Protocol: {0}" , url.Scheme);
        Console.WriteLine("Server: {0}" , url.Host);
        Console.WriteLine("Resource: {0}" , url.AbsolutePath);
    }
}
