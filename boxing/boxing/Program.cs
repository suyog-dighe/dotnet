using System;

class Program
{
    static void Main()
    {
        /*
        // Example  of Boxing
        int valueType = 123;      // Value type
        object boxedValue = valueType;  // Boxing: Converting value type to object type

        Console.WriteLine("Boxing:");
        Console.WriteLine("Value type: " + valueType);
        Console.WriteLine("Boxed value: " + boxedValue);

        // Example of Unboxing
        object obj = 456;         // Boxed value
        int unboxedValue = (int)obj; // Unboxing: Converting object type back to value type

        Console.WriteLine("\nUnboxing:");
        Console.WriteLine("Object type: " + obj);
        Console.WriteLine("Unboxed value: " + unboxedValue);

        // Another example with double
        double doubleValue = 78.9; // Value type
        object boxedDouble = doubleValue; // Boxing

        Console.WriteLine("\nBoxing double:");
        Console.WriteLine("Double value: " + doubleValue);
        Console.WriteLine("Boxed double: " + boxedDouble);

        double unboxedDouble = (double)boxedDouble; // Unboxing

        Console.WriteLine("\nUnboxing double:");
        Console.WriteLine("Object type: " + boxedDouble);
        Console.WriteLine("Unboxed double: " + unboxedDouble);
        

        int a = 9;
        int b = 10;

        a += 5;
        Console.WriteLine(a);
 
        int myInt = 10;
        double myDouble = 5.25;
        bool myBool = true;

        Console.WriteLine(Convert.ToString(myInt));    // convert int to string
        Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
        Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
        Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        */

        //write a program based on boxing and unboxing
        int num = 9;
        object obj = num;
        Console.WriteLine(num.GetType());
        Console.WriteLine(obj.GetType());

        int num1 = 1;
        object obj1 = num1;

        int num2 = 2;
        object obj2 = num2;

        string na = "Suyog";
        object obj4 = na;
        na = "Dighe";
        Console.WriteLine(na);
        Console.WriteLine(obj4);

        object unbox = "suyog";
        string str =(string)unbox;

        object unbox1 = "gaurav";
        string str1 = (string)unbox1;

        object unbox2 = "ritesh";
        string str2 = (string)unbox2;

        Type unboxType = unbox.GetType();

        Console.WriteLine("Type of unbox: " + unboxType);

        string name = "Vaibhav";
        object obj12 = name;
        name = "Ghanghav";
        Console.WriteLine("Value - type value of name is : {0}", name);
        Console.WriteLine("Object - type value of obj is : {0}", obj12);


        Console.WriteLine("Enter the roll number");
        int a= Convert.ToInt32(Console.ReadLine());

        if (a == 9)
        {
            Console.WriteLine("roll no is : " + obj + " & name is : " + str);
        }
        else if (a == 1)
        {
            Console.WriteLine("roll no is : " + obj1 + " & name is : " + str1);
        }
        else if (a == 2)
        {
            Console.WriteLine("roll no is : " + obj2 + " & name is : " + str2);
        }
        else
        {
            Console.WriteLine("invalid roll number");
        }



    }
}