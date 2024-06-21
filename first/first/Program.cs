// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Suyog!");
Console.WriteLine("Enter first number");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Second Number");
int b= Convert.ToInt32(Console.ReadLine());
//int c = a + b;
if (a < b)
{
    Console.WriteLine("maximum"+b);
}
else if (b < a)
{
    Console.WriteLine("maximum" +a);
}
else
{
    Console.WriteLine("equal");
}