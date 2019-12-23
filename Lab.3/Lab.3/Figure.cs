using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    interface IPrint
    {
        void Print();
    }
    abstract class Figure : IComparable
    {
        string Figure_Type;
        public string Type
        {
            get
            {
                return this.Figure_Type;
            }
            protected set
            {
                this.Figure_Type = value;
            }
        }
        public abstract double calc_s();
        public override string ToString()
        {
            return "The area of " + this.Type + " is " + this.calc_s().ToString();
        }
        public int CompareTo(object obj)
        {
            Figure p = (Figure)obj;
            if (this.calc_s() < p.calc_s()) return -1;
            else if (this.calc_s() == p.calc_s()) return 0;
            else return 1;
        }
    }

    class Rectangle : Figure, IPrint
    {
        private double width;
        private double height;
        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
            this.Type = "rectangle";
        }
        public override double calc_s()
        {
            return this.width * this.height;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }

    class Square : Rectangle
    {
        private double length;
        public Square(double l) : base(l, l)
        {
            this.Type = "square";
        }
    }

    class Circle : Figure, IPrint
    {
        private double radius;
        public Circle(double r)
        {
            this.radius = r;
            this.Type = "circle";
        }
        public override double calc_s()
        {
            return Math.Round(Math.PI * radius * radius, 2);
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

}
