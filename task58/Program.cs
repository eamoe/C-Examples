/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

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

int [,] createMatrix()
{
    Console.Write("Введите число строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите число столбцов: ");
    int cols = Convert.ToInt32(Console.ReadLine());

    int [,] matrix = generateArray(rows, cols, 10);

    return matrix;
}

int [,] multiplyMatrixes(int [,] matrix1, int [,] matrix2)
{
    int [,] result = new int [matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            result[i, j] = 0;

            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                result[i, j] = result[i, j] + matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return result;
}

Console.WriteLine("-- Матрица 1 --");
int [,] matrix1 = createMatrix();

Console.WriteLine("-- Матрица 2 --");
int [,] matrix2 = createMatrix();

Console.WriteLine("\nМатрица 1");
printArray(matrix1);

Console.WriteLine("\nМатрица 2");
printArray(matrix2);


if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("\nЧисло столбцов первой матрицы должно быть равно числу строк второй матрицы.");
}
else
{
    Console.WriteLine("\nПроизведение матриц");
    int [,] multipledMatrixes = multiplyMatrixes(matrix1, matrix2);
    printArray(multipledMatrixes);
}