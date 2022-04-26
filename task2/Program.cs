/* Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше. */

Console.WriteLine("Enter first number");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");

int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine("{0} bigger than {1}", Convert.ToString(firstNumber), Convert.ToString(secondNumber));
}
else
{
    Console.WriteLine("{0} bigger than {1}", Convert.ToString(secondNumber),Convert.ToString(firstNumber));
}