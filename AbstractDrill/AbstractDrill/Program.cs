using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDrill
{
    class Program
    {
        static void Main()
        {
            //5. Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". Call the SayName() method on the object.

            Employee e = new Employee()
            {
                firstName = "Sample",
                lastName = "Student",
            };
           
           
           
            e.SayName();

        }
    }
}
