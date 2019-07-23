using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEmployeeDrill
{
    class Program : Properties
    {
        static void Main(string[] args)
        {//1. In the Main() method, create a list of at least 10 employees. 
         //Each employee should have a first and last name, as well as an Id. 
         //At least two employees should have the first name "Joe".

            var Employees = new List<Properties>();
            Employees.Add(new Properties { firstName = "Joe", lastName = "Baxter", idNumber = 1 });
            Employees.Add(new Properties { firstName = "Joe", lastName = "Smith", idNumber = 2 });
            Employees.Add(new Properties { firstName = "Ryan", lastName = "Green", idNumber = 3 });
            Employees.Add(new Properties { firstName = "Krystyna", lastName = "Hutchinson", idNumber = 4 });
            Employees.Add(new Properties { firstName = "Alaina", lastName = "Youngberg", idNumber = 5 });
            Employees.Add(new Properties { firstName = "Mason", lastName = "Cowboy", idNumber = 6 });
            Employees.Add(new Properties { firstName = "Cooper", lastName = "Youngberg", idNumber = 7 });
            Employees.Add(new Properties { firstName = "Tyrel", lastName = "Hartman", idNumber = 8 });
            Employees.Add(new Properties { firstName = "Alexa", lastName = "Amazon", idNumber = 9 });
            Employees.Add(new Properties { firstName = "Riley", lastName = "Hartman", idNumber = 10 });



            //2. Using a foreach loop, create a new list of all employees with the first name "Joe".

            foreach (var Joe in Employees)
            {
                if (Joe.firstName == "Joe")
                {
                    Console.WriteLine(Joe.firstName);
                    Console.ReadLine();
                }
            }

            //3. Do the same thing again, but this time with a lambda expression.

            List<Properties> Joes = Employees.Where(x => x.firstName == "Joe").ToList();
            foreach (var joe in Joes)
            {
                Console.WriteLine(joe.firstName);
                Console.ReadLine();
            }

            //4. Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Properties> moreThanFive = Employees.Where(x => x.idNumber > 5).ToList();
            foreach (var morethanFive in moreThanFive)
            {
                Console.WriteLine(morethanFive.firstName + " " + morethanFive.lastName + " " + morethanFive.idNumber);
                Console.ReadLine();
            }

        }
    }
}



       

