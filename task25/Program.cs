/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int aPowerB(int a, int b)
{
    int result = 1;
    
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }

    return result;
}

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите степень, в которую хотите возвести число {number}: ");

int power = Convert.ToInt32(Console.ReadLine());

Console.Write($"Результат возведения числа {number} в степень {power} равен: {aPowerB(number, power)}");
