/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

double dist(int [] array1, int [] array2)
{
    double dist = Math.Sqrt(Math.Pow(array1[0] - array2[0], 2) +
                                Math.Pow(array1[1] - array2[1], 2) +
                                Math.Pow(array1[2] - array2[2], 2));

    return dist;
}

void getPoint(int [] array)
{
    Console.Write("Введите координату X: ");
    array[0] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату Y: ");
    array[1] = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату Z: ");
    array[2] = Convert.ToInt32(Console.ReadLine());
}

int [] point1 = new int[3];
int [] point2 = new int[3];

Console.Write("Точка 1. ");
getPoint(point1);

Console.Write("Точка 2. ");
getPoint(point2);

double distance = dist(point1, point2);

Console.WriteLine("Расстояние между точками [{0}, {1}, {2}] и [{3}, {4}, {5}] равняется {6:F2}",
                point1[0], point1[1], point1[2],
                point2[0], point2[1], point2[2],
                distance);