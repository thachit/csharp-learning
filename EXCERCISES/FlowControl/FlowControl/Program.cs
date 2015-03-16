using System;

namespace FlowControl
{
    class HollowSquare
    {
        private int width;
        private int number;
    }
    class Rectangle
    {
        private int number;
        private int width;
        private int height;

        public void SetData()
        {
            Console.Write("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter width:");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter height:");
            height = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            for (int h = 0; h < height; h++)
            {
                for (int w = 0; w < width; w++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            // Write a C# program to get a number from the and answer whether it is positive or negative. 
            /* Console.WriteLine("Input a number");
            double a = Convert.ToDouble(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }*/

            // Write a C# program to ask the user for a number; if it is not zero, then it will ask for a second number and display their product; otherwise, it will display "0". 

            /* double a = 0;
            do
            {
                Console.WriteLine("Input a:");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("a = {0}", a.ToString());
            }
            while (a != 0); */

            // Create a program to display on the screen the odd numbers from 15 to 7 (downwards), using "while". 

            /* int i = 15;
            while (i != 7)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("odd = {0}", i.ToString());
                }
                i--;
            }*/

            // Write a C# program to ask the user for an undetermined amount of numbers (until 0 is entered) and display their sum, as follows: 
            //Number? 5 
            //Total = 5 
            //Number? 10 
            //Total = 15 
            //Number? -2 
            //Total = 13 
            //Number? 0 
            //Finished 

            /* double number = 0;
            double i;
            do
            {
                Console.WriteLine("Enter a number (0 to exit): ");
                i = Convert.ToDouble(Console.ReadLine());
                number += i;
            }
            while (i != 0);
            Console.WriteLine("Sum = {0}", number.ToString()); */

            //Create a program to write the even numbers from 10 to 20, both included, except 16, in 3 different ways: 

            //- Incrementing 2 in each step (use "continue" to skip 16) 
            //- Incrementing 1 in each step (use "continue") 
            //- With and endless loop (using "break" & "continue") 
            /* for (int i = 10; i <= 20; i++)
            {
                if (i == 16)
                {
                    continue;
                }
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 10; i <= 20; i += 2 )
            {
                if (i == 16)
                {
                    continue;
                }
                Console.WriteLine(i.ToString());
            }*/

            /* Rectangle r = new Rectangle();
            r.SetData();
            r.Print();
            Console.ReadLine();*/

            //Create a program to ask the user for two numbers and display the numbers between them (both included), 
            //three times: using "for", using "while" and using "do..while" 

            //Enter first number: 6 
            //Enter last number 12 

            // for
            Console.Write("Enter a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b:");
            int b = Convert.ToInt32(Console.ReadLine());

            for (int i = a; i<= b; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();

            int j = a;
            while (j <= b)
            {
                Console.Write(j);
                j++;
            }
            Console.WriteLine();

            int h = a;
            do
            {
                Console.Write(h);
                h++;
            }
            while (h <= b);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
