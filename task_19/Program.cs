// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 

void palindrome(int number)
{
    int num1 = number / 10000 % 10;
    int num2 = number / 1000 % 10;
    int rev1 = number / 10 % 10;
    int rev2 = number % 10;
    int nul = number / 10000;

    if (nul < 1 || nul > 9)
    {
        Console.WriteLine($"{number} -> Введены некорректные значение");
    }
    else if  (num1 == rev2 && num2 == rev1)
    {
        Console.WriteLine($"{number} -> Да");
    }
    else
    {
        Console.WriteLine($"{number} -> Нет");
    }
}
palindrome(number);

    // Второй вариант        

// Console.WriteLine("Введите число для проверки на полиндром");
// string num = Console.ReadLine();
// string rev = string.Concat(num.Reverse());
// Console.WriteLine(num == rev ? $"{num} -> Да" : $"{num} -> Нет");