/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.*/

Console.WriteLine("Enter a number");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write("{0} ", Convert.ToString(i));
        }
    }
}
else
{
    Console.Write("Incorrect number.");
}