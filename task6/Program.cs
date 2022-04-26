/*Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).*/

Console.WriteLine("Enter a number");

int number = Convert.ToInt32(Console.ReadLine());

switch (number % 2)
{
    case 0:
        Console.WriteLine("Number {0} is even", Convert.ToString(number));
        break;
    default:
        Console.WriteLine("Number {0} is odd", Convert.ToString(number));
        break;
}