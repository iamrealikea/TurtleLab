using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TurtleLab.ConsoleLib;

namespace TurtleLab;

internal class Lab03
{
    public static void Run()
    {
        Print(Grading(74));
        Print(Grading(75));
        Print(Grading(82));
        Print(Grading(94));
        Print(Grading(60));
        Print(Grading(69));
        Print(Grading(51));
        Print(Grading(55));
        Print(Grading(49));

    }
    static string Grading(float score)
    {
        if (score >= 80)
            return "A";
        else if (score >= 75)
            return "B+";
        else if (score >= 70)
            return "B";
        else if (score >= 65)
            return "C+";
        else if (score >= 60)
            return "C";
        else if (score >= 55)
            return "D+";
        else if (score >= 50)
            return "D";
        else
            return "E";
    }

    static int Max(int a, int b, int c, int d)
    {
        int m = a;
        if (b > m)
            m = b;
        if (c > m)
            m = c;
        if (d > m)
            m = d;
        return m;
    }
    /*static int Max(int a, int b, int c)
    {
        int m = a;
        if (b > m)
            m = b;
        if (c > m)
            m = c;
        return m;
    }*/

    static int Abs(int a)
    {
        if (a > 0)
            return a;
        else return -a;
    }

    
    
}
