using System;


namespace ClassDrill
{
    class Program
    {
        static void Main(string[] args)
        {
          

            //2. In the Main() program, ask the user what number they want to do the math operations on.

            Console.WriteLine("Choose a number and I will add, multiply, & divide it by 2.");
            int input = Convert.ToInt32(Console.ReadLine());


            //3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.

            Class1 x = new Class1();
            int a = x.functionOne(input, 2);
            int b = x.functionTwo(input, 2);
            int c = x.functionThree(input, 2);

            Console.WriteLine("Your number added, multiplied, & divided by 2 is " + a + ", " + b + ", " + c + ".");
            Console.ReadLine();
        }


    }
}