// Task № 21 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А  ->");
Console.Write("X1: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B  ->");
Console.Write("X2: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
}

double res = Math.Round(Distance(xa, ya, za, xb, yb, zb), 2);
Console.WriteLine(res);




