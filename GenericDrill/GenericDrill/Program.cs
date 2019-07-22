using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Instantiate an Employee object with type "string" as 
            //its generic parameter. Assign a list of strings as the property value of Things.

            Employee<string> employee = new Employee<string>();
            {
                employee.Things.Add("boat");
                employee.Things.Add("car");
                employee.Things.Add("house");

            }
            //4. Instantiate an Employee object with type "int" as its generic parameter. 
            //Assign a list of integers as the property value of Things.

            Employee<int> employee1 = new Employee<int>();
            {
                employee1.Things.Add(10);
                employee1.Things.Add(32);
                employee1.Things.Add(94);
            }
            //5. Create a loop that prints all of the Things to the Console.
            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
                Console.ReadLine();
            }
            foreach (int things in employee1.Things)
            {
                Console.WriteLine(things);
                Console.ReadLine();
            }


            
          
           
        }
    }
}