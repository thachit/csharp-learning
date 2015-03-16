using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProgramming
{
    class Teacher : People
    {
        string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        public void Explain()
        {
            Console.WriteLine("Beginning Explain {0}", subject);
        }
    }
}
