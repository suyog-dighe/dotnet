
/*
 * int a = 4;
int b = 9;

//relational operator
if (a == b)
{
    Console.WriteLine("same number");
}
else
{
    Console.WriteLine("different number ");
}
String result=(a < b) ? "b is bigger number" : "a is gretter";
Console.WriteLine(result);
Console.WriteLine(Math.Max(a, b));
Console.WriteLine(Math.Min(a, b));
Console.WriteLine(Math.Sqrt(a));
*/
/*
using System;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        // Equality Operator (==)
        bool isEqual = (a == b);
        Console.WriteLine($"{a} == {b} : {isEqual}");

        // Inequality Operator (!=)
        bool isNotEqual = (a != b);
        Console.WriteLine($"{a} != {b} : {isNotEqual}");

        // Greater Than Operator (>)
        bool isGreater = (a > b);
        Console.WriteLine($"{a} > {b} : {isGreater}");

        // Less Than Operator (<)
        bool isLess = (a < b);
        Console.WriteLine($"{a} < {b} : {isLess}");

        // Greater Than or Equal To Operator (>=)
        bool isGreaterOrEqual = (a >= b);
        Console.WriteLine($"{a} >= {b} : {isGreaterOrEqual}");

        // Less Than or Equal To Operator (<=)
        bool isLessOrEqual = (a <= b);
        Console.WriteLine($"{a} <= {b} : {isLessOrEqual}");
    }
}
*/

using System;

class RealTimeRelationalOperators
{
    static void Main()
    {
        
        int studentGrade = 85; 
        int passingGrade = 60;
        int studentAge = 20;
        int votingAge = 18;

        

        // Check if the student has passed
        bool hasPassed = studentGrade >= passingGrade;
        Console.WriteLine("Student has passed: " + hasPassed);  

        // Check if the student grade is an A (>= 90)
        bool isGradeA = studentGrade >= 90;
        Console.WriteLine("Student's grade is A: " + isGradeA);  

        // Check if the student is of voting age
        bool canVote = studentAge >= votingAge;
        Console.WriteLine("Student can vote: " + canVote);  

        // Compare student's age with a friend's age
        int friendAge = 22;
        bool isStudentOlder = studentAge > friendAge;
        Console.WriteLine("Student is older than friend: " + isStudentOlder);  

        // Check if student and friend are the same age
        bool areSameAge = studentAge == friendAge;
        Console.WriteLine("Student and friend are the same age: " + areSameAge);  

        // Check if student is younger than 21
        bool isYoungerThan21 = studentAge < 21;
        Console.WriteLine("Student is younger than 21: " + isYoungerThan21);  // true
    }
}

