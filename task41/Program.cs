/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

//Get string of numbers
string getStringOfNumbers()
{
    Console.Write("Введите M чисел через пробел или запятую и пробел: ");

    string str = Console.ReadLine();
    
    return str;
}

//Convert string of numbers to array of numbers
int [] convertToNumbersArray(string str)
{
    string [] separator = {" ", ", "};
    string [] numbersStr = str.Split(separator, StringSplitOptions.None);

    int [] numbers = new int[numbersStr.Length];

    for (int i = 0; i < numbersStr.Length; i++)
    {
        numbers[i] = Convert.ToInt32(numbersStr[i]);
    }

    return numbers;
}

//Count positive numbers
int countPositiveNumbers(int [] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }

    return count;
}

string numbersStr = getStringOfNumbers();

int [] numbers = convertToNumbersArray(numbersStr);

Console.Write($"Положительных чисел больше нуля среди введенных: {countPositiveNumbers(numbers)}");