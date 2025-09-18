using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TurtleLab.ConsoleLib;

namespace TurtleLab.Class;

internal class Class03
{
    public static void Run()
    {
        Print(Abs(100));
        Print(Abs(-100));
        Print(Abs(-99));
        Print(Abs(0));
    }
    static int Max(int a, int b, int c)
    {
        if (a<b) 
            return a;
        else
            return b;
    }
    static int Abs(int a)
    {
        if (a > 0)
            return a;
        else return -a;
    }


}
