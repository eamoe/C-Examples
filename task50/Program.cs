/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9 */

int [,] generateArray(int rowsNumber, int columnsNumber, int scale)
{
    int [,] array = new int[rowsNumber, columnsNumber];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, scale);
        }
    }

    return array;
}

void printArray(int [,] array)
{
    Console.Write($"\t\t");

    for (int headerColumnNumber = 0; headerColumnNumber < array.GetLength(1); headerColumnNumber++)
    {
        Console.Write($"[{headerColumnNumber}]\t");
    }

    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"\nСтрока {i}\t");
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}\t");
        }
    }
}

void getElementByPosition(int [,] array, int searchedPosition)
{
    if (searchedPosition > (array.GetLength(0) * array.GetLength(1) - 1))
    {
        Console.WriteLine("Такого элемента нет!");
    }
    else
    {
        int currentPosition = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (currentPosition == searchedPosition)
                {
                    Console.WriteLine($"Элемент, находящийся на позиции {currentPosition} равен: {array[i, j]}");
                }
                currentPosition++;
            }
        }
    }
}

Console.WriteLine("Сгенерированный массив случайных чисел:");

int [,] randomArray = generateArray(5, 5, 10);

printArray(randomArray);

Console.Write("\nВведите позицию элемента: ");

int position = Convert.ToInt32(Console.ReadLine());

getElementByPosition(randomArray, position);