using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q21
{
    internal class Employe
    {

        public int ID;
        public string Name;
        public string dep;
        public double salary;


       public Employe()
        {
            ID = 10101;
            Name = "Talha";
            dep = "Computer science";
            salary = 172827.09;

        }

        public void display()
        {
            Console.WriteLine("The id of employee is : {0}", ID);
            Console.WriteLine("The name of employee is : {0}", Name);
            Console.WriteLine("The department of employee is : {0}", dep);
            Console.WriteLine("The salary of employee is : {0}", salary);
        }

        public void incslary(double amount)
        {
            salary = salary + amount;
            Console.WriteLine("The salary after bonus is:  {0}",salary);

        }


    }
}
