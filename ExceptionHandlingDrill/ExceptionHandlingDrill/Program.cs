using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDrill
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.

            //List<int> divideNumbers = new List<int>();
            //divideNumbers.Add(2);
            //divideNumbers.Add(4);
            //divideNumbers.Add(6);

            //Console.WriteLine("Enter a number and I will divide it by 2, 4, & 6.");
            //int input = Convert.ToInt32(Console.ReadLine());


            //foreach (int newNumber in divideNumbers)
            //{
            //    int output = newNumber / input;
            //    {
            //        Console.WriteLine("The answer is " + output + ".");
            //        Console.ReadLine();
            //    }
            //}


            //2. Run that code, entering in non-zero numbers as the user. Look at the displayed results.

            //Input: 2
            //Output:
            //The answer is 1.
            //The answer is 2.
            //The answer is 3.



            //3. Run that code, entering in zero as the number to divide by. Note any error messages you get.

            //VS gives an error: System.DivideByZeroException:'Attempted to divide by zero.'



            //4. Run that code, entering in a string as the number to divide by. Note any error messages you get.

            //Vs give an error: System.FormatException:'Input string was not in a correct format.'



            //5. Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program display a message to the display 
            //to let you know the program has emerged from the try/catch block and continued on with program execution. 
            //In the catch block, display the error message to the screen. 
            //Then try various combinations of user input: valid numbers, zero and a string. 
            //Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.

            //Input: 2 0 me
            //Output: Input string was not in a correct format.
            //Output: The program will continue..

            try
            {
                List<int> divideNumbers = new List<int>();
                divideNumbers.Add(2);
                divideNumbers.Add(4);
                divideNumbers.Add(6);

                Console.WriteLine("Enter a number and I will divide it by 2, 4, & 6.");
                int input = Convert.ToInt32(Console.ReadLine());


           
                foreach (int newNumber in divideNumbers)
                {
                    int output = newNumber / input;
                    {
                        Console.WriteLine("The answer is " + output + ".");
                        Console.ReadLine();
                    }
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("The program will continue..");
                Console.ReadLine();
            }
        }

    }
}
