/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double [] generateArray(int size)
{
    double [] arr = new double[size];

    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble() * 100;
    }

    return arr;
}

void printArray(double [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0:F5} ", arr[i]);
    }
}

double getMinMax(double [] array, Boolean isMax = true)
{
    double [] copy = new double [array.Length];

    Array.Copy(array, copy, array.Length);
    
    double result = 0;

    Array.Sort(copy);

    if (isMax == true)
    {
        result = copy[array.Length - 1];
    }
    else
    {
        result = copy[0];
    }

    return result;
}

double [] array = generateArray(8);

Console.Write("Сгенерированный массив: ");

printArray(array);

Console.Write("\nРазница между максимальным и минимальным значением равна: {0:F5}", getMinMax(array) - getMinMax(array, false));