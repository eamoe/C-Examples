/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

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

int countEvenNumbers(int [] arr)
{
    int count = 0;
    
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count++;
        }
    }

    return count;
}

int [] array = generateArray(8, 100, 1000);

Console.Write("Сгенерированный массив: ");

printArray(array);

Console.Write($"\nВ этом массиве {countEvenNumbers(array)} четных чисел.");