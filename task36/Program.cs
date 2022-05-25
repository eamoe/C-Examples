/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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

int sumOddPositionNumbers(int [] arr)
{
    int sum = 0;
    
    for(int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];
    }

    return sum;
}

int [] array = generateArray(8, -100, 100);

Console.Write("Сгенерированный массив: ");

printArray(array);

Console.Write($"\nСумма элементов на нечетных позициях равна {sumOddPositionNumbers(array)}");