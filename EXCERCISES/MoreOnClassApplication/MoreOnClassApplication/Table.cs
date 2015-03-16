using System;

namespace MoreOnClassApplication
{
    class Table
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Table(double w, double h)
        {
            width = w;
            height = h;
        }

        public virtual void ShowData()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("Width = {0}", width);
            Console.WriteLine("Height = {0}", height);
        }

    }

    class CoffeeTable : Table
    {
        public CoffeeTable(double w, double h) : base(w, h)
        {

        }
        public override void ShowData()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("Coffee Table");
            Console.WriteLine("Width = {0}", Width);
            Console.WriteLine("Height = {0}", Height);
        }
    }
}
