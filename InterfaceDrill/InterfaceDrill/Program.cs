﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDrill
{
    class Program
    {
        static void Main(string[] args)
        {//3.Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
         //Hint: an object can be of an interface type if it implements that specific interface.
            IQuittable quittable = new Employee();

            void Quit(Employee employee)
            {
                
            }
        }
    }
}
