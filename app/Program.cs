// // See https://aka.ms/new-console-template for more information
// using System;
// namespace Class_Program
// {
//     class Program
//     {
//         static void Main(String[] args)
//         {
//             Console.WriteLine("hello suyog");
//             Console.WriteLine("Enter the Number");
//             int a= Convert.ToInt32(Console.ReadLine());
//             Console.WriteLine("Enter the 2nd  Number");
//             int b= Convert.ToInt32(Console.ReadLine());
//             int c = a;
//             a = b;
//             b = c;

//             Console.WriteLine("1st Number : "+a);
            
//             Console.WriteLine(" 2nd  Number : "+b);
          
//             /*
//             if
//                 (a % 2 == 0)
//             {
//                 Console.WriteLine("even number");
//             }
//             else
//             {
//                 Console.WriteLine("odd number");
//             }

//             Console.ReadLine();
//             */
//         }
//     }
// }

using System;

namespace hello
{
    class Program
    {
        public int addition(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            if (a < b)
            {
                return b - a;
            }
            else
            {
                return a - b;
            }
        }

        public int multi(int a, int b)
        {
            return a * b;
        }

        public int div(int a, int b)
        {
            if (b == 0) // Adding a check to prevent division by zero
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0; // Returning 0 or an appropriate value to indicate an error
            }
            else if (a < b)
            {
                return b / a;
            }
            else
            {
                return a / b;
            }
        }

        public int modulo(int a, int b)
        {
            return a % b;
        }

        static void Main(string[] args) 
        {
           

           

            int result = 0;
            Program p = new Program();
            int s;
            do
            {

                Console.WriteLine("Please enter two numbers:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your choice: ");
                Console.WriteLine("1. Addition \n2. Subtraction \n3. Multiplication \n4. Division \n5. Modulo \n6. Exit");
                int c = Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        result = p.addition(a, b);
                        break;

                    case 2:
                        result = p.sub(a, b);
                        break;

                    case 3:
                        result = p.multi(a, b);
                        break;

                    case 4:
                        result = p.div(a, b);
                        break;

                    case 5:
                        result = p.modulo(a, b);
                        break;

                    case 6:
                        break;

                    default:
                        Console.WriteLine("Wrong Choice");
                        return; // Exit th  `e Main method as the choice is invalid
                }

                Console.WriteLine("The result is: " + result);
                 Console.WriteLine("Do you want to continue press[1/0]");
                 s = Convert.ToInt32(Console.ReadLine());
            } while (s == 1);
        }
    }
}
