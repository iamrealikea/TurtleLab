using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static ThanaNita.Turtles.One;
using static TurtleLab.ConsoleLib;

namespace TurtleLab
{
    internal class Lab05
    {
        public static void Run()
        {
            Lab4();
        } 
        private static void Lab2()
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.Write(new string(' ', 19 - (i*2)));
                for (int j = 0; j < i + 1; ++j)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
        static void Lab3() {
            for (int y = 0; y < 10; ++y)
            {
                for (int x = 0; x < 10; ++x)
                {
                    Position = new Vector2(x * 25, y * 25);
                    if (x >= 3 && y >= 3 && x <= 6 && y <= 6)
                        Dot(Color.Pink);
                    else
                        Dot(Color.Green);
                }
            }

        }
        static void Lab4()
        {
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    Position = new Vector2(j * 25, i * 25);
                       if ((i+j)%2 != 0)
                        Dot(Color.Green);
                    else 
                    Dot(Color.Pink);
                }
            }
        }
    }
}
