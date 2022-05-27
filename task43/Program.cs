/* Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double [] inputCoeffs(int line)
{
    double [] arr = new double[2];
    
    Console.WriteLine($"Введите данные {line}-й прямой:");

    Console.Write($"k{line} = ");
    arr[0] = Convert.ToDouble(Console.ReadLine());
    
    Console.Write($"b{line} = ");
    arr[1] = Convert.ToDouble(Console.ReadLine());

    return arr;
}

double [] intersectionPoint(double [] arr1, double [] arr2)
{
    double [] point = new double[2];
    
    point[0] = (arr1[1] - arr2[1]) / (arr2[0] - arr1[0]);

    point[1] = arr1[0] * point[0] + arr1[1];

    return point;
}

void printArray(double [] arr)
{
    Console.Write("(");

    for(int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1) Console.Write($"{arr[i]})");

        else Console.Write($"{arr[i]}, ");
    }
}

double [] line1 = inputCoeffs(1);
double [] line2 = inputCoeffs(2);

Console.Write("Координаты точки пересечения прямых ");
printArray(intersectionPoint(line1, line2));