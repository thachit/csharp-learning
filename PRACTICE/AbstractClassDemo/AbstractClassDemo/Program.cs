using System;

namespace AbstractClassDemo
{
    abstract class Iphone // Definition of an Abtract Class
    { 
        public void Call()
        {
            Console.WriteLine("Call method: This method provides Calling Features");
        }

        public abstract void Model();
    } 

    class Iphone5s : Iphone
    {
        public override void Model()
        {
            Console.WriteLine("Model: Iphone 5s");
        }

        public void LaunchDate()
        {
            Console.WriteLine("Launch Date: Iphone 5s");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Iphone5s iphone5s = new Iphone5s();
            iphone5s.Call();
            iphone5s.Model();
            Console.ReadKey();
        }
    }
}
