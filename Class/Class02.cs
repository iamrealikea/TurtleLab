using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ThanaNita.Turtles.One;

namespace TurtleLab.Class
{
    internal static class Class02
    {
        public static void Run()
        {
            /*TestConsole();
            Print(911);
            Print("Hello");
            int a = ReadNumber("input :");*/
            App6();
        }
        static int ReadNumber(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine()!);
        }

        static void App1()
        {
            int sum = 0;
            for (int i = 1; i <= 100000; ++i)
                sum += i;
                

            Print(sum!);
        }

        static void App2()
        {
            int sum = 0;

            for (int i = 1; i < 5 ; ++i)
            {
                int input = ReadNumber("input: ");
                sum += input;
            }
            Print(sum);
        }

        static void App3()
        {
            int start = ReadNumber("start number: ");
            for (; start <= 10; start++)
                Print("Hello: " + start);
        }

        static void App4()
        {
            SetPenColor(Color.Red);
            TurnRight(90);
            for (int i = 0; i < 10; ++i)
            {
                Forward(1 + i * 5);
                Dot(Color.Blue);
            }

        }

        static void App5()
        {
            DottedLine(10, 20, Color.Pink, Color.Blue);
        }

        static void App6()
        {
            Polygon(100, 5);
            Polygon(100, 7);
        }

        static void Polygon(float length, int count)
        {
            float theta = 360.0f / count;
            for (int i = 0; i < count; i++)
            {
                Forward(length);
                TurnRight(theta);
            }
        }


        static void DottedLine(int count, float segment, Color color1, Color color2)
        {
            for (int i = 0; i < count; ++i)
            {
                SetPenColor(color1);
                Forward(segment);
                SetPenColor(color2);
                Forward(segment);
            }
        }



        static void Print(string text)
        {
            Console.WriteLine(text);
        }

        static void Print(int text)
        {
            Console.WriteLine(text);
        }

        static void TestConsole()
        {
            string? name;
            Console.WriteLine("Hello, World!");
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Your Name is " + name);
        }
    }
}
