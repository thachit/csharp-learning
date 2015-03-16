using System;

namespace MethodApplication
{
    class MethodExecute
    {
        public int FindMax(int a, int b)
        {
            return a < b? b: a;
        }

        public void Swap(int a, int b)
        {
            int temp;

            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

           MethodExecute m = new MethodExecute();

            // Find max number
           int MaxNumber = m.FindMax(a, b);
           Console.WriteLine("Max Number = {0}", MaxNumber.ToString());

           Console.WriteLine("======================================");
             
            // Increase a
            m.Swap(a, b);
            Console.WriteLine("A after = {0}", a.ToString());
            Console.WriteLine("B after = {0}", b.ToString());
            Console.WriteLine("======================================");
           Console.ReadLine();
        }
    }
}