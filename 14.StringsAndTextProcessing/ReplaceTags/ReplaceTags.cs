using System;
using System.Text;

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine(@"Write a program that replaces in a HTML document given as string all the tags <a href=""…"">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:");
        Console.WriteLine(@"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>");
        Console.WriteLine(@"<p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>");
        Console.WriteLine();
        Console.WriteLine("This is our HTML document:");
        Console.WriteLine(@"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>");
        string html = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        StringBuilder newHtml = new StringBuilder(html);
        newHtml.Replace(@"<a href=""", @"[URL=");
        newHtml.Replace(@">""", @"]");
        newHtml.Replace(@""">", @"]");
        Console.WriteLine();
        Console.WriteLine("This is our new document");
        Console.WriteLine(newHtml);

    }
}
