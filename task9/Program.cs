// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру.

int randomNumber = new Random().Next(10, 100);

int numberOne = randomNumber % 10;
int numberTwo = randomNumber / 10;

Console.Write($"У числа {randomNumber} большая цифра ");

if (numberOne > numberTwo)
{
    Console.Write(numberOne);
}
else
{
    Console.Write(numberTwo);
}