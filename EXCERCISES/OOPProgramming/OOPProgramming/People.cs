using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProgramming
{
    class People
    {
        int age;

        public People()
        {
            Console.WriteLine("People say Hello");
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
