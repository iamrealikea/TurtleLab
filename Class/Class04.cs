using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TurtleLab.ConsoleLib;
using static ThanaNita.Turtles.One;
namespace TurtleLab.Class;

internal class Class04
{
    public static void Run()
    {
        App4();

    }
    static void App2()
    {
        for(int i = 1; i <= 10; ++i)
        {
            Console.Write(i);
            if(i != 10)
                Console.Write(","); 
        }
    }
    static void App3()
    {
        SetPenColor(Color.Pink);
        TurnRight(90);
        for (int i = 0; i < 20; ++i)
        {
            if (i % 5 == 01)
                Dot(Color.Blue);
            else
                Dot(Color.Pink);
            Forward(12.5f);
        }
        HideTurtle();

    }
    static void App4()
    {
        Flower();

    }
    static void Flower()
    {
        SetSpeed(5000);
        int count = 99;
        for (int i = 0; i < count; i++)
        {
            LongPetal(Color.LightPink);
            TurnRight(360 / count);
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

}
