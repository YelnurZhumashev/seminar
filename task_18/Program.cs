﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (х и у).

Console.WriteLine("Введите номер четверти");

string quarter = Console.ReadLine();

string result = RangeCoordinates(quarter);

Console.WriteLine(result);

string RangeCoordinates(string cords)
{
    if(cords == "1") return "x > 0, y > 0";
    if(cords == "2") return "x < 0, y > 0";
    if(cords == "3") return "x < 0, y < 0";
    if(cords == "4") return "x > 0, y < 0";
    return "Введите корректные данные";
}