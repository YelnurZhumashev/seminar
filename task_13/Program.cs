// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6




Console.Write("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine()); 
if (num > 100){
    while (num > 1000){
        num = num / 10;
    }

    int res = num % 10; 
    Console.WriteLine($"{num} -> {res}");
}
else 
{
    Console.WriteLine($"{num} -> третьей цифры нет");
}


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 0)
//     number = (number < 0 ? -number : number);
// if (number < 100)
//     Console.WriteLine($"У числа {number} нет третьей цифры.");
// int FindDigit(int digit)
// {
//     int result = 0;
//     while (digit > 999)
//         digit = digit / 10;
//     result = digit % 10;
//     return result;
// }
// Console.WriteLine(FindDigit(number));


// Console.Write("Введите число: "); 
// int num = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("Третья число -> "); 
// if (num > 99)
// {
//     while (num > 1000)
//     {
//         num = num / 10;
//         result = num % 10;
//         Console.Write(result);
//     }
// }
// else 
// {
//     Console.Write("третьей цифры нет");
// }

// int number = new Random().Next(-100000, 100000);
// Console.WriteLine($"Получено число {number}");
// if (number < 0)
//     number = (number < 0 ? -number : number);
// if (number < 100)
//     Console.WriteLine($"У числа {number} нет третьей цифры.");
// int FindDigit(int digit)
// {
//     int result = 0;
//     while (digit > 999)
//         digit = digit / 10;
//     result = digit % 10;
//     return result;
// }
// Console.WriteLine(FindDigit(number));