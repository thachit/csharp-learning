using System;

namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;

        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            //Rectangle r = new Rectangle();
            //// r.Acceptdetails();
            //r.Display();
            //Console.WriteLine("Size of int: {0}", sizeof(long));
            //Console.ReadLine();

            String str = @"C:\Users\thachnguyen\Dropbox\LEARNING\LEARNING\C#\C# Learning";
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}