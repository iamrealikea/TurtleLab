using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurtleLab;

internal class ConsoleLib
{
    public static void Print(int text)
    {
        Console.WriteLine(text);
    }
    public static void Print(string text)
    {
        Console.WriteLine(text);
    }
    public static int ReadNumber(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }
}
