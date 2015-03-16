using System;
using System.IO;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for(int i = 0; i< 20; i++)
            {
                f.WriteByte((byte)i);
            }

            f.Position = 0;

            for(int i = 0; i< 20; i++)
            {
                Console.WriteLine(f.ReadByte() + " ");                
            }

            f.Close();
            Console.ReadKey();
        }
    }
}
