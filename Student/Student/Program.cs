using System;
using System.Collections.Generic;

namespace Student
{
    class Student
    {
        public int Roll;
        public string Name;
        public string Branch;
        public string Semester;
        public string College;
    }

    class Program
    {
        static void Main(string[] args)
        {

            GstBill bill = new GstBill();
            bill.CalculateAndDisplayBill();

            /*
            ATMDisplay atmDisplay = new ATMDisplay(1000); // Initial balance set to 1000

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\nWelcome to the ATM!");
                atmDisplay.DisplayOptions();
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        atmDisplay.CheckBalance();
                        break;
                    case 2:
                        Console.Write("Enter deposit amount: ");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        atmDisplay.CashDeposit(depositAmount);
                        break;
                    case 3:
                        Console.Write("Enter withdrawal amount: ");
                        decimal withdrawAmount = decimal.Parse(Console.ReadLine());
                        atmDisplay.CashWithdraw(withdrawAmount);
                        break;
                    case 4:
                        isRunning = false;
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            */

            /*
            Console.WriteLine("Enter the number of records you want to print:");
            int recordCount = Convert.ToInt32(Console.ReadLine());

            Student[] students = new Student[recordCount];

            for (int i = 0; i < recordCount; i++)
            {
                students[i] = new Student();

                Console.WriteLine($"Enter details for student {i + 1}:");

                Console.Write("Enter your Roll no: ");
                students[i].Roll = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your Name: ");
                students[i].Name = Console.ReadLine();

                Console.Write("Enter your Branch: ");
                students[i].Branch = Console.ReadLine();

                Console.Write("Enter your Semester: ");
                students[i].Semester = Console.ReadLine();

                Console.Write("Enter your College: ");
                students[i].College = Console.ReadLine();
            }

            PrintStudentRecords(students);
        }

        static void PrintStudentRecords(Student[] students)
        {
            Console.WriteLine("\nRoll\tName\t\tBranch\t\tSemester\tCollege");
            Console.WriteLine("---------------------------------------------------------------");

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Roll}\t{student.Name}\t\t{student.Branch}\t\t{student.Semester}\t\t{student.College}");
            }
            */
        }

    }
}
