// 24. Напишите программу, которая принимает на вход число (А) и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 


int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} -> {sumNumbers}");


int SumNumbers(int num)
{
    int sum =1;
    for (int i = 1; i <= num; i++)
    {
        sum = sum * i;
    }
    return sum;
}