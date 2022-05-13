/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int randomNumber = new Random().Next(100, 1000);

int secondDigit = (randomNumber % 100) / 10;

System.Console.Write($"Вторая цифра числа {randomNumber} равна {secondDigit}");