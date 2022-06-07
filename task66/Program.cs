/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

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

int countSum(int firstNumber, int secondNumber, int step)
{    
    if (firstNumber == secondNumber)
    {
        return secondNumber;
    }

    return firstNumber + countSum(firstNumber + step, secondNumber, step);
}

int firstNumber = getNumber("первое");
int secondNumber = getNumber("второе");

int step = defineStep(firstNumber, secondNumber);

int sum = countSum(firstNumber, secondNumber, step);
Console.Write($"Сумма натуральных чисел равна: {sum}");