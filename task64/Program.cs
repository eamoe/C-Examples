/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4" */

int getNumber (string whichNumber = "")
{
    Console.Write($"Введите {whichNumber} натуральное число: ");

    int number = 0;

    Boolean isNatural = false;

    while (!isNatural)
    {
        number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.Write($"Число {number} не является натуральным! Попробуйте снова: ");
        }
        else
        {
            isNatural = true;
        }
    }

    return number;
}

int defineStep(int firstNumber, int secondNumber)
{
    if (firstNumber > secondNumber)
    {
        return -1;
    }
    else
    {
        return 1;
    }
}

void printRange(int firstNumber, int secondNumber, int step)
{
    int rollingNumber = firstNumber;

    if (rollingNumber == secondNumber)
    {
        Console.Write($"{rollingNumber}.");

        return;
    }

    Console.Write($"{rollingNumber}, ");

    printRange(rollingNumber + step, secondNumber, step);
}

int firstNumber = getNumber("первое");
int secondNumber = getNumber("второе");

int step = defineStep(firstNumber, secondNumber);

printRange(firstNumber, secondNumber, step);