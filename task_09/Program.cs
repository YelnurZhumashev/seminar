﻿// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 
// 78 -> 8
// 12 -> 2
// 85 -> 8


int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if(firstDigit > secondDigit) 
// Console.WriteLine($"Наибольшая цифра число -> {firstDigit}");
// else 
// Console.WriteLine($"Наибольшая цифра число -> {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра число -> {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра число -> {maxDigit}");

int MaxDigit(int num){
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;   
}