using System;

Console.WriteLine("exercise 1");

Console.WriteLine("enter first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number:");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("numbers equal");
}
else if (a > b)
{
    Console.WriteLine("first number is greater");
}
else if (a < b)
{
    Console.WriteLine("second number is greater");
}

Console.WriteLine("exercise 2");

Console.WriteLine("enter number:");
int a1 = Convert.ToInt32(Console.ReadLine());
if (a1 <= 5 && a1 >= 10)
{
    Console.WriteLine("number is greater than 5 and less than 10");
}
else
{
    Console.WriteLine("unknown number");
}

Console.WriteLine("exercise 3");

Console.WriteLine("enter number:");
int a2 = Convert.ToInt32(Console.ReadLine());
if (a2 == 5 ||  a2 == 10)
{
    Console.WriteLine("number is either 5 or 10");
}
else
{
    Console.WriteLine("unknown number");
}

Console.WriteLine("exercise 4");

Console.WriteLine("enter number:");
double a3 = Convert.ToDouble(Console.ReadLine());
double interest;
if (a3 < 100)
{
    interest = a3 * 0.05;
}
else if (a3 > 100 && a3 < 200)
{
    interest = a3 * 0.07;
}
else
{
    interest = a3 * 0.1;
}
Console.WriteLine($"deposit amount: {a3 + interest}");

Console.WriteLine("exercise 5");

Console.WriteLine("enter number:");
double a4 = Convert.ToDouble(Console.ReadLine());
double interes;
if (a4 < 100)
{
    interes = a4 * 0.05;
}
else if (a4 > 100 && a4 < 200)
{
    interes = a4 * 0.07;
}
else
{
    interes = a4 * 0.1;
}
Console.WriteLine($"deposit amount: {a4 + interes + 15}");

Console.WriteLine("exercise 6");

Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
int a5 = Convert.ToInt32(Console.ReadLine());
switch (a5)
{
    case 1:
        Console.WriteLine("addition");
        break;
    case 2:
        Console.WriteLine("substraction");
        break;
    case 3:
        Console.WriteLine("multiplication");
        break;
    default:
        Console.WriteLine("operation is undefined");
        break;
}

Console.WriteLine("exercise 7");

Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter first number");
int s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number");
int m = Convert.ToInt32(Console.ReadLine());
switch (d)
{
    case 1:
        Console.WriteLine($"result: {s + m}");
        break;
    case 2:
        Console.WriteLine($"result: {s - m}");
        break;
    case 3:
        Console.WriteLine($"result: {s * m}");
        break;
    default:
        Console.WriteLine("operation is undefined");
        break;
}

