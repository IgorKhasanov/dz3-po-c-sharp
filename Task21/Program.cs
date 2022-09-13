// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координаты точки A: ");
Console.Write("xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("zb: ");
int zb = Convert.ToInt32(Console.ReadLine());
double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    double d = (xc2 - xc1) * (xc2 - xc1) + (yc2 - yc1) * (yc2 - yc1) + (zc2 - zc1) * (zc2 - zc1);
    return Math.Round(Math.Sqrt(d), 2, MidpointRounding.ToZero);
}
Console.WriteLine(Distance(xa, ya, za, xb, yb, zb));