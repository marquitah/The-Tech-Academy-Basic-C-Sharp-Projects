using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.

            Employee a = new Employee { id = 1, name = "employee1" };
            Employee b = new Employee { id = 1, name = "employee2" };

            if (a.id == b.id && a.name == b.name)
            {
                Console.WriteLine("This person equals that person.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("These are different people with same ID number.");
                Console.ReadLine();
            }

            
            

        }
    }
}
