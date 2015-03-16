using System;

namespace Array_Structure_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayEx p = new ArrayEx();
            // p.ReverseArray();

            // p.SearchInArray();

            // p.EventNumberArray();

            // p.PositiveNegativeArray();

            // p.ManyNumberSum();

            // p.Statistics();

            StructEx s = new StructEx();
            // s.DataTwoPoint();
            // s.ArrayOfStruct();
            s.CityDatabase();

            Console.WriteLine("Press any key to exit....");
            Console.ReadLine();
        }
    }
}
