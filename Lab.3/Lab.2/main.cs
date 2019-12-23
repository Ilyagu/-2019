using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Нагдимаев Ильягу ИУ5-35Б";
            // object rectangle 24x42
            Rectangle a = new Rectangle(57, 12);
            // object quadrate 56x56
            Quadrate b = new Quadrate(76);
            // object circle r=77
            Circle c = new Circle(40);

            a.Print();
            Console.WriteLine();

            b.Print();
            Console.WriteLine();

            c.Print();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
