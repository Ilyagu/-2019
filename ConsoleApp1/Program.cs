using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нагдимаев И.И, ИУ5-35Б");
            Console.WriteLine();
        l:
            Console.WriteLine("Enter coefficient a");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("a не должно равняться нулю");
                goto l;
            }
            Console.WriteLine("Enter coefficient b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter coefficient c");
            int c = Convert.ToInt32(Console.ReadLine());
            bool f = false;
            if ((b*b-4*a*c)==0)
            {
                if ((-b / (2 * a)) < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет действительных корней");
                    Console.ResetColor();
                }
                else if ((-b /( 2 * a)) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения:");
                    Console.WriteLine("0");
                    Console.ResetColor();
                }
                else
                {
                    double x = Math.Sqrt(-b / (2 * a));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения:");
                    Console.WriteLine(x);
                    Console.WriteLine(-x);
                    Console.ResetColor();
                }

            }
            if ((b * b - 4 * a * c) > 0)
            {
                if (((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a)) < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет действительных корней");
                    Console.ResetColor();
                    f = false;
                }
                else if ((-b / (2 * a)) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения:");
                    Console.WriteLine("0");
                    Console.ResetColor();
                    f = true;
                }
                else
                {
                    double x = Math.Sqrt((-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения:");
                    Console.WriteLine(x);
                    Console.WriteLine(-x);
                    Console.ResetColor();
                    f = true;
                }
                if (((-b - Math.Sqrt(b * b - 4 * a * c)) /( 2 * a)) < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (f==false) Console.WriteLine("Нет действительных корней");
                    Console.ResetColor();
                }
                else if ((-b / 2 * a) == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (f==false) Console.WriteLine("Корни уравнения:");
                    Console.WriteLine("0");
                    Console.ResetColor();
                }
                else
                {
                    double x = Math.Sqrt((-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a));

                    Console.ForegroundColor = ConsoleColor.Green;
                    if (f == false) Console.WriteLine("Корни уравнения:");
                    Console.WriteLine(x);
                    Console.WriteLine(-x);
                    Console.ResetColor();
                }
            }
            if ((b * b - 4 * a * c) < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет действительных корней");
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
