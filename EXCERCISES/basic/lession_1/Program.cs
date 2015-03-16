using System;

namespace basic
{

    class lession_1
    {
        static void Main(string[] agrs)
        {
            // 1.1
            //Console.WriteLine("Hello");
            //Console.WriteLine("Thach");
            
            //1.2
            //Console.WriteLine(12 + 13);
                
            // 1.3
            //Console.WriteLine(24 / 5);
            
            // 1.4
            // Console.WriteLine(-1 + 3 *5); // 14
            // Console.WriteLine((24 + 5) % 7); //4
            // Console.WriteLine(15 + -4 * 6 / 11);
            //Console.WriteLine(2 + 10 / 6 * 1 - 7 % 2);

            // 1.5:
            Console.WriteLine("Nhập số a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập số b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("a + b = {0}", (a + b).ToString());

            Console.ReadLine();

        }
    }
}