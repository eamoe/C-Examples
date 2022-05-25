//Generates an array. Numbers are within [_from, _to)
int [] generateArray(int _size, int _from = 0, int _to = 10)
{
    int [] arr = new int[_size];

    for(int i = 0; i < _size; i++)
    {
        arr[i] = new Random().Next(_from, _to);
    }

    return arr;
}

//Prints an array
void printArray(int [] arr)
{
    Console.Write("[");

    for(int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($"{arr[i]}]");

        else Console.Write($"{arr[i]}, ");
    }
}

//Finds the min/ max elements
int findMinMax(int [] array, Boolean _isMax)
{    
    int result = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (result < array[i] && _isMax == true) result = array[i];

        if (result > array[i] && _isMax == false) result = array[i];
    }

    return result;
}

/*
//The main
int [] array = generateArray(8, 10, 100);

printArray(array);

int max = findMinMax(array, false);
Console.Write($"\n{max}");
*/