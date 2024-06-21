// See https://aka.ms/new-console-template for more information
using System;
namespace Class_Program
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("hello suyog");
            Console.WriteLine("Enter the Number");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd  Number");
            int b= Convert.ToInt32(Console.ReadLine());
            int c = a;
            a = b;
            b = c;

            Console.WriteLine("1st Number : "+a);
            
            Console.WriteLine(" 2nd  Number : "+b);
          
            /*
            if
                (a % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }

            Console.ReadLine();
            */
        }
    }
}