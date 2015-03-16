using System;

namespace EnumApplication
{
    class Program
    {
        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        static void Main(string[] args)
        {
            int WeekStart = (int)Days.Mon;
            Console.WriteLine("WeekStart = {0}", WeekStart);
            Console.ReadLine();
        }
    }
}
