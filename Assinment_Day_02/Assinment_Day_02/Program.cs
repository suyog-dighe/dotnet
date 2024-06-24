using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Get Daylight Saving Information");
            Console.WriteLine("2) Create a Gray Code");
            Console.WriteLine("3) Convert Celsius to Fahrenheit");
            Console.WriteLine("4) Get IP Address");
            Console.WriteLine("5) Implement PhoneBook");
            Console.WriteLine("6) Create a Stop Watch");
            Console.WriteLine("7) Generate the Marksheet of the Student");
            Console.WriteLine("8) Convert Meter to Kilometer and Viceversa");
            Console.WriteLine("9) Display Squarefeet of a House");
            Console.WriteLine("10) Convert Infix to Postfix");
            Console.WriteLine("11) Exit");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    GetDaylightSavingInformation();
                    Console.WriteLine();
                    break;
                case 2:
                    CreateGrayCode();
                    Console.WriteLine();
                    break;
                case 3:
                    ConvertCelsiusToFahrenheit();
                    Console.WriteLine();
                    break;
                case 4:
                    GetIPAddress();
                    Console.WriteLine();
                    break;
                case 5:
                    ImplementPhoneBook();
                    Console.WriteLine();
                    break;
                case 6:
                    CreateStopWatch();
                    Console.WriteLine();
                    break;
                case 7:
                    GenerateMarksheet();
                    Console.WriteLine();
                    break;
                case 8:
                    ConvertMeterToKilometer();
                    Console.WriteLine();
                    break;
                case 9:
                    DisplaySquarefeetOfHouse();
                    Console.WriteLine();
                    break;
                case 10:
                    ConvertInfixToPostfix();
                    Console.WriteLine();
                    break;
                case 11:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }

    static void GetDaylightSavingInformation()
    {
        TimeZoneInfo localZone = TimeZoneInfo.Local;
        Console.WriteLine($"Daylight saving time observed: {localZone.SupportsDaylightSavingTime}");
        if (localZone.SupportsDaylightSavingTime)
        {
            TimeSpan delta = localZone.GetAdjustmentRules()[0].DaylightDelta;
            Console.WriteLine($"Daylight saving time delta: {delta}");
        }
        Console.WriteLine();
    }

    static void CreateGrayCode()
    {
        Console.Write("Enter the number of bits: ");
        int n = int.Parse(Console.ReadLine());
        List<string> grayCodes = GenerateGrayCode(n);
        Console.WriteLine("Gray codes:");
        foreach (string code in grayCodes)
        {
            Console.WriteLine(code);
        }
        Console.WriteLine();
    }

    static List<string> GenerateGrayCode(int n)
    {
        if (n <= 0)
            return new List<string> { "0" };
        if (n == 1)
            return new List<string> { "0", "1" };

        List<string> prevGrayCode = GenerateGrayCode(n - 1);
        List<string> result = new List<string>();

        foreach (string code in prevGrayCode)
        {
            result.Add("0" + code);
        }
        for (int i = prevGrayCode.Count - 1; i >= 0; i--)
        {
            result.Add("1" + prevGrayCode[i]);
        }
        Console.WriteLine();

        return result;
    }

    static void ConvertCelsiusToFahrenheit()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"Temperature in Fahrenheit: {fahrenheit}");
        Console.WriteLine();
    }

    static void GetIPAddress()
    {
        string hostName = Dns.GetHostName();
        IPAddress[] addresses = Dns.GetHostAddresses(hostName);
        foreach (IPAddress address in addresses)
        {
            if (address.AddressFamily == AddressFamily.InterNetwork)
            {
                Console.WriteLine($"IP Address: {address}");
            }
        }
        Console.WriteLine();
    }

    static void ImplementPhoneBook()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        while (true)
        {
            Console.WriteLine("1) Add contact");
            Console.WriteLine("2) Display contacts");
            Console.WriteLine("3) Exit phonebook");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter phone number: ");
                    string phone = Console.ReadLine();
                    phoneBook[name] = phone;
                    break;
                case 2:
                    foreach (var contact in phoneBook)
                    {
                        Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
                    }
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
        Console.WriteLine();
    }

    static void CreateStopWatch()
    {
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Press 's' to start, 'e' to stop, and 'r' to reset the stopwatch:");

        while (true)
        {
            char command = Console.ReadKey().KeyChar;
            if (command == 's')
            {
                stopwatch.Start();
                Console.WriteLine("\nStopwatch started.");
            }
            else if (command == 'e')
            {
                stopwatch.Stop();
                Console.WriteLine($"\nElapsed time: {stopwatch.Elapsed}");
            }
            else if (command == 'r')
            {
                stopwatch.Reset();
                Console.WriteLine("\nStopwatch reset.");
            }
            else
            {
                break;
            }
        }
        Console.WriteLine();
    }

    static void GenerateMarksheet()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter marks for subject 1: ");
        int marks1 = int.Parse(Console.ReadLine());
        Console.Write("Enter marks for subject 2: ");
        int marks2 = int.Parse(Console.ReadLine());
        Console.Write("Enter marks for subject 3: ");
        int marks3 = int.Parse(Console.ReadLine());

        int total = marks1 + marks2 + marks3;
        double average = total / 3.0;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Total Marks: {total}");
        Console.WriteLine($"Average Marks: {average}");
        Console.WriteLine();
    }

    static void ConvertMeterToKilometer()
    {
        Console.WriteLine("1) Convert Meter to Kilometer");
        Console.WriteLine("2) Convert Kilometer to Meter");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter meters: ");
                double meters = double.Parse(Console.ReadLine());
                double kilometers = meters / 1000;
                Console.WriteLine($"{meters} meters = {kilometers} kilometers");
                break;
            case 2:
                Console.Write("Enter kilometers: ");
                double kms = double.Parse(Console.ReadLine());
                double mtrs = kms * 1000;
                Console.WriteLine($"{kms} kilometers = {mtrs} meters");
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        Console.WriteLine();
    }

    static void DisplaySquarefeetOfHouse()
    {
        Console.Write("Enter the length of the house (in feet): ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter the width of the house (in feet): ");
        double width = double.Parse(Console.ReadLine());
        double area = length * width;
        Console.WriteLine($"The area of the house is {area} square feet.");
        Console.WriteLine();
    }

    static void ConvertInfixToPostfix()
    {
        Console.Write("Enter infix expression: ");
        string infix = Console.ReadLine();
        string postfix = InfixToPostfix(infix);
        Console.WriteLine($"Postfix expression: {postfix}");
        Console.WriteLine();
    }

    static string InfixToPostfix(string infix)
    {
        Stack<char> stack = new Stack<char>();
        string postfix = "";

        foreach (char ch in infix)
        {
            if (char.IsLetterOrDigit(ch))
            {
                postfix += ch;
            }
            else if (ch == '(')
            {
                stack.Push(ch);
            }
            else if (ch == ')')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    postfix += stack.Pop();
                }
                stack.Pop();
            }
            else
            {
                while (stack.Count > 0 && Precedence(ch) <= Precedence(stack.Peek()))
                {
                    postfix += stack.Pop();
                }
                stack.Push(ch);
            }
        }

        while (stack.Count > 0)
        {
            postfix += stack.Pop();
        }
        Console.WriteLine();

        return postfix;
    }

    static int Precedence(char ch)
    {
        switch (ch)
        {
            case '+':
            case '-':
                return 1;
            case '*':
            case '/':
                return 2;
            case '^':
                return 3;
            default:
                return 0;
        }
        Console.WriteLine();
    }
    
}
