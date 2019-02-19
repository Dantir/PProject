using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectanglesNtriangles
{
    class Program
    {
        struct Triangles
        {
            public int size;
            public int place1;
            public int place2;
            public int color;
        }
        struct Rectangles
        {
            public int height;
            public int width;
            public int place1;
            public int place2;
            public int color;
        }
        static void PrintTriangle(Triangles triangles)
        {
            int c = triangles.color;
            switch (c)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.SetCursorPosition(triangles.place1, triangles.place2);
            triangles.place2++;
            Console.WriteLine("*");
            Console.SetCursorPosition(triangles.place1, triangles.place2);
            for (int i = 0; i < triangles.size - 2; i++,Console.SetCursorPosition(triangles.place1, triangles.place2+1), triangles.place2++)
            {
                for (int j = 0; j < i+3; j++, Console.SetCursorPosition(triangles.place1 + i+1, triangles.place2))
                Console.WriteLine("*");
            }
            for (int i = 0; i < triangles.size; i++)
                Console.Write("*");
            Console.WriteLine();
        }
        static void PrintRectangle(Rectangles rectangles)
        {
            int c = rectangles.color;
            switch (c)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.SetCursorPosition(rectangles.place1, rectangles.place2);
            rectangles.place2++;
            int i, j;
            for (i = 1; i <= rectangles.height; i++, Console.SetCursorPosition(rectangles.place1, rectangles.place2), rectangles.place2++)
            {
                for (j = 1; j <= rectangles.width; j++)
                {
                    if (i == 1 || i == rectangles.height ||
                        j == 1 || j == rectangles.width)
                        Console.Write("*");
                    else
                        Console.SetCursorPosition(rectangles.place1+j, rectangles.place2-1);
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            Console.WriteLine("!For your own safety, write numbers and only numbers when you are asked to choose an option!\n");
            var triangles = new List<Triangles>();
            var rectangles = new List<Rectangles>();
            rectangles.Add(new Rectangles()
            { color = 1, height = 10, width = 20, place1 = 10, place2 = 20 });
            rectangles.Add(new Rectangles()
            { color = 4, height = 10, width = 20, place1 = 15, place2 = 24 });
            triangles.Add(new Triangles()
            { color = 2, size = 5, place1 = 20, place2 = 10 });
            rectangles.Add(new Rectangles()
            { color = 6, height = 4, width = 10, place1 = 2, place2 = 30 });
            triangles.Add(new Triangles()
            { color = 3, size = 12, place1 = 40, place2 = 40 });
            triangles.Add(new Triangles()
            { color = 5, size = 25, place1 = 9, place2 = 10 });
            var z = 2;
            var x = 2;
            int n = 0;
            switch (n)
            {
                case 0:
                    Console.WriteLine("1. Add Rectangle\n2. Add Triangle\n3. Remove rectangle\n4. Remove triangle\n5. Draw picture\n6. Finish\n\nPlease, choose the option number:");
                    string o = Console.ReadLine();
                    int l = int.Parse(o);
                    if (l == 1)
                    {
                        Console.Clear();
                        goto case 1;
                    }
                    if (l == 2)
                    {
                        Console.Clear();
                        goto case 2;
                    }
                    if (l == 3)
                    {
                        Console.Clear();
                        goto case 3;
                    }
                    if (l == 4)
                    {
                        Console.Clear();
                        goto case 4;
                    }
                    if (l == 5)
                    {
                        Console.Clear();
                        goto case 5;
                    }
                    if (l == 6)
                    {
                        Console.Clear();
                        System.Environment.Exit(1);
                    }
                    if (l == 0)
                    {
                        Console.Clear();
                        goto case 0;
                    }
                    else
                        Console.WriteLine("Please, write the correct number!");
                    goto case 0;
                case 1:
                    Console.WriteLine("Please, write the height of the Rectangle");
                    string heigth = Console.ReadLine();
                    int h = Int32.Parse(heigth);
                    Console.WriteLine("Please, write the width of the Rectangle");
                    string width = Console.ReadLine();
                    int w = Int32.Parse(width);
                    Console.WriteLine("Please, write the interval from the left");
                    string place11 = Console.ReadLine();
                    int p11 = Int32.Parse(place11);
                    Console.WriteLine("Please, write the interval from the top");
                    string place12 = Console.ReadLine();
                    int p12 = Int32.Parse(place12);
                    Console.WriteLine("Please, choose the color of the figure.\nYour options are:\n1. Red\n2. Green\n3. Blue\n4. Gray\n5. Yellow\n6. Magenta");
                    string color1 = Console.ReadLine();
                    int c1 = Int32.Parse(color1);
                    rectangles.Add(new Rectangles()
                    {color = c1, height = h, width = w, place1 = p11, place2 = p12 });
                    Console.Clear();
                    x++;
                    goto case 0;
                case 2:
                    Console.WriteLine("Please, write the size of the Triangle");
                    string size = Console.ReadLine();
                    int s = Int32.Parse(size);
                    Console.WriteLine("Please, write the interval from the left");
                    string place21 = Console.ReadLine();
                    int p21 = Int32.Parse(place21);
                    Console.WriteLine("Please, write the interval from the top");
                    string place22 = Console.ReadLine();
                    int p22 = Int32.Parse(place22);
                    Console.WriteLine("Please, choose the color of the figure.\nYour options are:\n1. Red\n2. Green\n3. Blue\n4. Gray\n5. Yellow\n6. Magenta");
                    string color2 = Console.ReadLine();
                    int c2 = Int32.Parse(color2);
                    triangles.Add(new Triangles()
                    {color = c2, size = s, place1 = p21, place2 = p22 });
                    Console.Clear();
                    z++;
                    goto case 0;
                case 3:
                    if (x==-1)
                    {
                        Console.WriteLine("There are no rectangles left!");
                        Console.ReadKey();
                        Console.Clear();
                        goto case 0;
                    }
                    else
                    Console.WriteLine("Please, decide which rectangle to delete from 0 to " + x);
                    string t = Console.ReadLine();
                    int y = int.Parse(t);
                    rectangles.RemoveAt(y);
                    Console.Clear();
                    x--;
                    goto case 0;
                case 4:
                    if (x == -1)
                    {
                        Console.WriteLine("There are no triangles left!");
                        Console.ReadKey();
                        Console.Clear();
                        goto case 0;
                    }
                    Console.WriteLine("Please, decide which triangle to delete from 0 to " + z);
                    string i = Console.ReadLine();
                    int u = int.Parse(i);
                    triangles.RemoveAt(u);
                    Console.Clear();
                    z--;
                    goto case 0;
                case 5:
                    int num1 = -1;
                    int num2 = -1;
                    foreach (var p in rectangles)
                    {
                        num1++;
                        PrintRectangle(rectangles[num1]);
                    }
                    foreach(var p in triangles)
                    {
                        num2++;
                        PrintTriangle(triangles[num2]);
                    }
                    Console.ReadKey();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    goto case 0;
                case 6:
                    System.Environment.Exit(1);
                    break;
            } 
        }
    }
} 

