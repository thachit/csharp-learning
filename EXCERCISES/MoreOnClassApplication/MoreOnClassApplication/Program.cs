using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnClassApplication
{
    class Program
    {
        public void HouseClass()
        {
            Door d = new Door();
            d.Color = "Brown";

            SmallApartment sm = new SmallApartment();
            sm.Door = d;

            Person p = new Person();
            p.Name = "Thach";
            p.SmallHouse = sm;
            p.ShowData();

            Console.WriteLine(p.Name);
            Console.WriteLine(p.SmallHouse.Area);
            Console.WriteLine(p.SmallHouse.Door.Color);

        }

        public void TableClass()
        {
            
            /*
             * Create a class named "Table". It must have a constructor, indicating the width and height of the board. 
             * It will have a method "ShowData" which will write on the screen the width and that height of the table. 
             * Create an array containing 10 tables, with random sizes between 50 and 200 cm, and display all the data. 
             */
            Random rnd = new Random();
            Table[] tableArray = new Table[5];
            for(int i = 0; i< tableArray.Length; i++)
            {
                Table table = new Table(rnd.Next(50,200), rnd.Next(50, 200));
                tableArray[i] = table;
            }

            foreach(Table tab in tableArray)
            {
                tab.ShowData();
            }

            /*
             * Create an array that contains 5 tables and 5 coffee tables. 
             * The tables must have random sizes between 50 and 200 cm, and the coffee tables from 40 to 120 cm. 
             * Show all their data. 
             */

            Table[] tableCoffeArray = new Table[5];
            for (int i = 0; i < tableCoffeArray.Length; i++)
            {
                CoffeeTable table = new CoffeeTable(rnd.Next(40, 120), rnd.Next(40, 120));
                tableCoffeArray[i] = table;
            }

            foreach (CoffeeTable tab in tableCoffeArray)
            {
                tab.ShowData();
            }
        }

        public void EncrypterClass()
        {
            string eText = Encrypter.Encrypt("Hola");
            Console.WriteLine(eText);
            string dText = Encrypter.Decrypt(eText);
            Console.WriteLine(dText);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            // p.TableClass();
            // p.HouseClass();
            p.EncrypterClass();
            Console.ReadLine();
        }
    }
}
