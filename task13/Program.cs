/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

//int randomNumber = new Random().Next(1, 100000);

int randomNumber = -14172;

//Adopting negative numbers
int positiveRandomNumber = randomNumber;
if (positiveRandomNumber < 0) positiveRandomNumber *= -1;

//Count digits in a number
string numberStr = Convert.ToString(positiveRandomNumber);

if (numberStr.Length < 3)
{
    System.Console.Write($"В числе {randomNumber} нет третьей цифры");
}
else
{
    int thirdDigit = Convert.ToInt32(numberStr.Substring(2, 1));
    
    System.Console.Write($"В числе {randomNumber} третья цифра равна {thirdDigit}");
}