using System;

namespace Day_15_06
{
    class Program
    {
        public static void Addition(int[,] arr, int[,] arr1, int a, int b)
        {
            Console.WriteLine("Addition is:");
            int[,] add = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    add[i, j] = arr[i, j] + arr1[i, j];
                }
            }
            PrintMatrix(add, a, b);
        }

        public static void Subtraction(int[,] arr, int[,] arr1, int a, int b)
        {
            Console.WriteLine("Subtraction is:");
            int[,] sub = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    sub[i, j] = arr[i, j] - arr1[i, j];
                }
            }
            PrintMatrix(sub, a, b);
        }

        public static void Multiplication(int[,] arr, int[,] arr1, int a, int b)
        {
            Console.WriteLine("Multiplication is:");
            int[,] mul = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    mul[i, j] = arr[i, j] * arr1[i, j];
                }
            }
            PrintMatrix(mul, a, b);
        }

        public static void Division(int[,] arr, int[,] arr1, int a, int b)
        {
            Console.WriteLine("Division is:");
            int[,] div = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (arr1[i, j] == 0)
                    {
                        Console.Write("Inf "); // Handle division by zero
                    }
                    else
                    {
                        div[i, j] = arr[i, j] / arr1[i, j];
                        Console.Write(div[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Modulo(int[,] arr, int[,] arr1, int a, int b)
        {
            Console.WriteLine("Modulo is:");
            int[,] mod = new int[a, b];
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (arr1[i, j] == 0)
                    {
                        Console.Write("NaN "); // Handle modulo by zero
                    }
                    else
                    {
                        mod[i, j] = arr[i, j] % arr1[i, j];
                        Console.Write(mod[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int d;
            Console.WriteLine("Enter the number of rows:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns:");
            int b = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[a, b];
            int[,] arr1 = new int[a, b];

            Console.WriteLine("Enter the first matrix elements:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the second matrix elements:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            do
            {

                Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Modulo");
                Console.WriteLine("Enter your choice:");
                int c = Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        Addition(arr, arr1, a, b);
                        break;
                    case 2:
                        Subtraction(arr, arr1, a, b);
                        break;
                    case 3:
                        Multiplication(arr, arr1, a, b);
                        break;
                    case 4:
                        Division(arr, arr1, a, b);
                        break;
                    case 5:
                        Modulo(arr, arr1, a, b);
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
                Console.WriteLine("do you want to continue");
                 d = Convert.ToInt32(Console.ReadLine());

            } while (d == 1);
        

            /*
            Console.WriteLine("Enter the size   of the array");
            int a = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[a];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            */
        }
    }
}