using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AssignmentPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Sort a List of Names in Alphabetical Order");
                Console.WriteLine("2) Demonstrate Pass by Value");
                Console.WriteLine("3) Demonstrate Pass by Reference");
                Console.WriteLine("4) Illustrate Regular Expression Patterns");
                Console.WriteLine("5) Implement Namespaces");
                Console.WriteLine("6) Demonstrate the Difference between Value Type Parameter and Reference Type Parameter");
                Console.WriteLine("7) Demonstrate the Goto Statement");
                Console.WriteLine("8) Convert Upper case to Lower Case");
                Console.WriteLine("9) Convert Characters of a String to Opposite Case");
                Console.WriteLine("10) Find the Length of a String");
                Console.WriteLine("11) Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SortNamesAlphabetically();
                        break;
                    case 2:
                        DemonstratePassByValue();
                        break;
                    case 3:
                        DemonstratePassByReference();
                        break;
                    case 4:
                        IllustrateRegularExpressions();
                        break;
                    case 5:
                        ImplementNamespaces();
                        break;
                    case 6:
                        DemonstrateValueTypeVsReferenceType();
                        break;
                    case 7:
                        DemonstrateGotoStatement();
                        break;
                    case 8:
                        ConvertUpperCaseToLowerCase();
                        break;
                    case 9:
                        ConvertCharactersToOppositeCase();
                        break;
                    case 10:
                        FindStringLength();
                        break;
                    case 11:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please choose again.");
                        break;
                }
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

            Console.WriteLine("Sorted Names:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void DemonstratePassByValue()
        {
            int number = 10;
            Console.WriteLine($"Before PassByValue: {number}");
            PassByValue(number);
            Console.WriteLine($"After PassByValue: {number}");
        }

        static void PassByValue(int num)
        {
            num = 20;
        }

        static void DemonstratePassByReference()
        {
            int number = 10;
            Console.WriteLine($"Before PassByReference: {number}");
            PassByReference(ref number);
            Console.WriteLine($"After PassByReference: {number}");
        }

        static void PassByReference(ref int num)
        {
            num = 20;
        }

        static void IllustrateRegularExpressions()
        {
            string pattern = @"\d+";
            string input = "There are 123 apples and 456 oranges.";
            MatchCollection matches = Regex.Matches(input, pattern);

            Console.WriteLine("Matches found:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        static void ImplementNamespaces()
        {
            Console.WriteLine("This program demonstrates namespaces.");
            Console.WriteLine("This entire program is under the 'AssignmentPrograms' namespace.");
        }

        static void DemonstrateValueTypeVsReferenceType()
        {
            int valueType = 10;
            int[] referenceType = { 10 };

            Console.WriteLine($"Before: ValueType = {valueType}, ReferenceType[0] = {referenceType[0]}");

            ModifyValueType(valueType);
            ModifyReferenceType(referenceType);

            Console.WriteLine($"After: ValueType = {valueType}, ReferenceType[0] = {referenceType[0]}");
        }

        static void ModifyValueType(int value)
        {
            value = 20;
        }

        static void ModifyReferenceType(int[] reference)
        {
            reference[0] = 20;
        }

        static void DemonstrateGotoStatement()
        {
            int counter = 0;

        start:
            Console.WriteLine($"Counter: {counter}");
            counter++;

            if (counter < 5)
            {
                goto start;
            }
        }

        static void ConvertUpperCaseToLowerCase()
        {
            Console.Write("Enter a string in uppercase: ");
            string input = Console.ReadLine();
            string result = input.ToLower();
            Console.WriteLine($"Lowercase: {result}");
        }

        static void ConvertCharactersToOppositeCase()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            char[] result = input.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                if (char.IsUpper(result[i]))
                {
                    result[i] = char.ToLower(result[i]);
                }
                else if (char.IsLower(result[i]))
                {
                    result[i] = char.ToUpper(result[i]);
                }
            }

            Console.WriteLine($"Converted String: {new string(result)}");
        }

        static void FindStringLength()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int length = input.Length;
            Console.WriteLine($"Length of the string: {length}");
        }
    }
}
