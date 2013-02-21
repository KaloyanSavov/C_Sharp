using System;
using System.Net;

class DownloadFileException
{
    static void Main()
    {
        using (WebClient webCl = new WebClient())
        {
            try
            {
                Console.WriteLine("Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.");
                Console.WriteLine();
                webCl.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "image.jpg");
                Console.WriteLine("Download Complete.");
            }
            catch (System.Net.WebException)
            {
                Console.WriteLine("Error downloading file.");
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Wrong path");
            }
            finally
            {
                webCl.Dispose();
            }
        }
    }
}
