using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class Student
    {
        public int id;
        public string name;
        public double mark;

        

        static void Main(string[] args)
        {
            Student s = new Student();
            s.id = 101;
            s.name = "Pradnya";
            s.mark = 89.00;
            Console.WriteLine(s.id + "" + s.name + "" + s.mark);
        }
    }
}
