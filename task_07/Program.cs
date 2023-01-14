// 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Введите число: "); 
int num = Convert.ToInt32(Console.ReadLine()); 
if (num >= 100 && num < 1000)
{
    int res = num % 10; 
    Console.WriteLine(res);
}
else 
{
    Console.WriteLine("Введено некорректное значение!");
}