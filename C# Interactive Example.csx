/*
A helpful starting point for C# scripts.

C# Interactive or csi.exe is a REPL (read-evaluate-print-loop) included with Visual Studio 2015 and above.


MSDN article:   https://msdn.microsoft.com/en-us/magazine/mt614271.aspx
*/

using System; // Not needed but helpful for VS IntelliSense.
using System.Diagnostics;
using System.IO;

try
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.WindowWidth = 160;
    Console.WindowHeight = 80;

    var currentPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

    Console.WriteLine(currentPath);

    var files = Directory.EnumerateFiles(currentPath);

    foreach (var file in files)
    {
        Console.WriteLine(file);
    }

    Console.WriteLine(Environment.NewLine + "Smash the Enter key to quit.");
    Console.ReadLine();

}
catch (Exception e)
{
    Console.WriteLine(Environment.NewLine + "Unexpected Exception:" + Environment.NewLine);
    Console.WriteLine(e);
    Console.ReadLine();
}
