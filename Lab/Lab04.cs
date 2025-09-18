using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ThanaNita.Turtles.One;
using static TurtleLab.ConsoleLib;

namespace TurtleLab.Lab;

internal class Lab04
{
    public static void Run()
    {
        Lab4();
    }
    static void Lab1()
    {
        SetPenColor(Color.Pink);
        TurnRight(90);
        for (int i = 0; i < 20; ++i)
        {
            if (i % 5 == 0)
                Dot(Color.Blue);
            else if (i % 5 == 1)
                Dot(Color.Red);
            else
                Dot(Color.Pink);
            Forward(12.5f);
        }
        HideTurtle();
    }
    static void Lab2()
    {
        SetPenColor(Color.Pink);
        TurnRight(90);
        for (int i = 0; i < 20; ++i)
        {
            if (i % 5 == 0)
                Dot(Color.Blue);
            else if (i % 5 == 1)
                Dot(Color.Red);
            else if (i % 5 == 2)
                Dot(Color.Green);
            else
                Dot(Color.Pink);
            Forward(12.5f);
        }
        HideTurtle();
    }
    static void Lab3()
    {
        Flower();

    }
    static void Flower()
    {
        SetSpeed(5000);
        int count = 20;
        for (int i = 0; i < count; i++)
        {
            if (i < 10)
            {
                LongPetal(Color.LightSkyBlue);
                TurnRight(360 / count);
            }
            else
            {
                LongPetal(Color.PaleGreen);
                TurnRight(360 / count);
            }
        }
    }

    static void LongPetal(Color color)
    {
        Forward(100);
        TurnLeft(45);
        ArcRight(100, 90);
        TurnRight(90);
        ArcRight(100, 90);
        TurnRight(135);
        Backward(100);
        Fill(color);
    }

    static void Lab4()
    {
        while (true) {
            int n = ReadNumber("Enter ID: ");
            if (n == -1)
            {
                Print("Exited");
                break;
            }
            if (n % 2 == 0)
            {
                Print(n + " is even.");
            }
            else
            {
                Print(n + " is odd.");
            }
        }
    }
}
