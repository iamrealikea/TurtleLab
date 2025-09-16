using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static ThanaNita.Turtles.One;
using static TurtleLab.ConsoleLib;

namespace TurtleLab;

internal class Class05
{
    public static void Run()
    {
        App3();
    }

    static void App1()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10 - i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
        static void App3()
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(new string(' ', 0 + i));
                for (int j = 10; j > i + 1; --j)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    static void App4()
    {
        for (int y = 0; y < 10; ++y)
        {
            for (int x = 0; x < 10; ++x)
            {
                Position = new Vector2(x * 25, y * 25);
                Dot(Color.Green);
            }
        }

    }
    static void App5()
    {
        for (int y = 0; y < 10; ++y)
        {
            for (int x = 0; x < 10; ++x)
            {
                Position = new Vector2(x * 25, y * 25);
                if (y-x >= 1)
                    Dot(Color.Pink);
                else
                    Dot(Color.Green);
            }
        }

    }
    static void App6()
        {
            DrawMirror();
        }
        static void DrawMirror()
        {
            DrawHalf(1, 2f);
            DrawHalf(-1, 0.5f);
        }
        static void DrawHalf(int sign, float scale)
        {
            var position = Position;
            var direction = Direction;

            TurnLeft(45 * sign);
            Forward(100 * scale);
            TurnRight(45 * sign);
            Forward(100 * scale);

            Position = position;
            Direction = direction;
        }
}
