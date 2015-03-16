using System;

namespace inheritanceApplication
{
    class Shape
    {
        private double width;
        private double length;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Length
        {
            get { return length; }
            set { length = value; }
        }
    }
    class Rectangle : Shape
    {
        public double getArea()
        {
            return Width * Length;
        }

        public void Display()
        {
            Console.WriteLine("Width = {0}", Width);
            Console.WriteLine("Lengh = {0}", Length);
            Console.WriteLine("Area = {0}", getArea());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Length = 5;
            r.Width = 3;
            r.Display();
            Console.ReadKey();
        }
    }
}
