/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

Boolean isPalindrome(int number)
{
    string numberStr = Convert.ToString(number);
    
    Boolean check = true;

    for(int i = 0; i < (numberStr.Length - i -1); i++)
    {
        if (numberStr[i] != numberStr[numberStr.Length - i -1])
        {
            check = false;
        }
    }

    return check;    
}

Console.WriteLine("Введите целое пятизначное число: ");

int userNumber = Convert.ToInt32(Console.ReadLine());

if (isPalindrome(userNumber))
{
    Console.WriteLine($"Число {userNumber} является палиндромом!");
}
else
{
    Console.WriteLine($"Число {userNumber} НЕ является палиндромом!");
}