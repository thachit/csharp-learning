using System;

namespace NullableApplication
{
    class NullablesAtShow
    { 
        static void Main(string[] args)
        {
            int? i = null;
            int? j = 5;

            int num;
            num = j ?? 3;

            Console.WriteLine("num = {0}", num);
            Console.ReadLine();
        }
    }
}
