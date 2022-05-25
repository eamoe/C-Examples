/* Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int [] sumPairs(int [] arr)
{
    int size;
    
    if(arr.Length % 2 == 0)
    {
        size = arr.Length / 2;
    }
    else
    {
        size = (arr.Length / 2) + 1;
    }
    
    int [] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        if(size % 2 == 0)
        {
            result[i] = arr[i] * arr[arr.Length - i - 1];
        }
        else
        {
            result[i] = arr[i];
        }
    }

    return result;    
}

int [] generateArray(int size, int from, int to)
{
    int [] arr = new int[size];

    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }

    return arr;
}

void printArray(int [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0} ", arr[i]);
    }
}

int [] array = generateArray(7, 0, 10);

Console.Write("Сгенерированный массив: ");

printArray(array);

int [] summedArray = sumPairs(array);

Console.Write("\nПроизведение пар элементов массива: ");

printArray(summedArray);