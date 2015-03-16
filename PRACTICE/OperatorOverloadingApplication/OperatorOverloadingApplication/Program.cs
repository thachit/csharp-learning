using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingApplication
{
    class Box
    {
        private double length;      // Length of a box
        private double breadth;     // Breadth of a box
        private double height;      // Height of a box

        public double Length
        {
            get { return length; }
            set { length = value;}
        }

        public double Breadth
        {
            get { return breadth; }
            set { breadth = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double getVolumne()
        {
            return length * breadth * height;
        }

        public static Box operator+ (Box b, Box c)
        {
            Box a = new Box();
            a.length = b.length + c.length;
            a.breadth = b.breadth + c.breadth;
            a.height = b.height + c.height;
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Init box a
            Box a = new Box();
            a.Length = 6.0;
            a.Breadth = 7.0;
            a.Height = 5.0;
            Console.WriteLine("Volumne a = {0}", a.getVolumne());
            // Init box b
            Box b = new Box();
            b.Length = 12.0;
            b.Breadth = 13.0;
            b.Height = 10;
            Console.WriteLine("Volumne b = {0}", b.getVolumne());

            // Init box c
            Box c = new Box();
            c = a + b; // Using Operator Loading +
            Console.WriteLine("Volumne c = {0}", c.getVolumne());

            Console.ReadKey();
        }
    }
}
