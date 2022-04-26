/*Напишите программу, которая принмиает на вход три числа и выдает максимальное из этих чисел.*/

Console.WriteLine("Enter first number");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");

int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number");

int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.WriteLine("Maximum of {0}, {1}, {2} is {3}",
            Convert.ToString(firstNumber),
            Convert.ToString(secondNumber),
            Convert.ToString(thirdNumber),
            Convert.ToString(firstNumber));
    }
    else
    {
        Console.WriteLine("Maximum of {0}, {1}, {2} is {3}",
                Convert.ToString(firstNumber),
                Convert.ToString(secondNumber),
                Convert.ToString(thirdNumber),
                Convert.ToString(thirdNumber));
    }
}
else if (secondNumber > thirdNumber)
    {
        Console.WriteLine("Maximum of {0}, {1}, {2} is {3}",
            Convert.ToString(firstNumber),
            Convert.ToString(secondNumber),
            Convert.ToString(thirdNumber),
            Convert.ToString(secondNumber));
    }
else
{
    Console.WriteLine("Maximum of {0}, {1}, {2} is {3}",
            Convert.ToString(firstNumber),
            Convert.ToString(secondNumber),
            Convert.ToString(thirdNumber),
            Convert.ToString(thirdNumber));
}