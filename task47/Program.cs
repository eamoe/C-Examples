/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double [,] generateArray(int rowsNumber, int columnsNumber, int scale)
{
    double [,] array = new double[rowsNumber, columnsNumber];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * scale;
        }
    }

    return array;
}

void printArray(double [,] array)
{

    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"Строка {i+1}\t");
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(array[i, j], 2)}\t");
        }

        Console.Write("\n");
    }
}

Console.Write("Укажите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double [,] randomArray = generateArray(rows, columns, 10);

printArray(randomArray);