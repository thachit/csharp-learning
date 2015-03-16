using System;

namespace Array_Structure_Strings
{
    class ArrayEx
    {
        public void Statistics()
        {
            /* Create a statistical program which will allow the user to: 
            - Add new data 
            - See all data entered 
            - Find an item, to see whether it has been entered or not 
            - View a summary of statistics: amount of data, sum, average, maximum, minimum 
            - Exit the program 
            These options must appear as a menu. Each option will be chosen by a number or a letter. 
            The program must reserve space for a maximum of 1000 data, but keep count of how many data actually exist.  */

            bool exit = false;
            double[] myArray = new double[1000];
            int indexArray = 0;

            Console.WriteLine();
            Console.WriteLine("1. Enter new data");
            Console.WriteLine("2. See all data");
            Console.WriteLine("3. Search an item");
            Console.WriteLine("4. View Statistics");
            Console.WriteLine("5. Exit");

            do
            {
                Console.WriteLine("=====================================");
                Console.Write("Choose an option: ");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case (1):
                        Console.WriteLine("* Input a number: ");
                        myArray[indexArray] = Convert.ToDouble(Console.ReadLine());
                        indexArray++;
                        break;

                    case (2):
                        for (int i = 0; i < indexArray; i++)
                        {
                            Console.Write(myArray[i].ToString() + " | ");
                        }
                        Console.WriteLine();
                        break;

                    case (3):
                        Console.WriteLine("* Input value to seach: ");
                        double seach = Convert.ToDouble(Console.ReadLine());
                        bool found = false;

                        for (int i = 0; i < indexArray; i++)
                        {
                            if (myArray[i] == seach)
                            {
                                Console.Write("=> This item is at {0}", i);
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.Write("=> This item does not exist");
                        }
                        Console.WriteLine();
                        break;

                    case (4):
                        // View a summary of statistics: amount of data, sum, average, maximum, minimum 
                        double MaxNumber = myArray[0];
                        double MinNumber = myArray[0];
                        int Count = 0;
                        double Total = 0;

                        for (int i = 0; i < indexArray; i++)
                        {
                            if (MaxNumber < myArray[i])
                            {
                                MaxNumber = myArray[i];
                            }
                            if (MinNumber > myArray[i])
                            {
                                MinNumber = myArray[i];
                            }
                            Total += myArray[i];
                            Count++;
                        }

                        Console.WriteLine("=> Amount of data: {0}", Count);
                        Console.WriteLine("=> Sum of data: {0}", Total);
                        Console.WriteLine("=> Average: {0}", ComputeAverage(Total, Count));
                        Console.WriteLine("=> Maximum: {0}", MaxNumber);
                        Console.WriteLine("=> Minimum: {0}", MinNumber);
                        break;

                    case (5):
                        Console.WriteLine("5. Exit");
                        exit = true;
                        break;
                }
            }
            while (exit == false);

        }

        public void ManyNumberSum()
        {
            /* Create a program which asks the user for several numbers (until he enters "end" and displays their sum). 
             When the execution is going to end, it must display all the numbers entered, and the sum again, as follows: 
                Enter a number: 5 
                Sum = 5 
                Enter a number: 3 
                Sum = 8 
                Enter a number: end 
                The numbers are: 5 3 
                The sum is: 8  */

            double total = 0;
            double[] myArray = new double[1000];
            int totalItem = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter a number: ");
                string args = Console.ReadLine();
                if (args == "end")
                {
                    totalItem = i;
                    break;
                }

                double number = Convert.ToDouble(args);
                myArray[i] = number;
                total += number;

                Console.WriteLine("Sum = {0}", total);
            }
            Console.WriteLine("====================================");
            Console.Write("The numbers are: ");
            for (int i = 0; i < totalItem; i++)
            {
                Console.Write(myArray[i].ToString() + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("The Sum is: {0}", total);
        }

        private double ComputeAverage(double total, int count)
        {
            return Convert.ToDouble(total / count);
        }

        public void PositiveNegativeArray()
        {
            /* Create a C# program to ask the user for 10 real numbers and display the average of the positive ones and the average of the negative ones. */

            int[] myArray = new int[10];
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter a number {0}: ", i);
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int CountPositive = 0;
            int TotalPositive = 0;
            int CountNegative = 0;
            int TotalNegative = 0;

            foreach (int item in myArray)
            {
                if (item > 0)
                {
                    CountPositive++;
                    TotalPositive += item;
                }
                else
                {
                    CountNegative++;
                    TotalNegative += item;
                }
            }

            double AveragePositive = ComputeAverage(TotalPositive, CountPositive);
            double AverageNegative = ComputeAverage(TotalNegative, CountNegative);
            Console.WriteLine("Average Positive= {0}", AveragePositive);
            Console.WriteLine("Average Negative= {0}", AverageNegative);
        }
        public void EventNumberArray()
        {
            /* Write a C# program to ask the user for 10 integer numbers and display the even ones. */

            int[] myArray = new int[10];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter number at {0}: ", i);
                myArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Event number are: ");
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    Console.Write(myArray[i].ToString() + "|");
                }
            }
        }
        public void SearchInArray()
        {
            /* Create a program that says if a data belongs in a list that was previously created. 
            The steps to take are: 
            - Ask the user how many data will he enter. 
            - Reserve space for that amount of numbers (floating point). 
            - Request the data to the user 
            - Later, repeat: 
            * Ask the user for a number (execution ends when he enters "end" instead of a number). 
            * Say if that number is listed or not. 

            Must be done in pairs. but you must provide a single source file, containing the names of both programmers in a comment. */

            // Ask the user how many data will he enter. 
            Console.Write("Enter total: ");
            int total = Convert.ToInt32(Console.ReadLine());

            // Reserve space for that amount of numbers (floating point).
            double[] myArray = new double[total];

            // Request the data to the user 
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter value member: ");
                double number = Convert.ToDouble(Console.ReadLine());
                myArray[i] = number;
            }

            // - Later, repeat: 
            // * Ask the user for a number (execution ends when he enters "end" instead of a number). 
            // * Say if that number is listed or not. 

            bool end = false;
            while (end == false)
            {
                Console.Write("* Enter search value (end to exit): ");
                string search = Console.ReadLine();

                // Stop program
                if (search == "end")
                {
                    end = true;
                }
                else
                {
                    double values = Convert.ToDouble(search);
                    for (int i = 0; i < myArray.Length; i++)
                    {
                        if (myArray[i] == values)
                        {
                            Console.WriteLine("=> This item is at {0}", i);
                            break;
                        }

                        if (i == myArray.Length - 1)
                        {
                            Console.WriteLine("=> This item does not exist");
                        }
                    }
                }
            }
        }

        public void ReverseArray()
        {
            // Create a program to ask the user for 5 numbers, store them in an array and show them in reverse order. 

            double[] myArray = new double[5];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter {0}: ", i);
                double number = Convert.ToDouble(Console.ReadLine());
                myArray[i] = number;
            }

            Console.WriteLine("Your Reverse Array is: ");

            for (int j = myArray.Length - 1; j >= 0; j--)
            {
                Console.Write(myArray[j].ToString() + "|");
            }
        }
    }
}