using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        struct Triangles
        {
            public int size;
            public int place1;
            public int place2;
        }
        struct Rectangles
        {
            public int height;
            public int width;
            public int place1;
            public int place2;
        }
        static void PrintTriangle(Triangles triangles)
        {
            Console.SetCursorPosition(triangles.place1, triangles.place2);
            triangles.place2++;
            Console.WriteLine("*");
            Console.SetCursorPosition(triangles.place1, triangles.place2);
            triangles.place2++;
            for (int i = 0; i < triangles.size - 2; i++, Console.SetCursorPosition(triangles.place1, triangles.place2), triangles.place2++)
            {
                Console.Write("*");
                for (int j = 0; j < i; j++)
                Console.Write(" ");
                Console.WriteLine("*");
            }
            for (int i = 0; i < triangles.size; i++)
            Console.Write("*");
            Console.WriteLine();
        }
        static void PrintRectangle(Rectangles rectangles)
        {
            Console.SetCursorPosition(rectangles.place1, rectangles.place2);
            rectangles.place2++;
            int i, j;
            for (i = 1; i <= rectangles.height; i++, Console.SetCursorPosition(rectangles.place1, rectangles.place2),
            rectangles.place2++)
            {
                for (j = 1; j <= rectangles.width; j++)
                {
                    if (i == 1 || i == rectangles.height ||
                        j == 1 || j == rectangles.width)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            var triangles = new List<Triangles>();
            var rectangles = new List<Rectangles>();
            triangles.Add(new Triangles()
            {size = 15, place1 = 20, place2 = 20});
            rectangles.Add(new Rectangles()
            {height = 20, width = 10, place1 = 60, place2 = 50});
            PrintRectangle(rectangles[]);
            Console.ReadKey();
        }
        /*static void Triangle(int size)
        { 
            Console.WriteLine("*");
            for (int i = 0; i < size - 2; i++)
            {
                Console.Write("*");
                for (int j = 0; j < i; j++) Console.Write(" ");
                Console.WriteLine("*");
            }
            for (int i = 0; i < size; i++) Console.Write("*");
            Console.WriteLine();
        }
        static void Rectangle(int height, int width)
        {
            int i, j;
            for (i = 1; i <= height; i++)
            {
                for (j = 1; j <= width; j++)
                {
                    if (i == 1 || i == height ||
                        j == 1 || j == width)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }*/
    }
}
