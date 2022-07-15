using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class Constructor
    {
        int x;
        public Constructor()                                 
        {
            Console.WriteLine("Default Constructor");
        }

        public Constructor(string str)
        {
            Console.WriteLine("Parameter=" + str);
        }

        static void Main(string[] args)
        {
            Constructor c = new Constructor();
            Console.WriteLine(c.x);

            Constructor c2 = new Constructor("Pune");
        }
    }
}
