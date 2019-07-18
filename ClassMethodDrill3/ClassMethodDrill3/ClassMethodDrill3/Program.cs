using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.

            TwoParameters twoParameters = new TwoParameters();


            //4. Call the method in the class, passing in the one or two numbers entered.

           
            twoParameters.parametersTwo(a: 0);

            //5. Try various combinations of numbers on the code, including having no second number.
            //input 1st number: 5, input 2nd number: 3, output: 8
            //input 1st number: 8, input 2nd number: (blank), output: 8

        }
    }
}
