using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ThanaNita.Turtles.One;

namespace TurtleLab.Lab
{
    internal class Lab02
    {
        public static void Run()
        {
            kuy();
        }

        static void Lab021() {
            Print(Sum(1, 10));
            Print(Sum(3, 7));
            Print(Sum(1, 10000));
        }

        static void Lab022()
        {
            Polygon(25, 8);
            Polygon(50, 8);
            Polygon(75, 8);
            Polygon(100, 8);
            Polygon(125, 8);
            Polygon(150, 8);
        }

        static void Lab023()
        {
            Stair(6);
        }

        static void Stair(int n)
        {
            SetPenColor(Color.ForestGreen);
            int i = 1;
            for (; 
                i <= n; i++)
            {
                Forward(25);
                TurnRight(90);
                Forward(25);
                TurnLeft(90);
            }
            TurnRight(180);
            Forward(n * 25);
            TurnRight(90);
            Forward(n * 25);
        }

        static void Polygon(float length, int count)
        {
            float theta = 360.0f / count;
            for (int i = 0; i < count; i++)
            {
                SetPenColor(Color.Aqua);
                Forward(length);
                TurnRight(theta);
            }
        }

        static int Sum(int from, int to)
        {
            int sum = 0;
            for (; from <= to; from++)
                sum += from;
            return sum;
        }
        static void Print(string text)
        {
            Console.WriteLine(text);
        }

        static void Print(int text)
        {
            Console.WriteLine(text);
        }

        static void kuy()
        {
            for (int i = 4 - 1; i >= 0; --i)
                Print(i);
        }
    }
}
