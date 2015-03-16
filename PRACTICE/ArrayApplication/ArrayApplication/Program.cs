using System;

namespace ArrayApplication
{
    class Program
    {
        public void OneDimension()
        {
            Console.Write("Enter total elements: ");

            int total = Convert.ToInt32(Console.ReadLine());
            double[] myArray = new double[total];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter a number: ");
                double number = Convert.ToInt32(Console.ReadLine());
                myArray[i] = number;
            }

            Console.WriteLine("Your array is");
            foreach (double j in myArray)
            {
                Console.WriteLine(j);
            }
        }

        public void TwoDimension()
        {
            Console.Write("Enter total row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total column: ");
            int col = Convert.ToInt32(Console.ReadLine());

            double[,] myArray = new double[row, col];
            
            for(int r = 0; r < row; r++)
            {
                for(int c = 0; c < col; c++)
                {
                    Console.Write("Enter [{0}][{0}]: ", r,c);
                    double num = Convert.ToDouble(Console.ReadLine());
                    myArray[r,c] = num;
                }
            }

            Console.WriteLine("Your array is");
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    Console.Write(myArray[r,c]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Dimension Type: 1 or 2");
            int type = Convert.ToInt32(Console.ReadLine());
            Program p = new Program();

            switch (type)
            {
                case(1):
                    p.OneDimension();
                    break;
                case(2):
                    p.TwoDimension();
                    break;
                    
            }
            
            
            Console.ReadLine();
        }
    }
}
