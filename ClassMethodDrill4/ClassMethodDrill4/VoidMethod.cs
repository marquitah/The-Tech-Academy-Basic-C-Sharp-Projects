using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDrill4
{
    class VoidMethod
    {
        //1. Create a class. In that class, create a void method that outputs an integer. Have the method divide the data passed to it by 2.

        public void voidMethod(out int output, int b)
        {
            output =  b / 2;
        }


        //4. Create a method with output parameters.

        public int outputParameters(out int x, out int y)
        {
            x = 10;
            y = 4;
            return x + y;
        }

        //5. Overload a method.

        public int outputParameters(int x = 5, int y = 20, int z = 100)
        {
            int sum = x + y + z;
            return sum;
        }
    }
}
