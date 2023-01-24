// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool Multiplicity(int number)
{
    return number > 5 && number < 8;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool res = Multiplicity(num);
Console.WriteLine (res ? $"{num} -> Да": $"{num} -> Нет");