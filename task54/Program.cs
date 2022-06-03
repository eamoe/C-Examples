/* Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива. */

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

void sortElements(int [,] array)
{
    int temp;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < (array.GetLength(1) - 1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    temp= array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] randomArray = generateArray(rows, columns, 10);

Console.WriteLine("Сгенерированный массив случайных чисел:");

printArray(randomArray);

sortElements(randomArray);
Console.WriteLine("\nОтсортированный массив:");
printArray(randomArray);