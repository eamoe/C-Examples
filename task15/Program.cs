/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 && number > 7)
{
    Console.WriteLine($"Число {number} не соответствует ни одному дню недели!");
}
else
{
    switch (number)
    {
        case 1:
            Console.WriteLine("Нет, это не выходной!");
            break;

        case 2:
            Console.WriteLine("Нет, это не выходной!");
            break;

        case 3:
            Console.WriteLine("Нет, это не выходной!");
            break;

        case 4:
            Console.WriteLine("Нет, это не выходной!");
            break;

        case 5:
            Console.WriteLine("Нет, это не выходной!");
            break;

        case 6:
            Console.WriteLine("Да, это выходной!");
            break;

        case 7:
            Console.WriteLine("Да, это выходной!");
            break;

        default:
            Console.WriteLine($"Число {number} не соответствует ни одному дню недели!");
            break;
    }
}
