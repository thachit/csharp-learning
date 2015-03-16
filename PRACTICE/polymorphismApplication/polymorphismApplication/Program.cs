using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismApplication
{
    abstract class Shape
    {
        abstract public int Area();
    }

    class Square : Shape
    {
        int side = 0;   
        public Square (int n)
        {
            side = n;
        }

        public override int Area()
        {
            return side * side;
        }
    }

    class FunctionOverloading
    {
        public void print(int i)
        {
            Console.WriteLine("Int: {0}", i);
        }
        public void print(double i)
        {
            Console.WriteLine("Int: {0}", i);
        }

        public void print(string i)
        {
            Console.WriteLine("Int: {0}", i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //FunctionOverloading p = new FunctionOverloading();
            //p.print(1);
            //p.print(2.5);
            //p.print("test");

            Square s = new Square(10);
            int a = s.Area();
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
