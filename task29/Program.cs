/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void printArray(int [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0} ", arr[i]);
    }
}

int [] generateArray(int size)
{
    int [] arr = new int[size];

    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }

    return arr;
}

int [] array = generateArray(8);

Console.Write("Сгенерированный массив: ");

printArray(array);