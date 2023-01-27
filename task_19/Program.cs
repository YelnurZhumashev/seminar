// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да




Console.WriteLine("Введите число для проверки на полиндром");
string num = Console.ReadLine();
string rev = string.Concat(num.Reverse());
Console.WriteLine(num == rev ? $"{num} -> Да" : $"{num} -> Нет");




            



// void palindrom()
//         {
//         Console.Write("Insert 5-digit number: ");
//         int number = Convert.ToInt32(Console.ReadLine()); 
//         int num1 = number / 10000 % 10;
//         int num2 = number / 1000 % 10;
//         int rev1 = number / 10 % 10;
//         int rev2 = number % 10;
//         int nul = number / 10000;
        
// Console.Write("Введите число: "); 
// int num = Convert.ToInt32(Console.ReadLine()); 

// 
//             int number = int.Parse(Console.ReadLine());
//             int pal = 0, num = number;
//             while (number > 0) {pal = pal * 10 + number % 10; number /= 10;}  