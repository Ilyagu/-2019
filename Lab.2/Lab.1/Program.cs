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
            Console.Title = "Нагдимаев Ильягу ИУ5-35Б";
            double a;
            double b;
            double c;
            if (args.Length == 3)
            {
                Console.WriteLine("Ввод ");
                try
                {
                    a = Double.Parse(args[0]);
                    b = Double.Parse(args[1]);
                    c = Double.Parse(args[2]);
                }
                catch
                {
                    Console.WriteLine("Коэффициент должен быть числом. Повторите ввод.");
                    a = ReadDouble("Коэффициент а: ");
                    b = ReadDouble("Коэффициент b: ");
                    c = ReadDouble("Коэффициент c: ");
                }
            }
            else
            {
                a = ReadDouble("Коэффициент a: ");
                b = ReadDouble("Коэффициент b: ");
                c = ReadDouble("Коэффициент c: ");
            }
            if (a == 0 && b != 0)
            {
                double root = (-1 * c) / b;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Корни " + Math.Sqrt(root) + " и -" + Math.Sqrt(root));
            }
            else if (a != 0)
            {
                double d = Math.Pow(b, 2) - 4 * a * c;
                Console.WriteLine("Дискриминант: " + d);
                if (d > 0)
                {
                    double root_1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                    double root_2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корень 1: " + Math.Sqrt(root_1));
                    Console.WriteLine("Корень 2: " + -1 * Math.Sqrt(root_1));
                    Console.WriteLine("Корень 3: " + Math.Sqrt(root_2));
                    Console.WriteLine("Корень 4: " + -1 * Math.Sqrt(root_2));
                }
                else if (d == 0)
                {
                    double root = (b + Math.Sqrt(d)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни " + Math.Sqrt(root) + " и " + -1 * Math.Sqrt(root));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корни отсутствуют");
                }
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(c + "=0 равенство не тождественно");
            }
            Console.ReadLine();
        }
        static double ReadDouble(string consoleMessage)
        {
            string resultString;
            double resultDouble;
            bool point;
            do
            {
                Console.Write(consoleMessage);
                resultString = Console.ReadLine();
                if (!(point = double.TryParse(resultString, out resultDouble)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Коэффициент должен быть числом. Повторите ввод.");
                    Console.ResetColor();
                }
            }
            while (!point);
            return resultDouble;
        }
    }
}
