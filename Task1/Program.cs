Console.WriteLine("Введите координаты точки А  ->");
Console.Write("X1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Y1: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Z1: ");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B  ->");
Console.Write("X2: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Y2: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Z2: ");
double zb = Convert.ToDouble(Console.ReadLine());

double range = Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya) + (zb - za)*(zb - za));
double res = Math.Round(range , 2);
Console.WriteLine(res);




