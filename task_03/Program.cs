﻿// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Название дня недели: "); 
if (num == 1)
    Console.WriteLine("Понедельник");
else if (num == 2)
    Console.WriteLine("Вторник");
else if (num == 3)
    Console.WriteLine("Среда");
else if (num == 4)
    Console.WriteLine("Четверг");
else if (num == 5)
    Console.WriteLine("Пятница");
else if (num == 6)
    Console.WriteLine("Суббота");
else if (num == 7)
    Console.WriteLine("Воскресенья");
else Console.WriteLine("Введено некорректное значение");