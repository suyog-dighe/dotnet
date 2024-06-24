using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("11) Demonstrate Multilevel Inheritance with Virtual Methods");
            Console.WriteLine("12) Implement Delegates");
            Console.WriteLine("13) Traverse the Singly Linked List");
            Console.WriteLine("14) Sort a List of Names in Alphabetical Order");
            Console.WriteLine("15) Find the Smallest Element in a Matrix");
            Console.WriteLine("16) Find the Largest Element in a Matrix");
            Console.WriteLine("17) Demonstrate Jagged Arrays");
            Console.WriteLine("18) Calculate Distance, Speed and Time");
            Console.WriteLine("19) Find Simple Interest");
            Console.WriteLine("20) Convert Digits to Words");
            Console.WriteLine("21) Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 11:
                    DemonstrateMultilevelInheritance();
                    break;
                case 12:
                    ImplementDelegates();
                    break;
                case 13:
                    TraverseSinglyLinkedList();
                    break;
                case 14:
                    SortNamesAlphabetically();
                    break;
                case 15:
                    FindSmallestElementInMatrix();
                    break;
                case 16:
                    FindLargestElementInMatrix();
                    break;
                case 17:
                    DemonstrateJaggedArrays();
                    break;
                case 18:
                    CalculateDistanceSpeedTime();
                    break;
                case 19:
                    FindSimpleInterest();
                    break;
                case 20:
                    ConvertDigitsToWords();
                    break;
                case 21:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }

    static void DemonstrateMultilevelInheritance()
    {
        Puppy puppy = new Puppy();
        puppy.Sound();
    }

    delegate void DisplayMessage(string message);

    static void ImplementDelegates()
    {
        void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        DisplayMessage del = ShowMessage;
        del("Hello, this is a delegate demonstration!");
    }

    class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    static void TraverseSinglyLinkedList()
    {
        Node head = new Node(1);
        head.Next = new Node(2);
        head.Next.Next = new Node(3);

        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }

    static void SortNamesAlphabetically()
    {
        List<string> names = new List<string>
        {
            "Alice",
            "Charlie",
            "Bob"
        };

        names.Sort();

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    static void FindSmallestElementInMatrix()
    {
        int[,] matrix = {
            { 3, 8, 9 },
            { 1, 5, 7 },
            { 4, 2, 6 }
        };

        int smallest = matrix[0, 0];
        foreach (int element in matrix)
        {
            if (element < smallest)
            {
                smallest = element;
            }
        }

        Console.WriteLine($"The smallest element in the matrix is {smallest}");
    }

    static void FindLargestElementInMatrix()
    {
        int[,] matrix = {
            { 3, 8, 9 },
            { 1, 5, 7 },
            { 4, 2, 6 }
        };

        int largest = matrix[0, 0];
        foreach (int element in matrix)
        {
            if (element > largest)
            {
                largest = element;
            }
        }

        Console.WriteLine($"The largest element in the matrix is {largest}");
    }

    static void DemonstrateJaggedArrays()
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void CalculateDistanceSpeedTime()
    {
        Console.WriteLine("Calculate Distance, Speed, and Time");
        Console.WriteLine("1) Distance");
        Console.WriteLine("2) Speed");
        Console.WriteLine("3) Time");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter speed (m/s): ");
                double speed = double.Parse(Console.ReadLine());
                Console.Write("Enter time (s): ");
                double time = double.Parse(Console.ReadLine());
                double distance = speed * time;
                Console.WriteLine($"Distance: {distance} meters");
                break;
            case 2:
                Console.Write("Enter distance (m): ");
                double distanceForSpeed = double.Parse(Console.ReadLine());
                Console.Write("Enter time (s): ");
                double timeForSpeed = double.Parse(Console.ReadLine());
                double speedCalculated = distanceForSpeed / timeForSpeed;
                Console.WriteLine($"Speed: {speedCalculated} m/s");
                break;
            case 3:
                Console.Write("Enter distance (m): ");
                double distanceForTime = double.Parse(Console.ReadLine());
                Console.Write("Enter speed (m/s): ");
                double speedForTime = double.Parse(Console.ReadLine());
                double timeCalculated = distanceForTime / speedForTime;
                Console.WriteLine($"Time: {timeCalculated} seconds");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void FindSimpleInterest()
    {
        Console.Write("Enter principal: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter rate of interest: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter time (years): ");
        double time = double.Parse(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"Simple Interest: {simpleInterest}");
    }

    static void ConvertDigitsToWords()
    {
        string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        Console.Write("Enter a number: ");
        string number = Console.ReadLine();

        foreach (char digit in number)
        {
            if (char.IsDigit(digit))
            {
                Console.Write(words[digit - '0'] + " ");
            }
            else
            {
                Console.Write("Invalid input.");
                return;
            }
        }
        Console.WriteLine();
    }

    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Puppy : Dog
    {
        public override void Sound()
        {
            Console.WriteLine("Puppy yips");
        }
    }
}
