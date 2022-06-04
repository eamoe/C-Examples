/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов. */

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

int [] rowSums(int [,] array)
{
    int [] sums = new int [array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sums[i] = sums[i] + array[i, j];
        }
    }

    return sums;
}

int findMinElement(int [] array)
{    
    int result = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <result)
        {
            result = array[i];
        }
    }

    return result;
}

Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] randomArray = generateArray(rows, columns, 10);

Console.WriteLine("Сгенерированный массив случайных чисел:");
printArray(randomArray);

int [] sums = rowSums(randomArray);

int minSum = findMinElement(sums);

Console.Write($"\nСтроки с минимальной суммой элементов: ");

for (int i = 0; i < sums.Length; i++)
{
    if (sums[i] == minSum)
    {
        Console.Write($" {i} ");
    }
}