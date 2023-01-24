// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1


int number = new Random().Next(100, 1000);
Console.WriteLine($"трехзначное число -> {number}");

int res = SecondDigit(number);

Console.WriteLine($"результат -> {res}");

int SecondDigit(int num)
{
    int num1 = num / 10;
    int num3 = num1 % 10;
    int result = num3;
    return result;
}