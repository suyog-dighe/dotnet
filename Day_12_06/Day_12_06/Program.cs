using System;
namespace Day_12_06
{
    class Program
    {
        static int fact(int x)
        {
            if (x == 0) return 0;
            if (x == 1) return 1;

            return x * fact(x - 1);


        }

        static float areaoftraingle(int base1, int height)
        {
            return (1f / 2f) * base1 * height;
        }

        static int area_of_reactangle(int length, int breadth)
        {
            return (length * breadth);
        }

        static int area_of_polygon(int n, int l, int r)
        {
            return (n / 2) * l * r;
        }

        // Fibonacci series
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void dateTime()
        {
            // Get the current date and time
            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date and Time: " + now.ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base/length value ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height/breadth value ");
            int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(areaoftraingle(a,b));
            dateTime();
            Console.WriteLine("area of reactangle " + area_of_reactangle(a, b));
            Console.WriteLine("area of polygon " + area_of_polygon(5, 3, 4));
            Student.display();
            //Console.WriteLine(fact(a));


            /*
             // Swaping of two numbers

             Console.WriteLine("Enter the first number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b = int.Parse(Console.ReadLine());

            // Swapping using a temporary variable
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"After swap: a = {a}, b = {b}");

            */
            //====================================================================
            /*
             // fibonacci series

             Console.WriteLine("Enter the number of terms:");
            int terms = int.Parse(Console.ReadLine());

            Console.WriteLine("Fibonacci Series:");
            for (int i = 0; i < terms; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
             */
            //=======================================================================

            /*
             // pattern program 

             Console.WriteLine("Enter the number of rows:");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            } 
             */

            // AREA OF TRIANGLE

        }
    }
}