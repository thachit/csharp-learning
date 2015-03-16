using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnClassApplication
{
    class Door
    {
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public void ShowData()
        {
            Console.WriteLine("I am a door, my color is {0}", color);
        }
    }
    class House
    {
        private double _area;
        private Door _door;

        public double Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public Door Door
        {
            get { return _door; }
            set { _door = value; }
        }

        public House(double a)
        {
            _area = a;
        }

        public void ShowData()
        {
            Console.WriteLine("I am a house, my area is {0} m2", _area);
        }
    }
    class SmallApartment : House
    {
        public SmallApartment() : base(50)
        {
        }
    }

    class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        SmallApartment _smallhouse;

        public SmallApartment SmallHouse
        {
            get { return _smallhouse; }
            set { _smallhouse = value; }
        }

        public void ShowData()
        {
            Console.WriteLine("My name is {0}, my houses area is {1} m2, its door is {2}", _name, _smallhouse.Area, _smallhouse.Door.Color);
        }
      
    }
}
