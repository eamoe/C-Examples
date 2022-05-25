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
        Console.Write("{0:F2} ", arr[i]);
    }
}

double findMinMax(double [] array, Boolean isMax)
{    
    double result = array[0];

    if (isMax == true)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (result < array[i]) result = array[i];
        }
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (result > array[i]) result = array[i];
        }
    }

    return result;
}

double [] array = generateArray(8);

Console.Write("Сгенерированный массив: ");

printArray(array);

double min = findMinMax(array, false);
double max = findMinMax(array, true);

Console.Write("\nРазница между максимальным и минимальным значением равна: {0:F2}", max - min);