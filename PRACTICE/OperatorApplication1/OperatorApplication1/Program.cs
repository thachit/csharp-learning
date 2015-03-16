using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c = a + b;
            if (a + b == 2)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Not Ok");
            }
            Console.ReadLine();

            // (c == 2) ? Console.WriteLine("Ok") : Console.WriteLine("Not Ok");
        }
    }
}
