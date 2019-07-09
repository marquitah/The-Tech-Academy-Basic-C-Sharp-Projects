using System;


namespace UserInputDrill
{
    class Program
    {
        static void Main()
        {
            //1. Takes an input from the user, multiplies it by 50, and prints the result to the console.

            string number;
            int output;
            Console.WriteLine("Enter a number & I'll multiply it by 50.");
            number = Console.ReadLine();
            int answer = Convert.ToInt32(number);

            output = answer * 50;

            Console.WriteLine("The answer is: " + output + "!");
            Console.ReadLine();




            //2. Takes an input from the user, adds 25 to it, and prints the result to the console.

            string input;
            int plus;
            Console.WriteLine("Enter a number & I'll add 25 to it.");
            input = Console.ReadLine();
            int newInput = Convert.ToInt32(input);

            plus = newInput + 25;

            Console.WriteLine("The answer is: " + plus + "!");
            Console.ReadLine();



            //3. Takes an input from the user, divides it by 12.5, and prints the result to the console.

            string enterNumber;
            double divided;
            Console.WriteLine("Enter a number & I'll divide it by 12.5.");
            enterNumber = Console.ReadLine();
            int newNumber = Convert.ToInt32(enterNumber);

            divided = newNumber / 12.5;

            Console.WriteLine("The answer is: " + divided + "!");
            Console.ReadLine();



            //4.Takes an input from the user, checks if it is greater than 50, and prints the true / false result to the console.

            string putInNumber;
            Console.WriteLine("Enter a number and I'll tell you if it's greater than 50.");
            putInNumber = Console.ReadLine();
            int newPutInNumber = Convert.ToInt32(putInNumber);

            if (newPutInNumber > 50)
            {
                Console.WriteLine("True");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }


            //5. Takes an input from the user, divides it by 7, and prints the remainder to the console

            string remainder;
            double remainderAnswer;
            Console.WriteLine("Enter a number & I'll divide it by 7 then give you the remainder.");
            remainder = Console.ReadLine();
            int newRemainder = Convert.ToInt32(remainder);

            remainderAnswer = newRemainder % 7;

            Console.WriteLine("The remainder is: " + remainderAnswer + "!");
            Console.ReadLine();
        }
    }
}
