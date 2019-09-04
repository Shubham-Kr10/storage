using System;

namespace Calculator3.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Shubham's Basic Calculator");
            Console.WriteLine("--------------------------------------");

        x:
            int first;
            int second;
            int output;
            string operation;
            string y = "";
            bool b;
            string ans;


            //x:
            //Console.ReadLine();
            Console.Write("Enter the first number : ");
            first = Convert.ToInt32(Console.ReadLine());



            Console.Write("Choose an operation to perform from x , / , +, - : ");
            operation = Console.ReadLine();

            Console.Write("Enter the second number : ");
            second = Convert.ToInt32(Console.ReadLine());

            // do
            // {
            if (operation == "x")
            {
              Mult(first,second);
            }
            else if (operation == "/")
            {
                //  output = first / second;
                //Console.WriteLine(first + " / " + second + " = " + output);
                //Console.ReadLine();
                Div(first, second);
            }

            else if (operation == "+")
            {
                // output = first + second;
                // Console.WriteLine(first + " + " + second + " = " + output);
                // Console.ReadLine();
                Add(first, second);
            }
            else if (operation == "-")
            {
                //  output = first - second;
                // Console.WriteLine(first + " - " + second + " = " + output);
                // Console.ReadLine();
                Sub(first, second);
            }
            else
            {
                Console.WriteLine("Wrong Choice!! Check the operator!!");
                Console.ReadLine();
            }

            Console.WriteLine("Press y to continue or press any other key to exit: ");
            ans = Console.ReadLine();
            // b= Convert.ToBoolean(Convert.ToInt32(y));
            if (ans == "y")
            {
                Console.ReadKey();
                goto x;
            }
            else
            {
                Console.ReadKey();
            }
            //} while (b);
        }



        private static int Mult(int first, int second)
        {
            int a = first;
            int b = second;
            int output;
            output = first * second;
           // Console.WriteLine(first + " x " + second + " = " + output);
            Console.WriteLine(a + " x " + b + " = " + output);
            return output;
            Console.ReadLine();
        }

        private static int Add(int first, int second)
        {
            int a = first;
            int b = second;
            int output;
            output = first + second;
            // Console.WriteLine(first + " x " + second + " = " + output);
            Console.WriteLine(a + " + " + b + " = " + output);
            return output;
            Console.ReadLine();
        }

        private static int Div(int first, int second)
        {
            int a = first;
            int b = second;
            int output;
            output = first / second;
            // Console.WriteLine(first + " x " + second + " = " + output);
            Console.WriteLine(a + " / " + b + " = " + output);
            return output;
            Console.ReadLine();
        }

        private static int Sub(int first, int second)
        {
            int a = first;
            int b = second;
            int output;
            output = first - second;
            // Console.WriteLine(first + " x " + second + " = " + output);
            Console.WriteLine(a + " - " + b + " = " + output);
            return output;
            Console.ReadLine();
        }

    }
}

