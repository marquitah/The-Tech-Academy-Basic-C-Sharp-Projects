using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadOperatorDrill
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
        public static bool operator ==(Employee employeeOne, Employee employeeTwo)
        {
            return (employeeOne.Id == employeeTwo.Id);
        }
        public static bool operator !=(Employee employeeOne, Employee employeeTwo)
        {
            return !(employeeOne.Id == employeeTwo.Id);
        }
        
       
    }
   
}
