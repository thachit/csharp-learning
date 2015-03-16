using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProgramming
{
    class Student : People
    {
        public void GoToClass()
        {
            Console.WriteLine("I 'm going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine("I 'am {0} years old", Age);
        }
            
    }
}
