/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

double [] columnAverage(int [,] array)
{
    double [] averages = new double[array.GetLength(0)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }

        averages[j] = sum / array.GetLength(0);
    }

    return averages;
}

void printAverages(double [] arr)
{
    Console.Write("[");

    for(int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($"{arr[i]}]");

        else Console.Write($"{arr[i]}, ");
    }
}

int [,] randomArray = generateArray(5, 5, 10);

Console.WriteLine("Сгенерированный массив случайных чисел:");

printArray(randomArray);

Console.Write("\n\nСреднее арифметическое каждого столбца: ");

double [] averages = columnAverage(randomArray);

printAverages(averages);