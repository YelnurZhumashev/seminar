﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int maxDigit = MaxDigit(number);
Console.WriteLine($"Третья число -> {maxDigit}");

int MaxDigit(int num){
    if (num > 99) 
        while (num > 1000) 
        {
            num = num / 10;
        }
        int result = num % 10;
    return result;   
}
