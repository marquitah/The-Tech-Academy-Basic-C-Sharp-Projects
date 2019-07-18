using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDrill2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class and call the one method, passing in an integer, such as 12. Then display the result to the screen.

            Class1 math1 = new Class1();
            math1.mathOne(12);



            //4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.

            Class1 math2 = new Class1();
            math2.mathOne(20.5m);


            //6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. 
            //Display the result to the screen.

            Class1 math3 = new Class1();
            math3.mathOne("10");

        }
    }
}
