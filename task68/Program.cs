/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

int getNumber (string whichNumber = "")
{
    Console.Write($"Введите {whichNumber} неотрицательное целое число: ");

    int number = 0;

    Boolean isPositive = false;

    while (!isPositive)
    {
        number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.Write($"Число {number} не является целым неотрицательным! Попробуйте снова: ");
        }
        else
        {
            isPositive = true;
        }
    }

    return number;
}

int Ackermann (int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }

    return Ackermann(m - 1, Ackermann(m, n - 1));
}

int firstNumber = getNumber("первое");
int secondNumber = getNumber("второе");

int result = Ackermann(firstNumber, secondNumber);
Console.Write($"Результат применения функции Аккермана: {result}");