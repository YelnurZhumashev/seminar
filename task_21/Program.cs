// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты точки");
Console.Write("A1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("A2: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B1: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B2: ");
int y2 = Convert.ToInt32(Console.ReadLine());


double Distance(int xa, int ya, int xb, int yb)
{
    int cat1 = xa - xb;
    int cat2 = ya - yb;
    double result = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return result;
}

double distance = Distance(x1, y1, x2, y2);
double dRound = Math.Round(distance, 2, MidpointRounding.ToZero);

Console.WriteLine($"A ({x1}, {y1}); B ({x2}, {y2}) -> {dRound}");