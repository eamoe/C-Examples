/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int sumOfDigits(int number)
{
    if (number < 0) number = number * (-1);
    
    string numberStr = Convert.ToString(number);
    
    int sum = 0;

    for(int i = 0; i < numberStr.Length; i++)
    {
        int currentNumber = Convert.ToInt32(numberStr.Substring(i, 1));
        
        sum = sum + currentNumber;
    }

    return sum;    
}

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {number} равна: {sumOfDigits(number)}");