using System;

namespace Array_Structure_Strings
{
    struct TwoDPoint
    {
        public short x;
        public short y;
    }

    struct city
    {
        public string name;
        public uint inhabitants;
    }

    class StructEx
    {
        public void CityDatabase()
        {
            /* Create a database to store information about cities. 

            In a first approach, we will store only the name of each city and the number of inhabitants, and allocate space for up to 500 cities. 

            The menu should include the following options: 
            1 .- Add a new city (at the end of the existing data) 
            2 .- View all cities (name and inhabitants) 
            3 .- Modify a record (rename and / or change number of inhabitants) 
            5 .- Delete a record (moving the following ones to the left so that no empty spaces are left) 
            6 .- Search in the records (display the ones which contain a certain text in their name, whether in upper or lower case, using partial search) 
            7 .- Correct the capitalization of the names (turn into uppercase the first letter and the ones after a space, and make the rest lowercase). 
            0 .- Exit */

            Console.WriteLine("1 .Add a new city");
            Console.WriteLine("2 .Modify a city");
            Console.WriteLine("3 .Delete a city");
            Console.WriteLine("4 .View all cities");
            Console.WriteLine("5 .Search a city");
            Console.WriteLine("0 .Exit");

            bool stop = false;
            city[] cityArray = new city[1000];
            int CurrentIndex = 0;

            while(stop == false)
            {
                Console.WriteLine("=====================================");
                Console.Write("Choose an option: ");
                int option = Convert.ToInt16(Console.ReadLine());

                switch(option)
                {
                    case (0):
                        stop = true;
                        break;
                    case (1):
                        city c;
                        Console.WriteLine("*Input city infomation");                        
                        Console.Write("** Name: ");
                        c.name = Convert.ToString(Console.ReadLine());
                        Console.Write("** Inhabitants: ");
                        c.inhabitants = Convert.ToUInt32(Console.ReadLine());
                        cityArray[CurrentIndex] = c;
                        CurrentIndex++;
                        break;

                    case (2):
                        for(int p = 0; p < CurrentIndex; p++)
                        {
                            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                            Console.Write("Index: {0}", p);
                            Console.WriteLine();
                            Console.Write("Name: {0}",cityArray[0].name);
                            Console.WriteLine();
                            Console.Write("Inhabitants: {0}", cityArray[0].inhabitants);
                        }
                        break;

                    case (3):
                        break;
                    case (4):
                        break;
                    case (5):
                        break;
                }

            }



        }
        public void ArrayOfStruct()
        {
            /*
             * Expand the previous exercise (struct point), so that up to 1.000 points can be stored, using an "array of struct". 
             * Ask the user for data for the first two points and then display them. */

            Console.WriteLine("How many point do you want?");
            int totalPoint = Convert.ToInt16(Console.ReadLine());

            TwoDPoint[] PointArray = new TwoDPoint[totalPoint];
            for(int i = 0 ;  i < PointArray.Length; i++)
            {
                TwoDPoint point;
                Console.Write("Input x: ");
                point.x = short.Parse(Console.ReadLine());
                Console.Write("Input y: ");
                point.y = short.Parse(Console.ReadLine());

                PointArray[i] = point;
            }

            foreach(TwoDPoint point in PointArray)
            {
                Console.WriteLine("==================================");
                Console.WriteLine("* X = {0}", point.x);
                Console.WriteLine("* Y = {0}", point.y);
            }
        }

        public void DataTwoPoint()
        {
            /* Create a "struct" to store data of 2D points. The fields for each point will be: 
                x coordinate (short) 
                y coordinate (short) 
            Write a program which creates two "points", asks the user for their data, and then displays their content. */
            Console.WriteLine("=========================================");
            Console.WriteLine("Create First Point");
            TwoDPoint firstPoint;
            Console.Write("* x: ");
            firstPoint.x = short.Parse(Console.ReadLine());
            Console.Write("* y: ");
            firstPoint.y = short.Parse(Console.ReadLine());

            Console.WriteLine("=========================================");
            Console.WriteLine("Create Second Point");
            TwoDPoint secondPoint;
            Console.Write("* x: ");
            secondPoint.x = short.Parse(Console.ReadLine());
            Console.Write("* y: ");
            secondPoint.y = short.Parse(Console.ReadLine());

            // Print 

            Console.WriteLine("=========================================");
            Console.Write("* X = {0}, ", firstPoint.x);
            Console.Write("* Y = {0}, ", firstPoint.y);
            Console.WriteLine();
        }
    }
}