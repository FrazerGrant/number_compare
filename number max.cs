using System;


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            string input2;
            int number1;
            int number2;
            int a;
            int b;
            Console.WriteLine("Please enter a first number");
            input1 = Console.ReadLine();
            Console.WriteLine("Please enter a second number");
            input2 = Console.ReadLine();
            if (int.TryParse(input1, out number1))
            {
                Console.WriteLine(string.Format("{0} is valid number", number1));
                a = 1;
            }
            else
            {
                Console.WriteLine(string.Format("{0} is not a number", input1));
                a = 0;
            }

            if (Int32.TryParse(input2, out number2))
            {
                Console.WriteLine(string.Format("{0} is valid number", number2));
                b = 1;
            }
            else
            {
                Console.WriteLine(string.Format("{0} is not a number", input2));
                b = 0;
            }

            if (a == 1 && b == 1)
            {
                if (number1 > number2)
                {
                    Console.WriteLine(string.Format("{0} is greater than {1}", number1, number2));
                }
                else if (number2 > number1)
                {
                    Console.WriteLine(string.Format("{0} is greater than {1}", number2, number1));
                }
                else
                {
                    Console.WriteLine(string.Format("{0} is the same as {1}", number1, number2));
                }
            }
            else
            {
                Console.WriteLine(string.Format("Cannot compare values {0} {1}", input1, input2));

            }
            Console.ReadKey();

        }
    }
}
