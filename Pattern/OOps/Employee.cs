using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern.OOps
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;

        public void AcceptDetails(int eid, string ename, int sal)
        {
            id = eid;
            name = ename;
            salary = sal;
        }

        public void Display()
        {
            Console.WriteLine(id+""+name+""+salary);
        }

        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.AcceptDetails(1, "Shree", 90000);
            e.Display();

            Employee e1 = new Employee();
            e1.AcceptDetails(2, "veda", 70000);
            e1.Display();
        }
    }
}
