using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Нагдимаев Ильягу ИУ5-35Б Лаб.3";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            //task #2-3
            Rectangle rect = new Rectangle(5, 10);
            Square square = new Square(5);
            Circle circle = new Circle(5);

            //task #4
            Console.WriteLine("ArrayList");
            ArrayList Alist = new ArrayList();
            Alist.Add(rect);
            Alist.Add(square);
            Alist.Add(circle);
            foreach (var x in Alist) Console.WriteLine(x);
            Console.WriteLine("ArrayList sorted");
            Alist.Sort();
            foreach (var x in Alist) Console.WriteLine(x);

            //task #5
            Console.WriteLine("\nList");
            List<Figure> list = new List<Figure>();
            list.Add(rect);
            list.Add(square);
            list.Add(circle);
            foreach (var x in list) Console.WriteLine(x);
            Console.WriteLine("List sorted");
            list.Sort();
            foreach (var x in list) Console.WriteLine(x);

            //task #6
            Console.WriteLine("\nМатрица");
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, 2, new FigureMatrixCheckEmpty());
            matrix[0, 0, 0] = rect;
            matrix[1, 1, 0] = square;
            matrix[2, 2, 1] = circle;
            Console.WriteLine(matrix.ToString());

            try
            {
                Figure temp = matrix[123, 123, 12];
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            //task #7 
            Console.WriteLine("\nСтэк");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rect);
            stack.Push(square);
            stack.Push(circle);
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }
            Console.ReadKey();
        }
    }
}
