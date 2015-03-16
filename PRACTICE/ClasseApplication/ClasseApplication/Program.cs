using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseApplication
{
    class Line
    {
        double length;

        public Line()
        {
            Console.WriteLine("Object is created");
        }

        ~Line()
        {
            Console.WriteLine("Object is deleted");
        }

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value >= 0)
                {
                    length = value;
                }                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Line line = new Line();

            line.Length = -1;
            Console.WriteLine(line.Length);
            Console.ReadKey();
        }
    }
}
